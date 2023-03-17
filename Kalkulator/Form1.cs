namespace Kalkulator
{
    public partial class Form1 : Form
    {
        double x = 0;
        double y = 0;
        double wynik = 0;
        int zmienna = 0;
        bool pomoc_wynik = false;
        bool pomoc_zmienna = false;
        bool limit = false;

        public Form1()
        {
            InitializeComponent();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text += button13.Text;
            blokada_ilosc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Contains(button1.Text))
            {

            }
            else
            {
                textBox2.Text += button1.Text;
            }
            blokada_ilosc();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Text = "0";
            }
            if (textBox2.Text.Length == 2 && textBox2.Text[0] == '0')
            {
                textBox2.Text = textBox2.Text.Substring(1);
            }


        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text += button14.Text;
            blokada_ilosc();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Text += button15.Text;
            blokada_ilosc();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text += button9.Text;
            blokada_ilosc();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text += button10.Text;
            blokada_ilosc();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text += button11.Text;
            blokada_ilosc();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text += button5.Text;
            blokada_ilosc();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text += button6.Text;
            blokada_ilosc();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text += button7.Text;
            blokada_ilosc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text += button2.Text;
            blokada_ilosc();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pomoc_wynik == false)
            {
                y = Double.Parse(textBox2.Text);
                pomoc_wynik = true;
            }

            if (zmienna == 1)
            {
                x = x + y;
                textBox2.Text = x.ToString();
            }
            if (zmienna == 2)
            {
                x = x - y;
                textBox2.Text = x.ToString();
            }
            if (zmienna == 3)
            {
                x = x * y;
                textBox2.Text = x.ToString();
            }
            if (zmienna == 4)
            {
                x = x / y;
                textBox2.Text = x.ToString();
            }
            blokada();
            pomoc_zmienna = false;


        }

        private void button17_Click(object sender, EventArgs e)
        {
            double z = -1 * Double.Parse(textBox2.Text);
            textBox2.Text = z.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            y = 0;
            x = 0;
            pomoc_wynik = false;
            pomoc_zmienna = false;
            blokada();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
            }
            blokada_ilosc();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            zmienna = 1;
            if (pomoc_zmienna == false)
            {
                x = Double.Parse(textBox2.Text);
                pomoc_zmienna = true;
            }

            textBox2.Clear();
            pomoc_wynik = false;
            blokada();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            zmienna = 2;
            if (pomoc_zmienna == false)
            {
                x = Double.Parse(textBox2.Text);
                pomoc_zmienna = true;
            }
            textBox2.Clear();
            pomoc_wynik = false;
            blokada();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            zmienna = 3;
            if (pomoc_zmienna == false)
            {
                x = Double.Parse(textBox2.Text);
                pomoc_zmienna = true;
            }
            textBox2.Clear();
            pomoc_wynik = false;
            blokada();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zmienna = 4;
            if (pomoc_zmienna == false)
            {
                x = Double.Parse(textBox2.Text);
                pomoc_zmienna = true;
            }
            textBox2.Clear();
            pomoc_wynik = false;
            blokada();
        }
        private void blokada()
        {
            button5.Enabled = !pomoc_wynik;
            button2.Enabled = !pomoc_wynik;
            button1.Enabled = !pomoc_wynik;
            button6.Enabled = !pomoc_wynik;
            button7.Enabled = !pomoc_wynik;
            button9.Enabled = !pomoc_wynik;
            button10.Enabled = !pomoc_wynik;
            button11.Enabled = !pomoc_wynik;
            button13.Enabled = !pomoc_wynik;
            button14.Enabled = !pomoc_wynik;
            button15.Enabled = !pomoc_wynik;
            button20.Enabled = !pomoc_wynik;
        }
        private void blokada_ilosc()
        {
            if(textBox2.Text.Length >= textBox2.MaxLength)
            {
                button5.Enabled = false;
                button2.Enabled = false;
                button1.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;   
            }
            else
            {
                button5.Enabled = true;
                button2.Enabled = true;
                button1.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            pomoc_wynik = false;
            blokada();
        }
    }
}