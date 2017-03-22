using System;
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

        private void PercentIn_KeyPress(object sender, KeyPressEventArgs e) // If a keypress is detected
        {
            NumWithDecimal(sender, e); // Call this function to check the key that was pressed

            if (e.KeyChar == (char)Keys.Enter) // If the enter key is pressed
            {
                GoButton_Click(sender, e); // Call the GoButton_Click function
            }
        }

        private void NumberIn_KeyPress(object sender, KeyPressEventArgs e) // If a keypress is detected
        {
            NumWithDecimal(sender, e); // Call this function to check the key that was pressed
            
            if (e.KeyChar == (char)Keys.Enter) // If the enter key is pressed
            {
                GoButton_Click(sender, e); // Call the GoButton_Click function
            }
        }

        public void NumWithDecimal(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.')) // If the character isnt a number, or is the back key, or is the full stop
            {
                e.Handled = true; // Tell the sender that the task was hanlded
            }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains(".")) // If the character is a full stop and the text box contains a "."
            {
                e.Handled = true; // Tell the sender that the task was hanlded
            }
        }

        #endregion

        private void PercentageCalculator_Load(object sender, EventArgs e)
        {
            CalculationTypeBox.SelectedIndex = 0; // Make the first item in the combobox selected
        }

        private void GoButton_Click(object sender, EventArgs e) // Listen for when the GoButton is clicked
        {
            bool isPercentInDouble = Double.TryParse(PercentIn.Text, out inputPercent); // Convert to a double
            bool isNumberInDouble = Double.TryParse(NumberIn.Text, out inputNumber); // Convert to a double

            if (isPercentInDouble || isNumberInDouble) // If the input boxes aren't empty using bools. Hopefully this fixes an issue that crashes the program
            {
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
            else
            {
                MessageBox.Show("Please enter some numbers"); // Tell the user that they should enter numbers
            }
        }
    }
}