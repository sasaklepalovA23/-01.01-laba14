using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace laba14
{
    public partial class CalculatorWindow : Window
    {
        public CalculatorWindow() { InitializeComponent(); }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
         
            if (!double.TryParse(txtNumA.Text, out double a))
            {
                MessageBox.Show("Введите корректное первое число!", "Ошибка ввода");
                return;
            }

            if (!double.TryParse(txtNumB.Text, out double b))
            {
                MessageBox.Show("Введите корректное второе число!", "Ошибка ввода");
                return;
            }

            double result = 0;
           
            int operationIndex = cbOperation.SelectedIndex;

            try
            {
                switch (operationIndex)
                {
                    case 0: result = a + b; break;
                    case 1: result = a - b; break;
                    case 2: result = a * b; break;
                    case 3:
                        if (b == 0) throw new DivideByZeroException("Деление на 0!");
                        result = a / b;
                        break;
                    case 4: result = Math.Pow(a, b); break;
                    case 5: result = a % b; break;
                    default: return;
                }

                lblResult.Text = $"Результат: {result:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Математическая ошибка");
                lblResult.Text = "Ошибка";
            }
        }
    }
}

