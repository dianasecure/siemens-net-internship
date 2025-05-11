namespace LibraryManagement.UI
{
    partial class UserForm
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
            Books = new DataGridView();
            borrowButton = new Button();
            returnButton = new Button();
            searchButton = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Books).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Books
            // 
            Books.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Books.Location = new Point(12, 12);
            Books.Name = "Books";
            Books.RowHeadersWidth = 51;
            Books.Size = new Size(475, 188);
            Books.TabIndex = 0;
            Books.CellContentClick += Books_CellContentClick;
            // 
            // borrowButton
            // 
            borrowButton.Location = new Point(12, 219);
            borrowButton.Name = "borrowButton";
            borrowButton.Size = new Size(144, 45);
            borrowButton.TabIndex = 1;
            borrowButton.Text = "Borrow selected";
            borrowButton.UseVisualStyleBackColor = true;
            borrowButton.Click += borrowButton_Click;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(571, 220);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(166, 42);
            returnButton.TabIndex = 2;
            returnButton.Text = "Return Selected";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(236, 222);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(251, 42);
            searchButton.TabIndex = 4;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(324, 291);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(324, 347);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(163, 27);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 350);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 7;
            label1.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 294);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 8;
            label2.Text = "Title";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(534, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(242, 188);
            dataGridView1.TabIndex = 9;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(searchButton);
            Controls.Add(returnButton);
            Controls.Add(borrowButton);
            Controls.Add(Books);
            Name = "UserForm";
            Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)Books).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Books;
        private Button borrowButton;
        private Button returnButton;
        private Button searchButton;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
    }
}