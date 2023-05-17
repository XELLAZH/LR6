using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2() => InitializeComponent();

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (IsNumber(firstNumberTextBox.Text) && IsNumber(secondNumberTextBox.Text))
            {
                double firstNumber = double.Parse(firstNumberTextBox.Text);
                double secondNumber = double.Parse(secondNumberTextBox.Text);

                resultTextBox.Text = GetGCF(firstNumber, secondNumber).ToString();
            }
            else MessageBox.Show("Некорректный ввод данных! Требуется ввести числа.");
        }

        private double GetGCF(double firstNum, double secondNum)
        {
            if (secondNum == 0)
            {
                return firstNum;
            }
            else return GetGCF(secondNum, firstNum % secondNum);
        }

        private bool IsNumber(string text)
        {
            char[] chars = text.ToCharArray();

            foreach (char c in chars)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

    }
}
