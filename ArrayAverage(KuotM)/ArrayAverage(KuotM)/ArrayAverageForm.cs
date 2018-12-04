using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayAverage_KuotM_
{
    public partial class frmArrayAverage : Form
    {
        // This declares a global variable
        const int MaxArraySize = 10;
        int[] arrayOfNumbers = new int[MaxArraySize];

        public frmArrayAverage()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // This declares local variables
            int aRandomNum;
            int counter;
            Random rdmNumGen = new Random();

            // This clears the list box
            lstNumbers.Items.Clear();

            for (counter = 0; counter < MaxArraySize; counter++)
            {
                // Generate a random number between 1 and the MaxArraySize
                aRandomNum = rdmNumGen.Next(1, MaxArraySize);

                // Assign the random number to the array
                arrayOfNumbers[counter] = aRandomNum;

                // Add the number to the list box
                lstNumbers.Items.Add(aRandomNum);

                // This refreshes the form
                this.Refresh();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }
    }
}
