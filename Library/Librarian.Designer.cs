namespace Library
{
    partial class Librarian
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
            add_book = new Button();
            update_book = new Button();
            delete_book = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            book_name = new TextBox();
            date_of_creation = new TextBox();
            author = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // add_book
            // 
            add_book.Location = new Point(12, 150);
            add_book.Name = "add_book";
            add_book.Size = new Size(106, 23);
            add_book.TabIndex = 0;
            add_book.Text = "Добавить книгу";
            add_book.UseVisualStyleBackColor = true;
            // 
            // update_book
            // 
            update_book.Location = new Point(12, 179);
            update_book.Name = "update_book";
            update_book.Size = new Size(106, 23);
            update_book.TabIndex = 1;
            update_book.Text = "Редактировать";
            update_book.UseVisualStyleBackColor = true;
            // 
            // delete_book
            // 
            delete_book.Location = new Point(12, 208);
            delete_book.Name = "delete_book";
            delete_book.Size = new Size(106, 23);
            delete_book.TabIndex = 2;
            delete_book.Text = "Удалить книгу";
            delete_book.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(211, 14);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(203, 154);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(515, 179);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 94);
            listBox2.TabIndex = 5;
            // 
            // book_name
            // 
            book_name.Location = new Point(79, 11);
            book_name.Name = "book_name";
            book_name.Size = new Size(100, 23);
            book_name.TabIndex = 6;
            // 
            // date_of_creation
            // 
            date_of_creation.Location = new Point(79, 104);
            date_of_creation.Name = "date_of_creation";
            date_of_creation.Size = new Size(100, 23);
            date_of_creation.TabIndex = 7;
            // 
            // author
            // 
            author.Location = new Point(79, 55);
            author.Name = "author";
            author.Size = new Size(100, 23);
            author.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 14);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 9;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 10;
            label2.Text = "Автор";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 112);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 11;
            label3.Text = "Год издания";
            // 
            // Librarian
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(author);
            Controls.Add(date_of_creation);
            Controls.Add(book_name);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(delete_book);
            Controls.Add(update_book);
            Controls.Add(add_book);
            Name = "Librarian";
            Text = "Librarian";
            Load += Librarian_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add_book;
        private Button update_book;
        private Button delete_book;
        private ListBox listBox1;
        private ListBox listBox2;
        private TextBox book_name;
        private TextBox date_of_creation;
        private TextBox author;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}