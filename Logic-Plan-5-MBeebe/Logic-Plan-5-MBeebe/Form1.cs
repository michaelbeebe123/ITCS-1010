using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic_Plan_5_MBeebe
{
    public partial class distanceCalculator : Form
    {
        public distanceCalculator()
        {
            InitializeComponent();
        }

        // ---------------------------------------------------
        //                  RESETS THE FORM
        // ---------------------------------------------------
        void clearAll()
        {
            vehicleSpeedTextbox.Text = "";
            hoursTraveledTextbox.Text = "";
            outputListbox.Items.Clear();
            vehicleSpeedTextbox.Focus();
        }

        // -----------------------------------------------------------------------------------
        // CLICK METHOD: CALCULATES THE DISTANCE TRAVELED AFTER EACH HOUR STARTING FROM 1 UP
        //               THE NUMBER OF HOURS THE USER ENTERED. INCREMENTS BY 1
        // -----------------------------------------------------------------------------------
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double speed;
            double hours;
            if (Double.TryParse(vehicleSpeedTextbox.Text, out speed))
            {
                if (Double.TryParse(hoursTraveledTextbox.Text, out hours))
                {
                    for (int i = 1; i <= hours; i++)
                    {
                        double distance = speed * i;
                        outputListbox.Items.Add($"After hour {i} the distance is {distance}");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number of hours.");
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid speed.");
                clearAll();
            }
        }

        // ---------------------------------------------------
        //            CLICK METHOD: CLEARS FORM
        // ---------------------------------------------------
        private void clearButton_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        // ---------------------------------------------------
        //           CLICK METHOD: CLOSES FORM
        // ---------------------------------------------------
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
