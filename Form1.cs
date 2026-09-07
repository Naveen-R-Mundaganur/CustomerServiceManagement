namespace CustomerManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Welcome to Customer Management System!\n{textBox1.Text}");

        }
    }
}
