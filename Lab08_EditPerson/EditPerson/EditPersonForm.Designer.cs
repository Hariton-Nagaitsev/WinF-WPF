namespace EditPerson
{
    partial class EditPersonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            ageNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 17);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 48);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 80);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(26, 117);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(183, 119);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(118, 17);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(168, 23);
            firstNameTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(118, 45);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(168, 23);
            lastNameTextBox.TabIndex = 6;
            // 
            // ageNumericUpDown
            // 
            ageNumericUpDown.Location = new Point(118, 78);
            ageNumericUpDown.Name = "ageNumericUpDown";
            ageNumericUpDown.Size = new Size(168, 23);
            ageNumericUpDown.TabIndex = 7;
            // 
            // EditPersonForm
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button2;
            ClientSize = new Size(344, 152);
            Controls.Add(ageNumericUpDown);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "EditPersonForm";
            ShowInTaskbar = false;
            Text = "Employee data edition";
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private NumericUpDown ageNumericUpDown;
    }
}