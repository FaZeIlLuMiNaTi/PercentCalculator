using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PercentCalculator
{
    public partial class PercentageCalculator : Form
    {
        #region Variables

        int inputPercent;
        int inputNumber;
        int outputNumer;
        String outputString;

        #endregion

        public PercentageCalculator()
        {
            InitializeComponent();
        }

        #region Allow only numbers in the textboxes

        private void PercentIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void NumberIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void OutputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        #endregion

        private void PercentageCalculator_Load(object sender, EventArgs e)
        {
            CalculationTypeBox.SelectedIndex = 0; // Make the first item in the combobox selected
        }

        private void GoButton_Click(object sender, EventArgs e) // Listen for when the GoButton is clicked
        {
            if (PercentIn.Text != "" || NumberIn.Text != "") // If the input boxes aren't empty
            {
                inputPercent = Convert.ToInt32(PercentIn.Text); // Convert the string in the percent box to an integer
                inputPercent = int.Parse(PercentIn.Text); // Parse the integer

                inputNumber = Convert.ToInt32(NumberIn.Text); // Convert the string in the number box to an integer
                inputNumber = int.Parse(NumberIn.Text); // Parse the integer

                if (CalculationTypeBox.Text == "Of") // If the calculation type box is set to "Of"
                {
                    outputNumer = inputPercent * inputNumber / 100; // Times the first box by the second box, then divide by 100
                }

                if (CalculationTypeBox.Text == "Off") // If the calculation type box is set to "Of"
                {
                    outputNumer = inputNumber - (inputPercent * inputNumber / 100); // Times the first box by the second box, divide by 100, then take that away from the seconnd box
                }

                outputString = Convert.ToString(outputNumer); // Convert the number back into a string
                OutputBox.Text = outputString; // Display the string
            }
        }
    }
}
