namespace EditPerson
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
            personsListView = new ListView();
            FName = new ColumnHeader();
            Surname = new ColumnHeader();
            Age = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // personsListView
            // 
            personsListView.Columns.AddRange(new ColumnHeader[] { FName, Surname, Age });
            personsListView.GridLines = true;
            personsListView.Location = new Point(12, 37);
            personsListView.Name = "personsListView";
            personsListView.Size = new Size(265, 290);
            personsListView.TabIndex = 0;
            personsListView.UseCompatibleStateImageBehavior = false;
            personsListView.View = View.Details;
            personsListView.VirtualMode = true;
            personsListView.RetrieveVirtualItem += personsListView_RetrieveVirtualItem;
            // 
            // FName
            // 
            FName.Text = "Name";
            FName.Width = 80;
            // 
            // Surname
            // 
            Surname.Text = "Surname";
            Surname.Width = 80;
            // 
            // Age
            // 
            Age.Text = "Age";
            Age.Width = 80;
            // 
            // button1
            // 
            button1.Location = new Point(12, 8);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(202, 8);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(283, 37);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Watch List";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(283, 66);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(204, 261);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 353);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(personsListView);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Employees";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView personsListView;
        private ColumnHeader FName;
        private ColumnHeader Surname;
        private ColumnHeader Age;
        private Button button1;
        private Button button2;
        private Button button3;
        private RichTextBox richTextBox1;
    }
}
