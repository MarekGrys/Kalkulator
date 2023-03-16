namespace Kalkulator
{
    public partial class Form1 : Form
    {
        string y = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text += button13.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text += button1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text += button14.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Text += button15.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text += button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text += button11.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text += button7.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            y = textBox2.Text;
            textBox2.Clear();
            MessageBox.Show(y);
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            y = "";
        }
    }
}