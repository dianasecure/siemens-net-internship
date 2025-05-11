namespace LibraryManagement.UI
{
    partial class AdminForm
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
            searchButton = new Button();
            addBook = new Button();
            button1 = new Button();
            byAuthor = new TextBox();
            byTitle = new TextBox();
            title = new TextBox();
            author = new TextBox();
            stock = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Update = new Button();
            ((System.ComponentModel.ISupportInitialize)Books).BeginInit();
            SuspendLayout();
            // 
            // Books
            // 
            Books.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Books.Location = new Point(46, 21);
            Books.Name = "Books";
            Books.RowHeadersWidth = 51;
            Books.Size = new Size(710, 188);
            Books.TabIndex = 0;
            Books.CellContentClick += Books_CellContentClick;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(67, 229);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(201, 29);
            searchButton.TabIndex = 1;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // addBook
            // 
            addBook.Location = new Point(321, 229);
            addBook.Name = "addBook";
            addBook.Size = new Size(191, 29);
            addBook.TabIndex = 2;
            addBook.Text = "Add book";
            addBook.UseVisualStyleBackColor = true;
            addBook.Click += addBook_Click;
            // 
            // button1
            // 
            button1.Location = new Point(589, 229);
            button1.Name = "button1";
            button1.Size = new Size(154, 29);
            button1.TabIndex = 3;
            button1.Text = "Delete selected";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // byAuthor
            // 
            byAuthor.Location = new Point(143, 319);
            byAuthor.Name = "byAuthor";
            byAuthor.Size = new Size(125, 27);
            byAuthor.TabIndex = 4;
            // 
            // byTitle
            // 
            byTitle.Location = new Point(143, 275);
            byTitle.Name = "byTitle";
            byTitle.Size = new Size(125, 27);
            byTitle.TabIndex = 5;
            // 
            // title
            // 
            title.Location = new Point(388, 271);
            title.Name = "title";
            title.Size = new Size(124, 27);
            title.TabIndex = 6;
            // 
            // author
            // 
            author.Location = new Point(388, 315);
            author.Name = "author";
            author.Size = new Size(124, 27);
            author.TabIndex = 7;
            // 
            // stock
            // 
            stock.Location = new Point(388, 359);
            stock.Name = "stock";
            stock.Size = new Size(124, 27);
            stock.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 322);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 9;
            label1.Text = "By author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 282);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 10;
            label2.Text = "By title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 274);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 11;
            label3.Text = "Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 318);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 12;
            label4.Text = "Author";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(321, 362);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 13;
            label5.Text = "Stock";
            // 
            // Update
            // 
            Update.Location = new Point(321, 405);
            Update.Name = "Update";
            Update.Size = new Size(192, 33);
            Update.TabIndex = 14;
            Update.Text = "Update book";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Update);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(stock);
            Controls.Add(author);
            Controls.Add(title);
            Controls.Add(byTitle);
            Controls.Add(byAuthor);
            Controls.Add(button1);
            Controls.Add(addBook);
            Controls.Add(searchButton);
            Controls.Add(Books);
            Name = "AdminForm";
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)Books).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Books;
        private Button searchButton;
        private Button addBook;
        private Button button1;
        private TextBox byAuthor;
        private TextBox byTitle;
        private TextBox title;
        private TextBox author;
        private TextBox stock;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Update;
    }
}