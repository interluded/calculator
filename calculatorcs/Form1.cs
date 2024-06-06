using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace calculatorcs
{
    public partial class Calculator : Form
    {
        bool done = false;
        private System.Windows.Forms.Timer timer;
        string equation = string.Empty;
        public Calculator()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10; // Set the interval to 1 second (1000 milliseconds)
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();

            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
            button10.Text = "+";
            button11.Text = "-";
            button12.Text = "*";
            button13.Text = "/";
            button14.Text = "=";
            button15.Text = "AC";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            equation = equation + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            equation = equation + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            equation = equation + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            equation = equation + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            equation = equation + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            equation = equation + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            equation = equation + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            equation = equation + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            equation = equation + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            equation = equation + "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            equation = equation + "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            equation = equation + "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            equation = equation + "/";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double result = EvaluateEquation(equation);
            Console.WriteLine(result);
            done = true;
            label1.Text = result.ToString();

        }
        public static double EvaluateEquation(string equation)
        {
            DataTable table = new DataTable();
            return Convert.ToDouble(table.Compute(equation, string.Empty));

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the label with the result
            if (!done) {
                label1.Text = equation;
                    }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            done = false;
            equation = string.Empty;
        }
    }
}
