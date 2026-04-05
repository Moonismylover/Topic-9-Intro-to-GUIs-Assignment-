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
        double result = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Click(object sender, EventArgs e)
        {

        }
        private void btnquit_Click(object sender, EventArgs e)
        {
            if (!btnplus.Enabled && btnminus.Enabled && btnmultiply.Enabled && btndivide.Enabled)
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
            lbltext.Text = " ";

            btnplus.Enabled = true;
            btnminus.Enabled = true;
            btnmultiply.Enabled = true;
            btndivide.Enabled = true;

            firstNumber = 0;
            secondNumber = 0;
            result = 0;
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            lbltext.Text = "0";

            if (firstNumber == 0)
            {
                firstNumber = 0;
            }
            else
            {
                secondNumber = 0;
            }
        }

        private void btnone_Click(object sender, EventArgs e)
        {
            lbltext.Text = "1";

            if (firstNumber == 0)
            {
                firstNumber = 1;
            }
            else
            {
                secondNumber = 1;
            }
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            lbltext.Text = "2";

            if (firstNumber == 0)
            {
                firstNumber = 2;
            }
            else
            {
                secondNumber = 2;
            }
        }

        private void btnthree_Click(object sender, EventArgs e)
        {
            lbltext.Text = "3";

            if (firstNumber == 0)
            {
                firstNumber = 3;
            }
            else
            {
                secondNumber = 3;
            }
        }

        private void btnfour_Click(object sender, EventArgs e)
        {
            lbltext.Text = "4";

            


        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            lbltext.Text = "5";
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            lbltext.Text = "6";
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            lbltext.Text = "7";
        }

        private void btneight_Click(object sender, EventArgs e)
        {
            lbltext.Text = "8";
        }
        private void btnnine_Click(object sender, EventArgs e)
        {
            lbltext.Text = "9";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            lbltext.Text = "+";
            btnplus.Enabled = false;
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            lbltext.Text = "-";
            btnminus.Enabled = false;
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            lbltext.Text = "x";
            btnmultiply.Enabled = false;
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            lbltext.Text = "/";
            btndivide.Enabled = false;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            lbltext.Text = "=";
        }

        private void lbltext_Click(object sender, EventArgs e)
        {
            lbltext.Text = "Please enter your expression!";
        }


        /**
Program 2 Calculations
Create a calculation application that displays the result of a calculation after clicking
a Button that displays a mathematical operation. You need to display both the expression AND the
answer in a Label. The answer must be a result of a calculation, NOT a hard coded answer.
 Math in a Windows Forms application is the same as a Console application:
e.g. lblAnswer1.Text = "8 * 8 = " + (8 * 8);
 When a Button is clicked, only the answer for that particular Button should be displayed next to
it.
 Once a Button has been clicked, disable it.
 Challenges:
o Instead of using the ‘Click’ event, try to use a different events for each
Button/calculation.
o Add a quit button. It should only work if the user has clicked every calculation.
        **/


    }
}
