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

namespace Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public double FirstNumber { get; set; }
       public Operations CurrentOperation { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            
        }

        #region Number buttons

        public void Button_Click7(object sender, RoutedEventArgs e)
        {
            TbResult.Text += "7";
            TbOper.Text += "7";
        }

        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            TbResult.Text += "8";
            TbOper.Text += "8";
        }

        public void Button_Click9(object sender, RoutedEventArgs e)
        {
            TbResult.Text += "9";
            TbOper.Text += "9";
        }

        public void Button_Click4(object sender, RoutedEventArgs e)
        {
            TbResult.Text += "4";
            TbOper.Text += "4";
        }

        public void Button_Click5(object sender, RoutedEventArgs e)
        {
            TbResult.Text += "5";
            TbOper.Text += "5";
        }

        public void Button_Click6(object sender, RoutedEventArgs e)
        {
            TbResult.Text += "6";
            TbOper.Text += "6";
        }

        public void Button_Click1(object sender, RoutedEventArgs e)
        {
            TbResult.Text += "1";
            TbOper.Text += "1";
        }

        public void Button_Click2(object sender, RoutedEventArgs e)
        {
            TbResult.Text += "2";
            TbOper.Text += "2";
        }

        public void Button_Click3(object sender, RoutedEventArgs e)
        {
            TbResult.Text += "3";
            TbOper.Text += "3";
        }

        public void Button_Click0(object sender, RoutedEventArgs e)
        {
            TbResult.Text += "0";
            TbOper.Text += "0";
        }

        public void Button_Click_Punt(object sender, RoutedEventArgs e)
        {
            TbResult.Text += ",";
            TbOper.Text += ",";
        }

        #endregion Number buttons

        #region Operation buttons

        private void Button_Click_Suma(object sender, RoutedEventArgs e)
        {
            Suma();
            TbOper.Text += " + ";
        }
        private void Button_Click_Resta(object sender, RoutedEventArgs e)
        {
            Resta();
            TbOper.Text += " - ";
        }
        private void Button_Click_Mult(object sender, RoutedEventArgs e)
        {
            Mult();
            TbOper.Text += " x ";
        }
        private void Button_Click_Div(object sender, RoutedEventArgs e)
        {
            Div();
            TbOper.Text += " / ";
        }

        private void Button_Click_Igual(object sender, RoutedEventArgs e)
        {
            TbOper.Text += " = ";
            if (TryReadCurrentNumber(out double secondNumber))
            {
                switch (CurrentOperation)
                {
                    case Operations.Suma:
                        TbResult.Text = Math.Round(FirstNumber + secondNumber, 2).ToString();
                        break;
                    case Operations.Resta:
                        TbResult.Text = Math.Round(FirstNumber - secondNumber, 2).ToString();
                        break;
                    case Operations.Mult:
                        TbResult.Text = Math.Round(FirstNumber * secondNumber, 2).ToString();
                        break;
                    case Operations.Div:
                        TbResult.Text = Math.Round(FirstNumber / secondNumber, 2).ToString();
                        break;
                }
            }
        }

        #endregion Operation buttons

        public void Button_Click_Borrar(object sender, RoutedEventArgs e)
        {
            TbResult.Text = string.Empty;
            TbOper.Text = string.Empty;
        }

        #region Operations

        public void Suma()
        {
            if (TryReadCurrentNumber(out double firstNumber))
            {
                FirstNumber = firstNumber;
                CurrentOperation = Operations.Suma;
            }
        }
        public void Resta()
        {
            if (TryReadCurrentNumber(out double firstNumber))
            {
                FirstNumber = firstNumber;
                CurrentOperation = Operations.Resta;
            }
        }
        public void Mult()
        {
            if (TryReadCurrentNumber(out double firstNumber))
            {
                FirstNumber = firstNumber;
                CurrentOperation = Operations.Mult;
            }
        }
        public void Div()
        {
            if (TryReadCurrentNumber(out double firstNumber))
            {
                FirstNumber = firstNumber;
                CurrentOperation = Operations.Div;
            }
        }
       
        #endregion Operations

        private bool TryReadCurrentNumber(out double input)
        {
            if (double.TryParse(TbResult.Text, out double num))
            {
                TbResult.Text = string.Empty;
                input = num;
                return true;
            }
            else
            {
                MessageBox.Show("El format del número és incorrecte");
                input = 0;
                return false;
            }
        }        
    }
    public enum Operations
    {
        Suma = 0,
        Resta = 1,
        Mult = 2,
        Div = 3
    }
}
