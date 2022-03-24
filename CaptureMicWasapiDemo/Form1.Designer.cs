namespace CaptureMicWasapiDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RecordingDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.PlaybackDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.RecordButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recording Device:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Playback Device:";
            // 
            // RecordingDeviceComboBox
            // 
            this.RecordingDeviceComboBox.FormattingEnabled = true;
            this.RecordingDeviceComboBox.Location = new System.Drawing.Point(236, 95);
            this.RecordingDeviceComboBox.Name = "RecordingDeviceComboBox";
            this.RecordingDeviceComboBox.Size = new System.Drawing.Size(449, 28);
            this.RecordingDeviceComboBox.TabIndex = 2;
            // 
            // PlaybackDeviceComboBox
            // 
            this.PlaybackDeviceComboBox.FormattingEnabled = true;
            this.PlaybackDeviceComboBox.Location = new System.Drawing.Point(236, 164);
            this.PlaybackDeviceComboBox.Name = "PlaybackDeviceComboBox";
            this.PlaybackDeviceComboBox.Size = new System.Drawing.Size(449, 28);
            this.PlaybackDeviceComboBox.TabIndex = 3;
            // 
            // RecordButton
            // 
            this.RecordButton.Location = new System.Drawing.Point(380, 233);
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.Size = new System.Drawing.Size(137, 44);
            this.RecordButton.TabIndex = 4;
            this.RecordButton.Text = "Record";
            this.RecordButton.UseVisualStyleBackColor = true;
            this.RecordButton.Click += new System.EventHandler(this.RecordButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(548, 233);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(137, 44);
            this.StopButton.TabIndex = 8;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.RecordButton);
            this.Controls.Add(this.PlaybackDeviceComboBox);
            this.Controls.Add(this.RecordingDeviceComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox RecordingDeviceComboBox;
        private ComboBox PlaybackDeviceComboBox;
        private Button RecordButton;
        private Button StopButton;
    }
}