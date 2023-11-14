namespace Library
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
            Reader = new Button();
            Librarian = new Button();
            SuspendLayout();
            // 
            // Reader
            // 
            Reader.Location = new Point(318, 165);
            Reader.Name = "Reader";
            Reader.Size = new Size(99, 23);
            Reader.TabIndex = 0;
            Reader.Text = "Читатель";
            Reader.UseVisualStyleBackColor = true;
            Reader.Click += Reader_Click;
            // 
            // Librarian
            // 
            Librarian.Location = new Point(318, 249);
            Librarian.Name = "Librarian";
            Librarian.Size = new Size(99, 23);
            Librarian.TabIndex = 1;
            Librarian.Text = "Библиотекарь";
            Librarian.UseVisualStyleBackColor = true;
            Librarian.Click += Librarian_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Librarian);
            Controls.Add(Reader);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Reader;
        private Button Librarian;
    }
}