using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic_Plan_8_MBeebe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ------------------------------------------------------------------
        //     CLICK METHOD:ADDS ALL DIGITS IN THE USER INPUT STRING
        // ------------------------------------------------------------------
        private void calculateButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text.Trim();
            int sum = 0;
            int num;

            foreach (char i in input)
            {
                int.TryParse(i.ToString(), out num);
                sum += num;
            }

            outputLabel.Text = $"The sum is {sum}";
        }

        // ------------------------------------------------------------------
        //                 CLICK METHOD: CLEARS FORM
        // ------------------------------------------------------------------
        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = "";
            outputLabel.Text = "";
            inputTextBox.Focus();
        }

        // ------------------------------------------------------------------
        //                 CLICK METHOD: CLOSES FORM
        // ------------------------------------------------------------------
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
