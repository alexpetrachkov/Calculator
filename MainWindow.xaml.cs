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
using MaterialDesignThemes;
using MaterialDesignColors;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        decimal value1 = 0;
        decimal value2 = 0;
        string operation = "";
        public MainWindow()
        {
            InitializeComponent();
            
            
        }
        private void OperationActions()
        {
            value1 = decimal.Parse(txtMain.Text);
            txtInfo.Text = txtMain.Text + operation;
            txtMain.Text = "0";
        }
        private void FiguriesActions(int x)
        {
            if (operation == "")
            {
                value1 = (value1 * 10) + x;
                txtMain.Text = value1.ToString();
            }
            else
            {
                txtMain.Text = "0";
                value2 = (value2 * 10) + x;
                txtMain.Text = value2.ToString();
            }
        }
        private void btn0_Click(object sender, RoutedEventArgs e)
        {

            FiguriesActions(0);
        }

        private void ButtonPowerOn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            FiguriesActions(1);

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            FiguriesActions(2);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            FiguriesActions(3);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            FiguriesActions(4);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            FiguriesActions(5);
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            FiguriesActions(6);
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            FiguriesActions(7);
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            FiguriesActions(8);
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            FiguriesActions(9);
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            OperationActions();
        }

        private void btnMulti_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            OperationActions();
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            OperationActions();
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            OperationActions();
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            
            switch (operation)
            {
                case "+":
                    {
                        txtInfo.Text += txtMain.Text;
                        txtMain.Text = (value1 + value2).ToString();
                    }
                    break;
                case "-":
                    {
                        txtInfo.Text += txtMain.Text;
                        txtMain.Text = (value1 - value2).ToString();
                    }
                    break;
                case "*":
                    {
                        txtInfo.Text += txtMain.Text;
                        txtMain.Text = (value1 * value2).ToString();
                    }
                    break;
                case "/":
                    {
                        txtInfo.Text += txtMain.Text;
                        if (value2 != 0)
                            txtMain.Text = (value1 / value2).ToString();
                        else
                            txtMain.Text = "0";
                    }
                    break;
                    
            }
            txtInfo.Text +="="+ txtMain.Text;
            operation = "";
            value2 = 0;

        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txtMain.Text = "0";
            txtInfo.Text = "0";
            value2 = 0;
            value1 = 0;
            operation = "";
        }

        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                value1 *= -1;
                txtMain.Text = value1.ToString();
            }
            else
            {
                
                value2 *= -1;
                txtMain.Text = value2.ToString();
            }
        }

        private void btnPersent_Click(object sender, RoutedEventArgs e)
        {
            
                value2 = value2 * value1 / 100;
            txtInfo.Text += value2.ToString();


        }
    }
}
