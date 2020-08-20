using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic_Plan_4_MBeebe
{
    public partial class DiscountCalculator : Form
    {
        // -------------------------------------------------------------------------
        //                          STARTS APPLICATION
        // -------------------------------------------------------------------------
        public DiscountCalculator()
        {
            InitializeComponent();
        }
        
        // -------------------------------------------------------------------------
        //        SIMPLE METHOD THAT CLEARS THE OUTPUT AND INPUT TEXTBOX
        // -------------------------------------------------------------------------
        public void clearAll()
        {
            numOfPackagesTextBox.Text = "";
            discountRateOutput.Text = "";
            savingsOutput.Text = "";
            toalPriceOutput.Text = "";
            numOfPackagesTextBox.Focus();
        }

        // -------------------------------------------------------------------------
        //    CALCULATES THE DISCOUNT RATE, AMOUNT SAVED, AND TOTAL PRICE AFTER
        //                 DISCOUNT AND RENDERS THEM TO THE FORM
        // -------------------------------------------------------------------------
        private void caclulateButton_Click(object sender, EventArgs e)
        {
            // FIRST, CHECKS TO MAKE SURE INPUT IS VALID, THEN FINDS PROPER DISCOUNT RATE
            double numOfPackages;
            if (Double.TryParse(numOfPackagesTextBox.Text, out numOfPackages))
            {
                double discountRate;

                if (numOfPackages >= 10 && numOfPackages <= 19)
                {
                    discountRate = 0.20;
                }
                else if (numOfPackages >= 20 && numOfPackages <= 49)
                {
                    discountRate = 0.30;
                }
                else if (numOfPackages >= 50 && numOfPackages <= 99)
                {
                    discountRate = 0.40;
                }
                else if (numOfPackages > 99)
                {
                    discountRate = 0.50;
                }
                else
                {
                    discountRate = 0;
                }

                // CALCULATIONS
                double basePrice = 99 * numOfPackages;
                double totalSavings = basePrice * discountRate;
                double totalAfterDiscount = basePrice - totalSavings;

                // RENDERING CALCULATIONS TO FORM
                discountRateOutput.Text = $"{discountRate * 100}%";
                savingsOutput.Text = totalSavings.ToString("c");
                toalPriceOutput.Text = totalAfterDiscount.ToString("c");
            }
            else
            {
                MessageBox.Show("Please enter a valid purchase amount.");
                clearAll();
            }
        }

        // -------------------------------------------------------------------------
        //                   CLEARS ALL FIELDS AND OUTPUT
        // -------------------------------------------------------------------------
        private void clearButton_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        // -------------------------------------------------------------------------
        //                             CLOSES FORM
        // -------------------------------------------------------------------------
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
