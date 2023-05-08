namespace ToggleMouseSensitivityTrayApp {
    partial class SettingsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            saveButton = new System.Windows.Forms.Button();
            trackBar1 = new System.Windows.Forms.TrackBar();
            trackBar2 = new System.Windows.Forms.TrackBar();
            labelSlider1 = new System.Windows.Forms.Label();
            labelSlider2 = new System.Windows.Forms.Label();
            labelSensitivity1 = new System.Windows.Forms.Label();
            labelSensitivity2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Location = new System.Drawing.Point(18, 203);
            saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(536, 31);
            saveButton.TabIndex = 0;
            saveButton.Text = "Save settings";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new System.Drawing.Point(190, 23);
            trackBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            trackBar1.Maximum = 20;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new System.Drawing.Size(325, 56);
            trackBar1.TabIndex = 1;
            trackBar1.Value = 1;
            trackBar1.ValueChanged += trackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new System.Drawing.Point(190, 112);
            trackBar2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            trackBar2.Maximum = 20;
            trackBar2.Minimum = 1;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new System.Drawing.Size(325, 56);
            trackBar2.TabIndex = 2;
            trackBar2.Value = 1;
            trackBar2.ValueChanged += trackBar2_Scroll;
            // 
            // labelSlider1
            // 
            labelSlider1.AutoSize = true;
            labelSlider1.Location = new System.Drawing.Point(18, 23);
            labelSlider1.Name = "labelSlider1";
            labelSlider1.Size = new System.Drawing.Size(135, 20);
            labelSlider1.TabIndex = 3;
            labelSlider1.Text = "Sensitivity profile 1";
            // 
            // labelSlider2
            // 
            labelSlider2.AutoSize = true;
            labelSlider2.Location = new System.Drawing.Point(18, 112);
            labelSlider2.Name = "labelSlider2";
            labelSlider2.Size = new System.Drawing.Size(135, 20);
            labelSlider2.TabIndex = 4;
            labelSlider2.Text = "Sensitivity profile 2";
            // 
            // labelSensitivity1
            // 
            labelSensitivity1.AutoSize = true;
            labelSensitivity1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelSensitivity1.Location = new System.Drawing.Point(521, 23);
            labelSensitivity1.Name = "labelSensitivity1";
            labelSensitivity1.Size = new System.Drawing.Size(33, 38);
            labelSensitivity1.TabIndex = 5;
            labelSensitivity1.Text = "1";
            // 
            // labelSensitivity2
            // 
            labelSensitivity2.AutoSize = true;
            labelSensitivity2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelSensitivity2.Location = new System.Drawing.Point(521, 112);
            labelSensitivity2.Name = "labelSensitivity2";
            labelSensitivity2.Size = new System.Drawing.Size(33, 38);
            labelSensitivity2.TabIndex = 6;
            labelSensitivity2.Text = "1";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(566, 259);
            Controls.Add(labelSensitivity2);
            Controls.Add(labelSensitivity1);
            Controls.Add(labelSlider2);
            Controls.Add(labelSlider1);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(saveButton);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "SettingsForm";
            Text = "Toggle Mouse Sensitivity Settings";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label labelSlider1;
        private System.Windows.Forms.Label labelSlider2;
        private System.Windows.Forms.Label labelSensitivity1;
        private System.Windows.Forms.Label labelSensitivity2;
    }
}