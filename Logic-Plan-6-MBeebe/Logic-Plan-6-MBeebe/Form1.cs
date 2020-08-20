using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic_Plan_6_MBeebe
{
    public partial class retailPriceCalculator : Form
    {
        public retailPriceCalculator()
        {
            InitializeComponent();
        }

        // ----------------------------------------------------------------------------------------------------
        //                                         CLEARS FORM
        // ----------------------------------------------------------------------------------------------------
        void clearAll()
        {
            wholesaleCostInputTextbox.Text = "";
            markupPercentageInputTextbox.Text = "";
            retailPriceOutput.Text = "";
            wholesaleCostInputTextbox.Focus();
        }

        // ----------------------------------------------------------------------------------------------------
        //                                  CALCULATES RETAIL PRICE
        // ----------------------------------------------------------------------------------------------------
        double calculateRetailPrice(double wholesaleCost, double markupPercentage)
        {
            double retailPrice = wholesaleCost * ((markupPercentage / 100) + 1);
            return (retailPrice);
        }

        // ----------------------------------------------------------------------------------------------------
        //                   CLICK METHOD: PASSES USER INPUT IN TO ***calculateRetailPrice***
        // ----------------------------------------------------------------------------------------------------
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double wholesaleCost;
            double markupPercentage;

            if (Double.TryParse(wholesaleCostInputTextbox.Text, out wholesaleCost))
            {
                if (Double.TryParse(markupPercentageInputTextbox.Text, out markupPercentage))
                {
                    double retailPrice = calculateRetailPrice(wholesaleCost, markupPercentage);
                    retailPriceOutput.Text = $"Retail Price: {retailPrice.ToString("c")}";
                }
                else
                {
                    MessageBox.Show("Please enter a valid markup percentage.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid wholesale cost.");
            }

        }

        // ----------------------------------------------------------------------------------------------------
        //                                          RESETS FORM
        // ----------------------------------------------------------------------------------------------------
        private void clearButton_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        // ----------------------------------------------------------------------------------------------------
        //                                         CLOSES FORM
        // ----------------------------------------------------------------------------------------------------
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
