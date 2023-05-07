using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ToggleMouseSensitivityTrayApp
{
    static class Program
    {
        private static NotifyIcon notifyIcon;
        private static bool shortcutKeyPressed = false;

        private static int slowMouseSpeed = 5;
        private static int fastMouseSpeed = 12;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll", SetLastError = true)]
        static extern Boolean SystemParametersInfo(UInt32 uiAction, UInt32 uiParam, IntPtr pvParam, UInt32 fWinIni);



        [STAThread]
        static void Main()
        {
            Debug.WriteLine("Start of main()");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create a new NotifyIcon object
            notifyIcon = new NotifyIcon();

            // Set the icon to be displayed in the system tray
            notifyIcon.Icon = Properties.Resources.icon;

            // Set a tooltip for the icon
            notifyIcon.Text = "Toggle Mouse Sensitivity";

            //Add title for notifications
            notifyIcon.BalloonTipTitle = "Toggle Mouse Sensitivity";

            // Show the icon in the system tray
            notifyIcon.Visible = true;

            // Create a new context menu for the icon
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();


            // Add a settings menu item to context menu that will open a Form
            ToolStripMenuItem settingsMenuItem = new ToolStripMenuItem();
            settingsMenuItem.Text = "Settings";
            settingsMenuItem.Click += new EventHandler(OpenSettings);
            contextMenuStrip.Items.Add(settingsMenuItem);

            // Add a "Exit" menu item to the context menu
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem();
            exitMenuItem.Text = "Exit";
            exitMenuItem.Click += new EventHandler(OnExit);
            contextMenuStrip.Items.Add(exitMenuItem);

            // Assign the context menu to the NotifyIcon
            notifyIcon.ContextMenuStrip = contextMenuStrip;

            // Register a hotkey with the system
            RegisterHotKey(IntPtr.Zero, 1, (int)Modifiers.Alt, (int)Keys.M);

            // Handle hotkey events
            Application.AddMessageFilter(new MessageFilter());

            // Start the application loop
            Application.Run();
        }

        private static void OpenSettings(object sender, EventArgs e)
        {

        }

        private static void OnExit(object sender, EventArgs e)
        {
            // Unregister the hotkey and dispose of the NotifyIcon object
            UnregisterHotKey(IntPtr.Zero, 1);
            notifyIcon.Dispose();

            // Exit the application
            Application.Exit();
        }

        private static void OnShortcutKeyPressed()
        {
            // Toggle the shortcut key state
            shortcutKeyPressed = !shortcutKeyPressed;

            Debug.WriteLine("shortcut key pressed");

            // Change the mouse speed or do any other action
            // ...


            IntPtr ptr;
            ptr = Marshal.AllocCoTaskMem(4);

            bool result = SystemParametersInfo(0x0070, 0, ptr, 0); // SPI_GETMOUSESPEED

            int currentMouseSpeed = Marshal.ReadInt32(ptr);
            Marshal.FreeCoTaskMem(ptr);

            if (!result)
            {
                Debug.WriteLine("Failed to retrieve mouse speed.");
                return;
            }

            Debug.WriteLine("Current mouse speed is {0}", currentMouseSpeed);

            int mousespeed = currentMouseSpeed == slowMouseSpeed ? fastMouseSpeed : slowMouseSpeed;

            ptr = new IntPtr(mousespeed);
            result = SystemParametersInfo(0x0071, 0, ptr, 0); // SPI_SETMOUSESPEED
            if (!result)
            {
                Debug.WriteLine("Failed to set mouse speed.");
            }
            else
            {
                //Show Balloon for notification
                notifyIcon.BalloonTipText = $"Mouse speed changed from {currentMouseSpeed} to {mousespeed}.";
                notifyIcon.ShowBalloonTip(1500);
                Debug.WriteLine($"Mouse speed changed from {currentMouseSpeed} to {mousespeed}.");
            }
        }

        private class MessageFilter : IMessageFilter
        {
            public bool PreFilterMessage(ref Message m)
            {
                if (m.Msg == 0x0312 && m.WParam.ToInt32() == 1)
                {
                    // The hotkey was pressed
                    OnShortcutKeyPressed();
                }

                // Allow the message to continue to the next filter
                return false;
            }
        }

        private enum Modifiers
        {
            Alt = 1,
            Control = 2,
            Shift = 4,
            Win = 8
        }

        private enum Keys
        {
            M = 0x4D
        }
    }
}
