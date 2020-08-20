using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic_Plan_3_MBeebe
{
    public partial class PurchasePriceCalculator : Form
    {
        public PurchasePriceCalculator()
        {
            InitializeComponent();
        }

        // ------------------------------------------------------------------
        //        CLICK METHOD THAT TAKES IN USER INPUT AND OUTPUTS
        //                THAT INPUT WITH A 10% DISCOUNT
        // ------------------------------------------------------------------
        private void calculatePurchaseButton_Click(object sender, EventArgs e)
        {
            const double discountRate = 0.10;

            decimal originalPrice = decimal.Parse(amountOfPurchaseTextBox.Text); // CONVERTS DECIMAL INPUT TO STING
            decimal discountAmount = originalPrice * (decimal)discountRate; // CALCULATES DISCOUNT AMOUNT
            decimal totalOfSale = originalPrice - discountAmount; // SUBTRACTS THE DISCOUNT AMOUNT FROM THE ORIGINAL AMOUNT

            //      OUTPUTS THE ABOVE VARIABLES TO THE FORM
            amountOfPurchaseOutput.Text = originalPrice.ToString("c");
            totalDiscountAmountOutput.Text = discountAmount.ToString("c");
            totalOfSaleOutput.Text = totalOfSale.ToString("c");
        }

        // ------------------------------------------------------------------
        //                  CLICK METHOD THAT CLOSES THE FORM
        // ------------------------------------------------------------------
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}