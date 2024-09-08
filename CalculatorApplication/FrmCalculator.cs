using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        CalculatorClass cal;

        double num1;
        double num2;
        


        public FrmCalculator()
        {
            InitializeComponent();

            cal = new CalculatorClass();

            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator?.Items.Add("*");
            cbOperator?.Items.Add("/");

            
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtBoxInput1.Text);
            num2 = Convert.ToDouble(txtBoxInput2.Text);

            switch (cbOperator.SelectedItem.ToString())
            {
                case "+":
                    cal.CalculateEvent += new Formula <double> (cal.GetSum);
                    lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula <double>(cal.GetSum);
                    break;
                case "-":
                    cal.CalculateEvent += new Formula <double> (cal.GetDifference);
                    lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula <double> (cal.GetDifference);
                    break;
                case "*":
                    cal.CalculateEvent += new Formula <double>(cal.GetProduct);
                    lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula <double> (cal.GetProduct);
                    break;
                case "/":
                    cal.CalculateEvent += new Formula <double> (cal.GetQuotient);
                    lblDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula <double> (cal.GetQuotient);
                    break;

                default:
                    lblDisplayTotal.Text = "Error!";
                    break;
            }
        }

    }
}
