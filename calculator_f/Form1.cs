using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_f
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operationPressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textDisplay.Text == "0") || (operationPressed))
            {
                textDisplay.Clear();
                operationPressed = false;
            }
            Button b = (Button)sender;
            textDisplay.Text += b.Text;
        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(textDisplay.Text);
            operationPressed = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textDisplay.Text = (value + Double.Parse(textDisplay.Text)).ToString();
                    break;
                case "-":
                    textDisplay.Text = (value - Double.Parse(textDisplay.Text)).ToString();
                    break;
                case "*":
                    textDisplay.Text = (value * Double.Parse(textDisplay.Text)).ToString();
                    break;
                case "/":
                    textDisplay.Text = (value / Double.Parse(textDisplay.Text)).ToString();
                    break;
                default:
                    break;
            }
            operationPressed = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textDisplay.Clear();
            value = 0;
        }
    }
}
