using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            Delete.Text = "\u27F5";
            Sign.Text = "\u00B1";
            Sqrt.Text = "\u221A";
            Power.Text = "\u2093" + "\u02B8";
            textBox1.Select();
            
            textBox1.KeyDown += new KeyEventHandler(KeyDown);
        }

        double x = 0, y = 0, z = 0;
        bool Option = true;
        int choice = -1;

        private void KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0) Number_Click(Number_0, new EventArgs());
            else if (e.KeyCode == Keys.NumPad1) Number_Click(Number_1, new EventArgs());
            else if (e.KeyCode == Keys.NumPad2) Number_Click(Number_2, new EventArgs());
            else if (e.KeyCode == Keys.NumPad3) Number_Click(Number_3, new EventArgs());
            else if (e.KeyCode == Keys.NumPad4) Number_Click(Number_4, new EventArgs());
            else if (e.KeyCode == Keys.NumPad5) Number_Click(Number_5, new EventArgs());
            else if (e.KeyCode == Keys.NumPad6) Number_Click(Number_6, new EventArgs());
            else if (e.KeyCode == Keys.NumPad7) Number_Click(Number_7, new EventArgs());
            else if (e.KeyCode == Keys.NumPad8) Number_Click(Number_8, new EventArgs());
            else if (e.KeyCode == Keys.NumPad9) Number_Click(Number_9, new EventArgs());
            else if (e.KeyCode == Keys.Back) Delete_Click(Clear, new EventArgs());
            else if (e.KeyCode == Keys.Divide) Division_Click(Division, new EventArgs());
            else if (e.KeyCode == Keys.Multiply) Multiply_Click(Multiply, new EventArgs());
            else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus) Minus_Click(Minus, new EventArgs());
            else if (e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Add) Sum_Click(Sum, new EventArgs());
            else if (e.KeyCode == Keys.Decimal) Point_Click(Point, new EventArgs());
            else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Enter) Equally_Click(Equally, new EventArgs());
            //MessageBox.Show(e.KeyCode.ToString());

        }

        private void Sum_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            else
            {
                if (choice > 0) Equally_Click(sender, e);
                x = Convert.ToDouble(textBox1.Text);
                Option = true;
                choice = 1;
            }
        }

        static int Factorial(int i)
        {
            int result;

            if (i == 1 || i == 0)
                return 1;
            result = Factorial(i - 1) * i;
            return result;
        }

        private void More_Click(object sender, EventArgs e)
        {
            if (this.Width == 320) More.Text = "<";
            else More.Text = ">";
            Timer.Enabled = true;
            textBox1.Focus();
            textBox1.Select(0, 0);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.Width < 390 && More.Text == "<")
            {
                this.Width += 10;
                textBox1.Width += 10;
                if (this.Width == 390) Timer.Enabled = false;
            }
            else
            {
                this.Width -= 10;
                textBox1.Width -= 10;
                if (this.Width == 320) Timer.Enabled = false;
            }
        }

        private void Factorial_Click(object sender, EventArgs e)
        {
            textBox1.Text = Factorial(Convert.ToInt32(textBox1.Text)).ToString();
            Option = true;
            choice = -1;
            textBox1.Focus();
            textBox1.Select(0, 0);
        }

        private void Number_Click(object sender, EventArgs e)
        {
            if (Option == true || textBox1.Text == "0")
            {
                textBox1.Text = (sender as Button).Text;
                Option = false;
            }
            else textBox1.Text += (sender as Button).Text;
            textBox1.Focus();
            textBox1.Select(0, 0);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox1.Text == "0") textBox1.Text = "0";
            else
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                if (textBox1.Text == "-" || textBox1.Text == "") textBox1.Text = "0";
            }
            textBox1.Focus();
            textBox1.Select(0, 0);
        }

        private void Sign_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = (-Convert.ToDouble(textBox1.Text)).ToString();
            }
            catch
            {

            }
            textBox1.Focus();
            textBox1.Select(0, 0);
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) < 0.0)
            {
                textBox1.Text = "Недопустимый ввод";
            }
            else
            {
                if (textBox1.Text == "") textBox1.Text = "0";
                textBox1.Text = Math.Sqrt(Convert.ToDouble(textBox1.Text)).ToString();
                Option = true;
                choice = -1;
            }
            textBox1.Focus();
            textBox1.Select(0, 0);
        }

        private void Fraction_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            if (textBox1.Text == "0") textBox1.Text = "Деление на ноль не возможно";
            else
            {
                textBox1.Text = (1.0 / Convert.ToDouble(textBox1.Text)).ToString();
                Option = true;
                choice = -1;
            }
            textBox1.Focus();
            textBox1.Select(0, 0);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            choice = -1;
            textBox1.Text = "0";
            x = 0;
            y = 0;
            z = 0;
            Option = true;
            textBox1.Focus();
            textBox1.Select(0, 0);
        }

        private void Point_Click(object sender, EventArgs e)
        {
            if (Option)
            {
                textBox1.Text = "0";
                Option = false;
            }
            if (textBox1.Text.IndexOf(",") == -1) textBox1.Text += ",";
        }

        private void Equally_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBox1.Text);

            bool error = false;

            switch (choice)
            {
                case 1:
                    z = x + y;
                    break;
                case 2:
                    z = x - y;
                    break;
                case 3:
                    z = x * y;
                    break;
                case 4:
                    if (y == 0.0)
                    {
                        textBox1.Text = "Деление на ноль не возможно";
                        error = true;
                        MessageBox.Show("Деление на ноль не возможно");
                    }
                    else z = x / y;
                    break;
                case 5:
                    z = Math.Pow(x, y);
                    break;
                case 6:
                    if (y == 0.0)
                    {
                        textBox1.Text = "Результат не определен";
                        error = true;
                        MessageBox.Show("Результат не определен");
                    }
                    else z = x % y;
                    break;
            }
            if (error == false)
            {
                textBox1.Text = z.ToString();
            }
            else
            {
                x = y = z = 0;
            }
            Option = true;
            choice = -1;
            textBox1.Focus();
            textBox1.Select(0, 0);
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text.IndexOf("-") > -1 && textBox1.Text.Length - 1 == textBox1.Text.IndexOf("-")))
            {
                if (textBox1.Text == "" || textBox1.Text == "0")
                {
                    textBox1.Text = "-";
                    Option = false;
                    choice = -1;
                }
                else
                {
                    if (choice > 0) Equally_Click(sender, e);
                    x = Convert.ToDouble(textBox1.Text);
                    Option = true;
                    choice = 2;
                }
            }
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            else
            {
                if (choice > 0) Equally_Click(sender, e);
                x = Convert.ToDouble(textBox1.Text);
                Option = true;
                choice = 3;
            }
        }

        private void Division_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            else
            {
                if (choice > 0) Equally_Click(sender, e);
                x = Convert.ToDouble(textBox1.Text);
                Option = true;
                choice = 4;
            }
            textBox1.Focus();
            textBox1.Select(0, 0);
        }

        private void Power_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            else
            {
                if (choice > 0) Equally_Click(sender, e);
                x = Convert.ToDouble(textBox1.Text);
                Option = true;
                choice = 5;
            }
            textBox1.Focus();
            textBox1.Select(0, 0);
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            textBox1.Text = Math.Sin(Convert.ToDouble(textBox1.Text)).ToString();
            Option = true;
            choice = -1;
            textBox1.Focus();
            textBox1.Select(0, 0);
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            textBox1.Text = Math.Cos(Convert.ToDouble(textBox1.Text)).ToString();
            Option = true;
            choice = -1;
            textBox1.Focus();
            textBox1.Select(0, 0);
        }

        private void Tan_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            textBox1.Text = Math.Tan(Convert.ToDouble(textBox1.Text)).ToString();
            Option = true;
            choice = -1;
            textBox1.Focus();
            textBox1.Select(0, 0);
        }

        private void Remainder_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            else
            {
                if (choice > 0) Equally_Click(sender, e);
                x = Convert.ToDouble(textBox1.Text);
                Option = true;
                choice = 6;
            }
            textBox1.Focus();
            textBox1.Select(0, 0);
        }

        private void CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox1.Focus();
            textBox1.Select(0, 0);
        }

    }
}
