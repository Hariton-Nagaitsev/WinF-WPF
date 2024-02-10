namespace Lab07_05
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
            MaxValueTextBox = new TextBox();
            ResultTextBox = new TextBox();
            StartButton = new Button();
            SuspendLayout();
            // 
            // MaxValueTextBox
            // 
            MaxValueTextBox.Location = new Point(26, 47);
            MaxValueTextBox.Name = "MaxValueTextBox";
            MaxValueTextBox.Size = new Size(100, 23);
            MaxValueTextBox.TabIndex = 0;
            // 
            // ResultTextBox
            // 
            ResultTextBox.Location = new Point(221, 47);
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.Size = new Size(214, 23);
            ResultTextBox.TabIndex = 1;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(26, 102);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(136, 35);
            StartButton.TabIndex = 2;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(447, 187);
            Controls.Add(StartButton);
            Controls.Add(ResultTextBox);
            Controls.Add(MaxValueTextBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Эратосфена";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MaxValueTextBox;
        private TextBox ResultTextBox;
        private Button StartButton;
    }
}
