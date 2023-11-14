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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            groupBox1 = new GroupBox();
            groupbox2 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            update_reader = new Button();
            delete_reader = new Button();
            groupBox1.SuspendLayout();
            groupbox2.SuspendLayout();
            SuspendLayout();
            // 
            // add_book
            // 
            add_book.Location = new Point(18, 173);
            add_book.Name = "add_book";
            add_book.Size = new Size(106, 23);
            add_book.TabIndex = 0;
            add_book.Text = "Добавить книгу";
            add_book.UseVisualStyleBackColor = true;
            // 
            // update_book
            // 
            update_book.Location = new Point(18, 202);
            update_book.Name = "update_book";
            update_book.Size = new Size(106, 23);
            update_book.TabIndex = 1;
            update_book.Text = "Редактировать";
            update_book.UseVisualStyleBackColor = true;
            // 
            // delete_book
            // 
            delete_book.Location = new Point(18, 231);
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
            listBox1.Location = new Point(215, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(203, 154);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(225, 22);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(194, 154);
            listBox2.TabIndex = 5;
            // 
            // book_name
            // 
            book_name.Location = new Point(85, 34);
            book_name.Name = "book_name";
            book_name.Size = new Size(100, 23);
            book_name.TabIndex = 6;
            // 
            // date_of_creation
            // 
            date_of_creation.Location = new Point(85, 127);
            date_of_creation.Name = "date_of_creation";
            date_of_creation.Size = new Size(100, 23);
            date_of_creation.TabIndex = 7;
            // 
            // author
            // 
            author.Location = new Point(85, 78);
            author.Name = "author";
            author.Size = new Size(100, 23);
            author.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 37);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 9;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 86);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 10;
            label2.Text = "Автор";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 135);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 11;
            label3.Text = "Год издания";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(109, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(109, 118);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(add_book);
            groupBox1.Controls.Add(update_book);
            groupBox1.Controls.Add(delete_book);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(book_name);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(date_of_creation);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(author);
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 270);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Книги";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupbox2
            // 
            groupbox2.Controls.Add(delete_reader);
            groupbox2.Controls.Add(update_reader);
            groupbox2.Controls.Add(label6);
            groupbox2.Controls.Add(label5);
            groupbox2.Controls.Add(label4);
            groupbox2.Controls.Add(listBox2);
            groupbox2.Controls.Add(textBox1);
            groupbox2.Controls.Add(textBox3);
            groupbox2.Controls.Add(textBox2);
            groupbox2.Location = new Point(443, 12);
            groupbox2.Name = "groupbox2";
            groupbox2.Size = new Size(425, 270);
            groupbox2.TabIndex = 16;
            groupbox2.TabStop = false;
            groupbox2.Text = "Читатель";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 27);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 15;
            label4.Text = "Фамилия";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 74);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 16;
            label5.Text = "Имя";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 123);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 17;
            label6.Text = "Дата рождения";
            // 
            // update_reader
            // 
            update_reader.Location = new Point(6, 168);
            update_reader.Name = "update_reader";
            update_reader.Size = new Size(169, 23);
            update_reader.TabIndex = 18;
            update_reader.Text = "Редактировать читателя";
            update_reader.UseVisualStyleBackColor = true;
            // 
            // delete_reader
            // 
            delete_reader.Location = new Point(6, 202);
            delete_reader.Name = "delete_reader";
            delete_reader.Size = new Size(169, 23);
            delete_reader.TabIndex = 19;
            delete_reader.Text = "Удалить читателя";
            delete_reader.UseVisualStyleBackColor = true;
            // 
            // Librarian
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 465);
            Controls.Add(groupbox2);
            Controls.Add(groupBox1);
            Name = "Librarian";
            Text = "Librarian";
            Load += Librarian_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupbox2.ResumeLayout(false);
            groupbox2.PerformLayout();
            ResumeLayout(false);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private GroupBox groupBox1;
        private GroupBox groupbox2;
        private Button delete_reader;
        private Button update_reader;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}