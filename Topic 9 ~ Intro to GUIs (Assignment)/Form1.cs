using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_9___Intro_to_GUIs__Assignment_
{
    public partial class MainForm : Form
    {
        double firstNumber = 0;       
        double secondNumber = 0;     
        string currentOperation = "";
        bool enteringSecondNumber = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Click(object sender, EventArgs e)
        {

        }
        private void btnquit_Click(object sender, EventArgs e)
        {
            if (!btnplus.Enabled && !btnminus.Enabled && !btnmultiply.Enabled && !btndivide.Enabled)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Please complete all calculations before quitting!");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            lbltext.Text = "";

            btnplus.Enabled = true;
            btnminus.Enabled = true;
            btnmultiply.Enabled = true;
            btndivide.Enabled = true;

            firstNumber = 0;
            secondNumber = 0;
            currentOperation = "";
            enteringSecondNumber = false;
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            lbltext.Text += "0";

            if (!enteringSecondNumber)
                double.TryParse(lbltext.Text, out firstNumber);
            else
                double.TryParse(lbltext.Text, out secondNumber);
        }

        private void btnone_Click(object sender, EventArgs e)
        {
            lbltext.Text += "1";

            if (!enteringSecondNumber)
                double.TryParse(lbltext.Text, out firstNumber);
            else
                double.TryParse(lbltext.Text, out secondNumber);
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            lbltext.Text += "2";

            if (!enteringSecondNumber)
                double.TryParse(lbltext.Text, out firstNumber);
            else
                double.TryParse(lbltext.Text, out secondNumber);
        }

        private void btnthree_Click(object sender, EventArgs e)
        {
            lbltext.Text += "3";

            if (!enteringSecondNumber)
                double.TryParse(lbltext.Text, out firstNumber);
            else
                double.TryParse(lbltext.Text, out secondNumber);
        }

        private void btnfour_Click(object sender, EventArgs e)
        {
            lbltext.Text += "4";

            if (!enteringSecondNumber)
                double.TryParse(lbltext.Text, out firstNumber);
            else
                double.TryParse(lbltext.Text, out secondNumber);
        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            lbltext.Text += "5";

            if (!enteringSecondNumber)
                double.TryParse(lbltext.Text, out firstNumber);
            else
                double.TryParse(lbltext.Text, out secondNumber);
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            lbltext.Text += "6";

            if (!enteringSecondNumber)
                double.TryParse(lbltext.Text, out firstNumber);
            else
                double.TryParse(lbltext.Text, out secondNumber);
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            lbltext.Text += "7";
            
            if (!enteringSecondNumber)
                double.TryParse(lbltext.Text, out firstNumber);
            else
                double.TryParse(lbltext.Text, out secondNumber);
        }

        private void btneight_Click(object sender, EventArgs e)
        {
            lbltext.Text += "8";

            if (!enteringSecondNumber)
                double.TryParse(lbltext.Text, out firstNumber);
            else
                double.TryParse(lbltext.Text, out secondNumber);
        }
        private void btnnine_Click(object sender, EventArgs e)
        {
            lbltext.Text += "9";

            if (!enteringSecondNumber)
                double.TryParse(lbltext.Text, out firstNumber);
            else
                double.TryParse(lbltext.Text, out secondNumber);
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            currentOperation = "+";
            enteringSecondNumber = true; 
            lbltext.Text = "";
            btnplus.Enabled = false;
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            currentOperation = "-";
            enteringSecondNumber = true;
            lbltext.Text = "";
            btnminus.Enabled = false;
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            currentOperation = "x";
            enteringSecondNumber = true;
            lbltext.Text = "";
            btnmultiply.Enabled = false;
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            currentOperation = "/";
            enteringSecondNumber = true;
            lbltext.Text = "";
            btndivide.Enabled = false;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            double result = 0;
            switch (currentOperation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "x":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Cannot divide by zero!");
                        return;
                    }
                    result = firstNumber / secondNumber;
                    break;
            }

            lbltext.Text = $"{firstNumber} {currentOperation} {secondNumber} = {result}";

            firstNumber = result;
            secondNumber = 0;
            enteringSecondNumber = false;
        }

        private void lbltext_Click(object sender, EventArgs e)
        {

        }

    }
}
