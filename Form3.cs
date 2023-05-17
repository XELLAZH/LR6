using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{ 
    public partial class Form3 : Form
    {
        public Form3() => InitializeComponent();


        private void button1_Click(object sender, EventArgs e)
        {
            if (IsNumber(firstElementOfProgressionTextBox.Text) && IsNumber(denominatorTextBox.Text) && IsNumber(numberOfElementTextBox.Text))
            {
                if (firstElementOfProgressionTextBox.Text != "" && 
                    denominatorTextBox.Text != "" &&
                    numberOfElementTextBox.Text != "")
                {
                    double firstElement = double.Parse(firstElementOfProgressionTextBox.Text);
                    double denominator = double.Parse(denominatorTextBox.Text);
                    int numberOfElement = int.Parse(numberOfElementTextBox.Text);

                    textBox1.Text = GetElementOfProggression(firstElement, denominator, numberOfElement).ToString();
                }
            }
            else MessageBox.Show("Неверный ввод данных! Введите числа.");
        }

        private double GetElementOfProggression(double firstElement, double denominator, int elementNumber)
        {
            if (elementNumber == 1)
            {
                return firstElement;
            }
            else return GetElementOfProggression(firstElement, denominator, elementNumber - 1) * denominator;
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
