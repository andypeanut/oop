namespace Ex08_01_ButtonApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Flat.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Popup.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Standard.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.System.ToString();
        }
    }
}