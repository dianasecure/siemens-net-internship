namespace LibraryManagement.UI
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
            adminMode = new Button();
            userMode = new Button();
            name = new TextBox();
            surname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // adminMode
            // 
            adminMode.Location = new Point(34, 382);
            adminMode.Name = "adminMode";
            adminMode.Size = new Size(94, 29);
            adminMode.TabIndex = 0;
            adminMode.Text = "Admin mode";
            adminMode.UseVisualStyleBackColor = true;
            adminMode.Click += adminMode_Click;
            // 
            // userMode
            // 
            userMode.Location = new Point(325, 269);
            userMode.Name = "userMode";
            userMode.Size = new Size(161, 29);
            userMode.TabIndex = 1;
            userMode.Text = "User Login";
            userMode.UseVisualStyleBackColor = true;
            userMode.Click += userMode_Click;
            // 
            // name
            // 
            name.Location = new Point(360, 164);
            name.Name = "name";
            name.Size = new Size(161, 27);
            name.TabIndex = 2;
            name.TextChanged += name_TextChanged;
            // 
            // surname
            // 
            surname.Location = new Point(360, 215);
            surname.Name = "surname";
            surname.Size = new Size(161, 27);
            surname.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 167);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 4;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 218);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 5;
            label2.Text = "Surname";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(surname);
            Controls.Add(name);
            Controls.Add(userMode);
            Controls.Add(adminMode);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button adminMode;
        private Button userMode;
        private TextBox name;
        private TextBox surname;
        private Label label1;
        private Label label2;
    }
}
