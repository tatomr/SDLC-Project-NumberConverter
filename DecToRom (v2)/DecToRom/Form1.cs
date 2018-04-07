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
            arabicEnterLB.Text = "Enter a number between 1 and 3999:";
            romanEnterLB.Text = "Roman Numeral Equivalent:";
            inputTextBox.Text = "";
            inputTextBox.MaxLength = 4;
            inputTextBox.BackColor = Color.LightSteelBlue;


        }

        private void romToDecRadioButton_CheckedChanged(object sender, EventArgs e)
        {
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
                if (decToRomRadioButton.Checked)
                {
                    if ((int.Parse(inputTextBox.Text) >= 4000))
                    {
                        MessageBox.Show("Please Choose a Smaller Number");
                    }
                    else
                    {

                        //string Variable
                        string Roman;
                        string inputArabic = inputTextBox.Text;

                        Roman = NumberConverter.ArabicConverter(int.Parse(inputTextBox.Text));
                        listBox1.Items.Add(inputArabic + " = " + Roman);
                    }

                }
                else if (romToDecRadioButton.Checked)
                {
                    int Arabic;
                    string inputRoman = inputTextBox.Text;
                    Arabic = NumberConverter.RomanConverter(inputTextBox.Text);
                    listBox1.Items.Add(inputRoman  + " = " + Arabic);

                }
                else if (referenceRadioButton.Checked)
                {
                    listBox1.Items.Clear();

                    int counter;
                    string Conversion;
                    string output;
                    counter = 1;

                    while (counter <= 3999)
                    {
                        Conversion = NumberConverter.ArabicConverter(counter);
                        output = Conversion + " = " + counter;
                        listBox1.Items.Add(output);

                        counter = counter + 1;
                    }

                }
            }
            catch (Exception ex)
            {
                //Display am error message
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

            arabicEnterLB.Text = "";
            romanEnterLB.Text = "";
            inputTextBox.Text = "Press the Convert Button to view the Roman Numeral Chart";
            inputTextBox.MaxLength = 0;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
