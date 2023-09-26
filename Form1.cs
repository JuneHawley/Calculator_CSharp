/*
 * Calculator
 * 9/25/23
 * Hawley
 * DDA
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Hawley
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double number1, number2, result;

            number1 = Convert.ToDouble(number1TextBox.Text);
            number2 = Convert.ToDouble(number2TextBox.Text);
            result = number1 + number2;

            resultsListBox.Items.Add (number1 + " + " + number2 +
                " = " + result);
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            double number1, number2, result;

            number1 = Convert.ToDouble(number1TextBox.Text);
            number2 = Convert.ToDouble(number2TextBox.Text);
            result = number1 - number2;

            resultsListBox.Items.Add(number1 + " - " + number2 +
                " = " + result);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            double number1, number2, result;

            number1 = Convert.ToDouble(number1TextBox.Text);
            number2 = Convert.ToDouble(number2TextBox.Text);
            result = number1 * number2;

            resultsListBox.Items.Add(number1 + " * " + number2 +
                " = " + result);
        }

        private void devideButton_Click(object sender, EventArgs e)
        {
            double number1, number2, result;

            number1 = Convert.ToDouble(number1TextBox.Text);
            number2 = Convert.ToDouble(number2TextBox.Text);
            result = number1 / number2;

            resultsListBox.Items.Add(number1 + " / " + number2 +
                " = " + result);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            number1TextBox.Clear();
            number2TextBox.Clear();
            resultsListBox.Items.Clear();
        }
    }
}
