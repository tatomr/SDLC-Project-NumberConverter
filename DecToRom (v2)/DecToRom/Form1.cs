using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecToRom
{
    public partial class DecToRom : Form
    {
        public DecToRom()
        {
            InitializeComponent();
        }

        private void decToRomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set properties for the First Radio Button
            arabicEnterLB.Text = "Enter a number between 1 and 3999:";
            romanEnterLB.Text = "Roman Numeral Equivalent:";
            inputTextBox.Text = "";
            inputTextBox.MaxLength = 4;
            inputTextBox.BackColor = Color.LightSteelBlue;


        }

        private void romToDecRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Set properties for the second radio button
            arabicEnterLB.Text = "Enter a Roman Numerals number between I and MMMCMXCIX:";
            romanEnterLB.Text = "Decimal Equivalent:";
            inputTextBox.Text = "";
            inputTextBox.MaxLength = 16;
            inputTextBox.BackColor = Color.Linen;

        }

        private void romanEnterLB_Click(object sender, EventArgs e)
        {

        }

        public void convertBTN_Click(object sender, EventArgs e)
        {
            try
            {
                //If first radio button is selected
                if (decToRomRadioButton.Checked)
                {
                    //Check the input value to make sure it meet the condition, if true display MessageBox
                    if ((int.Parse(inputTextBox.Text) >= 4000))
                    {
                        MessageBox.Show("Please Choose a Smaller Number");
                    }
                    // Else if condition is false, run the convertion code
                    else
                    {

                        //string Variable
                        string Roman;
                        string inputArabic = inputTextBox.Text;
                        
                        //Convert the Arabic number using the ArabicConverter Method and set output to Roman Variable
                        Roman = NumberConverter.ArabicConverter(int.Parse(inputTextBox.Text));
                        listBox1.Items.Add(inputArabic + " = " + Roman);
                    }

                }
                //If second radio button is selected
                else if (romToDecRadioButton.Checked)
                {
                    // String Variable
                    int Arabic;
                    string inputRoman = inputTextBox.Text;

                    //Convert the Roman number using the RomanConverter Method and set output to Arabic Variable
                    Arabic = NumberConverter.RomanConverter(inputTextBox.Text);
                    listBox1.Items.Add(inputRoman  + " = " + Arabic);

                }
                //If third radio button is selected
                else if (referenceRadioButton.Checked)
                {
                    // Clear anything listed in the listbox 
                    listBox1.Items.Clear();
                    
                    // Create Variables
                    int counter;
                    string Conversion;
                    string output;
                    counter = 1;

                    //While loop used to create the list of Roman to Arabic Convertions up to 3999
                    while (counter <= 3999)
                    {
                        //Use the ArabicConverter method to convert the counter number up to 3999
                        Conversion = NumberConverter.ArabicConverter(counter);
                        output = Conversion + " = " + counter;
                        listBox1.Items.Add(output);

                        counter = counter + 1;
                    }

                }
            }
            catch (Exception ex)
            {
                //Display the error message and clears the input textbox
                inputTextBox.Text = "User Syntax Error, Unable to Convert! ";
                inputTextBox.BackColor = Color.Red;
                MessageBox.Show(ex.Message);
                inputTextBox.Text = "";
                inputTextBox.BackColor = Color.LightSteelBlue;
            }


        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }

        private void DecToRom_Load(object sender, EventArgs e)
        {

        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void referenceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set Properties for the third radio button
            arabicEnterLB.Text = "";
            romanEnterLB.Text = "";
            inputTextBox.Text = "Press the Convert Button to view the Roman Numeral Chart";
            inputTextBox.MaxLength = 0;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clear the items in the list box
            listBox1.Items.Clear();
        }
    }
}
