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
            userMode.Location = new Point(314, 269);
            userMode.Name = "userMode";
            userMode.Size = new Size(161, 29);
            userMode.TabIndex = 1;
            userMode.Text = "User Login";
            userMode.UseVisualStyleBackColor = true;
            userMode.Click += userMode_Click;
            // 
            // name
            // 
            name.Location = new Point(314, 164);
            name.Name = "name";
            name.Size = new Size(161, 27);
            name.TabIndex = 2;
            // 
            // surname
            // 
            surname.Location = new Point(314, 218);
            surname.Name = "surname";
            surname.Size = new Size(161, 27);
            surname.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
