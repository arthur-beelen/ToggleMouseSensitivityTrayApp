using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToggleMouseSensitivityTrayApp {
    public partial class SettingsForm : Form {

        public SettingsForm() {
            InitializeComponent();

            //Fetch mouse speed values from Program.cs and set them as the values of the sliders
            trackBar1.Value = Program.mouseSpeed1;
            trackBar2.Value = Program.mouseSpeed2;


        }


        private void saveButton_Click(object sender, EventArgs e) {
            //Save the values of the sliders to Program.cs
            Program.mouseSpeed1 = trackBar1.Value;
            Program.mouseSpeed2 = trackBar2.Value;

            //Save values in config.ini (like Porgram.cs)
            Program.WriteIniFile(Program.mouseSpeed1, Program.mouseSpeed2);


            //Close the settings window
            this.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e) {
            labelSensitivity1.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e) {
            labelSensitivity2.Text = trackBar2.Value.ToString();
        }
    }
}
