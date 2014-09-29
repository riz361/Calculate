using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddSubtract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double firstNumber = 0.0;
        private double secondNumber = 0.0;

        void calculate()
        {
             firstNumber = Convert.ToDouble(firstNumberText.Text);
             secondNumber = Convert.ToDouble(secondNumberText.Text);
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            
            calculate();
            resultLabel.Text = Convert.ToString(firstNumber + secondNumber);
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            calculate();
            resultLabel.Text = Convert.ToString(firstNumber - secondNumber);
        }

        private void multiplybutton_Click(object sender, EventArgs e)
        {
            calculate();
            resultLabel.Text = Convert.ToString(firstNumber * secondNumber);
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            calculate();
            resultLabel.Text = Convert.ToString(firstNumber / secondNumber);
        }
    }
}
