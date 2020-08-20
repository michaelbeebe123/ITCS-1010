using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic_Plan_7_MBeebe
{
    public partial class lotteryNumbers : Form
    {
        public lotteryNumbers()
        {
            InitializeComponent();
        }

        // --------------------------------------------------------------
        //  CLICK METHOD: GENERATES 5 RANDOM NUMBERS BETWEEN 0 AND 99
        // --------------------------------------------------------------
        private void generateButton_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[5];
            Random rand = new Random();
            int total = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(100);
                total += numbers[i];
            }

            label1.Text = numbers[0].ToString();
            label2.Text = numbers[1].ToString();
            label3.Text = numbers[2].ToString();
            label4.Text = numbers[3].ToString();
            label5.Text = numbers[4].ToString();
            totalNumbersOutput.Text = total.ToString();

        }

        // --------------------------------------------------------------
        //           CLICK METHOD: CLEARS THE OUPUT LABELS
        // --------------------------------------------------------------
        private void clearButton_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            totalNumbersOutput.Text = "";
        }

        // --------------------------------------------------------------
        //             CLICK METHOD: CLOSES THE FORM
        // --------------------------------------------------------------
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
