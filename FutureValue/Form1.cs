using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            decimal yearlyInterestRate = Convert.ToDecimal(txtInterestRate.Text);
            int years = Convert.ToInt32(txtYears.Text);

            int months = years * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;


            // modified click event code so it calls for the new CalculateFutureValue method
            txtFutureValue.Text = CalculateFutureValue(months,monthlyInvestment, monthlyInterestRate).ToString("c");
            txtMonthlyInvestment.Focus();
        }
        

            // created CalculateFutureValue Method by hand
        private static decimal CalculateFutureValue(int months, decimal monthlyInvestment, decimal monthlyInterestRate)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)
                            * (1 + monthlyInterestRate);
            }
            return futureValue;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

           // created TextChange event and coded to clear the future value
        private void ClearFutureValue(object sender, EventArgs e)
        {
            txtFutureValue.Text = "";
        }
        
         //created form event handler for double click to clear all text boxes
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            txtYears.Text = "";
            txtMonthlyInvestment.Text = "";
            txtInterestRate.Text = "";
            txtFutureValue.Text = "";
        }
        /***************************************
         * Andrea Griffis
         * 5/1/2020
         * Ex 6-2 Experiment with event
         * *************************************/
         //set interest rate text box to 12 when doubleclicked
        private void txtInterestRate_DoubleClick(object sender, EventArgs e)
        {
            txtInterestRate.Text = "12";
        }
    }
}