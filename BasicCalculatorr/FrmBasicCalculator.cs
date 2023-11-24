using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculatorr
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            cbOperation.Items.Add("+");
            cbOperation.Items.Add("-");
            cbOperation.Items.Add("*");
            cbOperation.Items.Add("/");
        }

        float num1, num2;
        private void btnCompute_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtNum1.Text);
            num2 = float.Parse(txtNum2.Text);

            if (cbOperation.Text == "+")
            {
                lblTotal.Text = BasicComputation.Addition(num1, num2).ToString();
            }

            else if (cbOperation.Text == "-")
            {
                lblTotal.Text = BasicComputation.Subtraction(num1, num2).ToString();
            }

            else if (cbOperation.Text == "*")
            {
                lblTotal.Text = BasicComputation.Multiplication(num1, num2).ToString();
            }

            else if (cbOperation.Text == "/")
            {
                lblTotal.Text = BasicComputation.Division(num1, num2).ToString();
            }

        }
    }
}
