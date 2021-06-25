using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Delete.Content = "\u27F5";
            Plus_minus.Content = "\u00B1";
            Sqrt.Content = "\u221A";
            Box.Focus();
            Box.Select(0, 0);
            Box.KeyDown += new KeyEventHandler(KeyDown);
            Box.KeyUp += new KeyEventHandler(KeyUp);

        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.NumPad0) Number_Click(Number0, new EventArgs());
            else if (e.Key == Key.NumPad1) Number_Click(Number1, new EventArgs());
            else if (e.Key == Key.NumPad2) Number_Click(Number2, new EventArgs());
            else if (e.Key == Key.NumPad3) Number_Click(Number3, new EventArgs());
            else if (e.Key == Key.NumPad4) Number_Click(Number4, new EventArgs());
            else if (e.Key == Key.NumPad5) Number_Click(Number5, new EventArgs());
            else if (e.Key == Key.NumPad6) Number_Click(Number6, new EventArgs());
            else if (e.Key == Key.NumPad7) Number_Click(Number7, new EventArgs());
            else if (e.Key == Key.NumPad8) Number_Click(Number8, new EventArgs());
            else if (e.Key == Key.NumPad9) Number_Click(Number9, new EventArgs());
            else if (e.Key == Key.Back) Delete_Click(Delete, new EventArgs());
            else if (e.Key == Key.Decimal) Point_Click(Point, new EventArgs());
            else if (e.Key == Key.Enter) Equally_Click(Equally, new EventArgs());
            else if (e.Key == Key.Divide) Division_Click(Division, new EventArgs());
            else if (e.Key == Key.Multiply) Multiply_Click(Multiplication, new EventArgs());
            else if (e.Key == Key.Subtract || e.Key == Key.OemMinus) Minus_Click(Minus, new EventArgs());
            else if (e.Key == Key.OemPlus || e.Key == Key.Add) Sum_Click(Plus, new EventArgs());
            //MessageBox.Show(e.Key.ToString());
        }

        private void KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back) Delete_Click(Delete, new EventArgs());
        }

        

        double x = 0, y = 0, z = 0;
        bool Option = true;
        int choice = -1;

        private void Number_Click(object sender, EventArgs e)
        {
            if (Option == true || Box.Text == "0")
            {
                Box.Text = (sender as Button).Content.ToString();
                Option = false;
            }
            else Box.Text += (sender as Button).Content.ToString();
            Box.Focus();
            Box.Select(0, 0);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (Box.Text.Length == 0 || Box.Text == "0") Box.Text = "0";
            else
            {
                Box.Text = Box.Text.Remove(Box.Text.Length - 1);
                if (Box.Text == "-" || Box.Text == "") Box.Text = "0";
            }
            Box.Focus();
            Box.Select(0, 0);
        }

        static int Factorial(int i)
        {
            int result;

            if (i == 1 || i == 0)
                return 1;
            result = Factorial(i - 1) * i;
            return result;
        }

        private void Sign_Click(object sender, EventArgs e)
        {
            try
            {
                Box.Text = (-Convert.ToDouble(Box.Text)).ToString();
            }
            catch
            {

            }
            Box.Focus();
            Box.Select(0, 0);
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(Box.Text) < 0.0)
            {
                Box.Text = "Недопустимый ввод";
            }
            else
            {
                if (Box.Text == "") Box.Text = "0";
                Box.Text = Math.Sqrt(Convert.ToDouble(Box.Text)).ToString();
                Option = true;
                choice = -1;
            }
            Box.Focus();
            Box.Select(0, 0);
        }

        private void Fraction_Click(object sender, EventArgs e)
        {
            if (Box.Text == "") Box.Text = "0";
            if (Box.Text == "0") Box.Text = "Деление на ноль не возможно";
            else
            {
                Box.Text = (1.0 / Convert.ToDouble(Box.Text)).ToString();
                Option = true;
                choice = -1;
            }
            Box.Focus();
            Box.Select(0, 0);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            choice = -1;
            Box.Text = "0";
            x = 0;
            y = 0;
            z = 0;
            Option = true;
            Box.Focus();
            Box.Select(0, 0);
        }

        private void Point_Click(object sender, EventArgs e)
        {
            if (Option)
            {
                Box.Text = "0";
                Option = false;
            }
            if (Box.Text.IndexOf(",") == -1) Box.Text += ",";
            Box.Focus();
            Box.Select(0, 0);
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            if (Box.Text == "") Box.Text = "0";
            else
            {
                if (choice > 0) Equally_Click(sender, e);
                x = Convert.ToDouble(Box.Text);
                Option = true;
                choice = 1;
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (!(Box.Text.IndexOf("-") > -1 && Box.Text.Length - 1 == Box.Text.IndexOf("-")))
            {
                if (Box.Text == "" || Box.Text == "0")
                {
                    Box.Text = "-";
                    Option = false;
                    choice = -1;
                }
                else
                {
                    if (choice > 0) Equally_Click(sender, e);
                    x = Convert.ToDouble(Box.Text);
                    Option = true;
                    choice = 2;
                }
            }
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (Box.Text == "") Box.Text = "0";
            else
            {
                if (choice > 0) Equally_Click(sender, e);
                x = Convert.ToDouble(Box.Text);
                Option = true;
                choice = 3;
            }
        }

        private void Division_Click(object sender, EventArgs e)
        {
            if (Box.Text == "") Box.Text = "0";
            else
            {
                if (choice > 0) Equally_Click(sender, e);
                x = Convert.ToDouble(Box.Text);
                Option = true;
                choice = 4;
            }
            Box.Focus();
            Box.Select(0, 0);
        }

        private void Remainder_Click(object sender, EventArgs e)
        {
            if (Box.Text == "") Box.Text = "0";
            else
            {
                if (choice > 0) Equally_Click(sender, e);
                x = Convert.ToDouble(Box.Text);
                Option = true;
                choice = 6;
            }
            Box.Focus();
            Box.Select(0, 0);
        }

        private void CE_Click(object sender, EventArgs e)
        {
            Box.Text = "0";
            Box.Focus();
            Box.Select(0, 0);
        }

        private void Equally_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(Box.Text);

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
                        Box.Text = "Деление на ноль не возможно";
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
                        Box.Text = "Результат не определен";
                        error = true;
                        MessageBox.Show("Результат не определен");
                    }
                    else z = x % y;
                    break;
            }
            if (error == false)
            {
                Box.Text = z.ToString();
            }
            else
            {
                x = y = z = 0;
            }
            Option = true;
            choice = -1;
            Box.Focus();
            Box.Select(0, 0);
        }
    }
}
