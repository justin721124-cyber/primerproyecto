namespace MdiContainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frn = new Form2();
            frn.MdiParent = this;
            frn.Show();
        }
    }
}
