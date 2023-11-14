namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Reader_Click(object sender, EventArgs e)
        {
            Reader r = new Reader();
            r.Show();
            Hide();
        }

        private void Librarian_Click(object sender, EventArgs e)
        {
            Librarian l = new Librarian();
            l.Show();
            Hide();
        }
    }
}