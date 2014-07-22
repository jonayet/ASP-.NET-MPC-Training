using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }

        Calculator calc = new Calculator();
        private string result;
        private void addButton_Click(object sender, EventArgs e)
        {
           
            result = calc.Add(firstNumberTextBox.Text, secondNumberTextBox.Text);
            resultTextBox.Text = result;
        }

        private void subButton_Click(object sender, EventArgs e)
        {
           
            result = calc.sub(firstNumberTextBox.Text, secondNumberTextBox.Text);
            resultTextBox.Text = result;
        }

        private void multiButton_Click(object sender, EventArgs e)
        {
          
            result = calc.multi(firstNumberTextBox.Text, secondNumberTextBox.Text);
            resultTextBox.Text = result;
        }

        private void divButton_Click(object sender, EventArgs e)
        {
          
            result = calc.div(firstNumberTextBox.Text, secondNumberTextBox.Text);
            resultTextBox.Text = result;
        }
    }
}
