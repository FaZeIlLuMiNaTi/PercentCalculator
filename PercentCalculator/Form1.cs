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

        double inputPercent;
        double inputNumber;
        double outputNumber;
        String outputString;

        #endregion

        public PercentageCalculator()
        {
            InitializeComponent();
        }

        #region Allow only numbers in the textboxes

        private void PercentIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumWithDecimal(sender, e);
        }

        private void NumberIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumWithDecimal(sender, e);
        }

        private void OutputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumWithDecimal(sender, e);
        }

        public void NumWithDecimal(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
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
                inputPercent = double.Parse(PercentIn.Text); // Convert to a double
                inputNumber = double.Parse(NumberIn.Text); // Convert to a double

                if (CalculationTypeBox.Text == "Of") // If the calculation type box is set to "Of"
                {
                    outputNumber = inputPercent * inputNumber / 100; // Times the first box by the second box, then divide by 100
                }

                if (CalculationTypeBox.Text == "Off") // If the calculation type box is set to "Of"
                {
                    outputNumber = inputNumber - (inputPercent * inputNumber / 100); // Times the first box by the second box, divide by 100, then take that away from the seconnd box
                }

                outputNumber = Math.Round(outputNumber, 2); // Round the number to two decimal places
                outputString = Convert.ToString(outputNumber); // Convert the number back into a string
                OutputBox.Text = outputString; // Display the string
            }
        }
    }
}