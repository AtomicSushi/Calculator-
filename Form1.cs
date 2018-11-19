using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {

        
        Calculator newton = new Calculator();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.currentValueBox.Text += "7";
            
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            this.currentValueBox.Text += "8";
            
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            this.currentValueBox.Text += "9";
            
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            this.currentValueBox.Text += "4";
            
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            this.currentValueBox.Text += "5";
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            this.currentValueBox.Text += "6";
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            this.currentValueBox.Text += "1";
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            this.currentValueBox.Text += "2";
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            this.currentValueBox.Text += "3";
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            this.currentValueBox.Text += "0";

        }

        private void ButtonDecimal_Click(object sender, EventArgs e)
        {
           
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            newton.Divide(currentValueBox.Text);
        }
        private void ButtonMultiply_Click(object sender2, EventArgs e)
        {
            newton.Multiply(currentValueBox.Text);
        }

        private void ButtonSubtract_Click(object sender1, EventArgs e)
        {
            newton.Subtract(currentValueBox.Text);
        }

        private void ButtonAdd_Click(object sender3, EventArgs e)
        {
            newton.Add(currentValueBox.Text);
        }

        private void PolarSign_Click(object sender, EventArgs e)
        {
           
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonSquare_Click(object sender, EventArgs e)
        {
           
        }

        private void Buttonsqrt_Click(object sender, EventArgs e)
        {
           
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            string a = currentValueBox.Text.Remove((currentValueBox.Text.Count() - 1), 1);
            this.currentValueBox.Text = a;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
           
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            this.currentValueBox.Text += "7";
        }

        private void ButtonBack_Click_1(object sender, EventArgs e)
        {
            string a = currentValueBox.Text.Remove((currentValueBox.Text.Count() - 1), 1);
            this.currentValueBox.Text = a;
        }

        private void Eightbutton(object sender, EventArgs e)
        {
            this.currentValueBox.Text += "8";
        }

        private void Fourbutton(object sender, EventArgs e)
        {
            this.currentValueBox.Text += "4";

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.currentValueBox.Text += "5";
        }

        private void SixButton_Click_1(object sender, EventArgs e)
        {
            this.currentValueBox.Text += "6";
        }

        private void OneButton_Click_1(object sender, EventArgs e)
        {
            this.currentValueBox.Text += "1";
        }

        private void TwoButton_Click_1(object sender, EventArgs e)
        {
            this.currentValueBox.Text += "2";
        }

        private void ThreeButton_Click_1(object sender, EventArgs e)
        {
            this.currentValueBox.Text += "3";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            string none = "";
            this.currentValueBox.Text = none;
            newton.Clear();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void ZeroButton_Click_1(object sender, EventArgs e)
        {
            this.currentValueBox.Text += "0";
        }

        private void PolarButton_Click(object sender, EventArgs e)
        {
            if (currentValueBox.Text[0] == '-')
            {
                currentValueBox.Text = currentValueBox.Text.Remove(0, 1);
            }
            else
            {
                currentValueBox.Text = '-' + currentValueBox.Text;
            }
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            currentValueBox.Text += ".";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            newton.Add(currentValueBox.Text);
            currentValueBox.Text = "";
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            newton.Subtract(currentValueBox.Text);
            currentValueBox.Text = "";
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            newton.Multiply(currentValueBox.Text);
            currentValueBox.Text = "";
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            newton.Divide(currentValueBox.Text);
            currentValueBox.Text = "";
        }

        private void SqrtButton_Click(object sender, EventArgs e)
        {
            int val1;
            decimal val2;


            if (int.TryParse(this.currentValueBox.Text, out val1))
            {
                val1 = val1 * val1;

                this.currentValueBox.Text = val1.ToString();
            }

            else if (decimal.TryParse(this.currentValueBox.Text, out val2))
            {
                val2 = val2 * val2;

                this.currentValueBox.Text = val2.ToString();
            }
        }

        private void OneOverButton_Click(object sender, EventArgs e)
        {
            decimal val1 = Convert.ToDecimal(currentValueBox.Text);
            val1 = 1 / val1;
            this.currentValueBox.Text = val1.ToString();
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            string none = "";
            newton.CurrentValue = currentValueBox.Text;
            newton.Equals();
            this.currentValueBox.Text = newton.CurrentValue;
            newton.Operand2 = "";
            newton.CurrentValue = none;
            
        }

        private void NineButton_Click_1(object sender, EventArgs e)
        {
            this.currentValueBox.Text += "9";
        }
    }
}



