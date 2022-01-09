using System;
using System.Windows.Forms;

namespace CalculatorNew
{
    public partial class Form1 : Form
    {
        private int d;

        private float a, b;

        private double c;

        private Action action;

        private bool znak = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int j = textBox1.TextLength;
            if (j < 5 & !(textBox1.Text.IndexOf(',') > -1))
            {
                textBox1.Text += 0;
            }
            if (textBox1.Text.IndexOf(',') > -1)
            {
                textBox1.Text += 0;
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            int j = textBox1.TextLength;
            if (j < 5 & !(textBox1.Text.IndexOf(',') > -1))
            {
                textBox1.Text += 1;
            }
            if (textBox1.Text.IndexOf(',') > -1)
            {
                textBox1.Text += 1;
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            int j = textBox1.TextLength;
            if (j < 5 & !(textBox1.Text.IndexOf(',') > -1))
            {
                textBox1.Text += 2;
            }
            if (textBox1.Text.IndexOf(',') > -1)
            {
                textBox1.Text += 2;
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            int j = textBox1.TextLength;
            if (j < 5 & !(textBox1.Text.IndexOf(',') > -1))
            {
                textBox1.Text += 3;
            }
            if (textBox1.Text.IndexOf(',') > -1)
            {
                textBox1.Text += 3;
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            int j = textBox1.TextLength;
            if (j < 5 & !(textBox1.Text.IndexOf(',') > -1))
            {
                textBox1.Text += 4;
            }
            if (textBox1.Text.IndexOf(',') > -1)
            {
                textBox1.Text += 4;
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            int j = textBox1.TextLength;
            if (j < 5 & !(textBox1.Text.IndexOf(',') > -1))
            {
                textBox1.Text += 5;
            }
            if (textBox1.Text.IndexOf(',') > -1)
            {
                textBox1.Text += 5;
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            int j = textBox1.TextLength;
            if (j < 5 & !(textBox1.Text.IndexOf(',') > -1))
            {
                textBox1.Text += 6;
            }
            if (textBox1.Text.IndexOf(',') > -1)
            {
                textBox1.Text += 6;
            }
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            int j = textBox1.TextLength;
            if (j < 5 & !(textBox1.Text.IndexOf(',') > -1))
            {
                textBox1.Text += 7;
            }
            if (textBox1.Text.IndexOf(',') > -1)
            {
                textBox1.Text += 7;
            }
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            int j = textBox1.TextLength;
            if (j < 5 & !(textBox1.Text.IndexOf(',') > -1))
            {
                textBox1.Text += 8;
            }
            if (textBox1.Text.IndexOf(',') > -1)
            {
                textBox1.Text += 8;
            }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            int j = textBox1.TextLength;
            if (j < 5 & !(textBox1.Text.IndexOf(',') > -1))
            {
                textBox1.Text += 9;
            }
            if (textBox1.Text.IndexOf(',') > -1)
            {
                textBox1.Text += 9;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(",") == -1)
            {
                textBox1.Text += ",";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            action = Action.Plus;
            label1.Text = a.ToString() + "+";
            znak = true;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            action = Action.Minus;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            action = Action.Multiplication;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            action = Action.Divide;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int a = textBox1.Text.IndexOf(',');
            int b = textBox1.Text.Length;
            if (a > -1 & (b - a) > 3)
            {
                textBox1.Text = textBox1.Text.Remove(a + 3);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            action = Action.Stepen;
            label1.Text = a.ToString() + "**";
            znak = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            c = Math.Sqrt(a);
            label1.Text += a + "√" + "=";
            textBox1.Text = c.ToString();
            znak = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            action = Action.Sravnenie;
            label1.Text = a.ToString() + " и ";
            znak = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            if (a % 2 == 0)
            {
                d = (int)a >> 1;
                label1.Text += a + "/2" + "=";
                textBox1.Text = d.ToString();
            }
            else
            {
                textBox1.Text = "Введите чётное целое число!";
            }
            znak = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            c = a * 2;
            if (c%2==0 & c<int.MaxValue)
            {
                d = (int)a << 1;
                label1.Text += a + "*2" + "=";
                textBox1.Text = d.ToString();
            }
            else
            {
                textBox1.Text = "Необходимо целое число или меньшее 1/2 от int!";
            }
            znak = true;
        }

        private void Calculate()
        {
            switch (this.action)
            {
                case Action.Sravnenie:
                    b = float.Parse(textBox1.Text);
                    if (a > b)
                    {
                        label1.Text += float.Parse(textBox1.Text);
                        textBox1.Text = a + ">" + b;
                    }
                    else if (a == b)
                    {
                        label1.Text += float.Parse(textBox1.Text);
                        textBox1.Text = a + "=" + b;
                    }
                    else if (a < b)
                    {
                        label1.Text += float.Parse(textBox1.Text);
                        textBox1.Text = a + "<" + b;
                    }
                    break;
                case Action.Stepen:
                    b = float.Parse(textBox1.Text);
                    c = Math.Pow(a, b);
                    label1.Text += float.Parse(textBox1.Text) + "=";
                    textBox1.Text = c.ToString();
                    break;
                case Action.Plus:
                    b = a + float.Parse(textBox1.Text);
                    label1.Text += float.Parse(textBox1.Text) + "=";
                    textBox1.Text = b.ToString();
                    break;
                case Action.Minus:
                    b = a - float.Parse(textBox1.Text);
                    label1.Text += float.Parse(textBox1.Text) + "=";
                    textBox1.Text = b.ToString();
                    break;
                case Action.Divide:
                    if (float.Parse(textBox1.Text) == 0)
                    {
                        textBox1.Text = "";
                        label1.Text = "";
                        MessageBox.Show("Деление на ноль запрещено!");
                    }
                    else
                    {
                        b = a / float.Parse(textBox1.Text);
                        label1.Text += float.Parse(textBox1.Text) + "=";
                        textBox1.Text = b.ToString();
                    }
                    break;
                case Action.Multiplication:
                    b = a * float.Parse(textBox1.Text);
                    label1.Text += float.Parse(textBox1.Text) + "=";
                    textBox1.Text = b.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
