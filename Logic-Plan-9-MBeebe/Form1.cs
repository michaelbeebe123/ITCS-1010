using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic_Plan_9_MBeebe
{
    public partial class showDirection : Form
    {
        // ----------------------------------------------------------------
        // CLASS OF DIRECTIONS THAT WILL BE REFERENCED IN CLICK METHODS
        // ----------------------------------------------------------------
        enum Compass
        {
            North, South, East, West
        }

        // ---------------------------------------------
        //                STARTS FORM
        // ---------------------------------------------
        public showDirection()
        {
            InitializeComponent();
        }

        // ---------------------------------------------
        //    RENDERS CLICKED DIRECTION TO THE FORM
        // ---------------------------------------------
        private void displayDirection(Compass direction)
        {
            outputLabel.Text = direction.ToString();
        }

        // ------------------------------------------------------------
        // CLICK METHODS THAT PASS IN THE ASSOCIATING DIRECTION TO
        // displayDirection() AS ARGS
        // ------------------------------------------------------------
        private void northLabel_Click(object sender, EventArgs e)
        {
            displayDirection(Compass.North);
        }

        private void southLabel_Click(object sender, EventArgs e)
        {
            displayDirection(Compass.South);
        }

        private void eastLabel_Click(object sender, EventArgs e)
        {
            displayDirection(Compass.East);
        }

        private void westLabel_Click(object sender, EventArgs e)
        {
            displayDirection(Compass.West);
        }

        // ---------------------------------------------
        //         CLICK METHOD: CLOSES FORM
        // ---------------------------------------------
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
