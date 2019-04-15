using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(textBox1.Text, out parsedValue))
            {
                MessageBox.Show("Enter Number of problems to generate");
            }
            else { 
            
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            Random rnd3 = new Random();
            Random operatorSelect = new Random();

            int nu1 = rnd1.Next(0, 20);
            int nu2 = rnd2.Next(0, 50);
            int nu3 = rnd3.Next(0, 101);

            int mathOperator = 0;
            string newOperator = "";
            int mathOperator2 = 0;
            string newOperator2 = "";

            mathOperator = operatorSelect.Next(5);
            switch (mathOperator)
            {
                case 1:
                    newOperator = "+";

                    break;
                case 2:
                    newOperator = "-";
                    break;
                case 3:
                    newOperator = "*";
                    break;
                case 4:
                    newOperator = "/";
                    break;
                case 5:
                    newOperator = "+";
                    break;
            }
            mathOperator2 = operatorSelect.Next(5);
            switch (mathOperator2)
            {
                case 1:
                    newOperator2 = "+";
                    break;
                case 2:
                    newOperator2 = "-";
                    break;
                case 3:
                    newOperator2 = "*";
                    break;
                case 4:
                    newOperator2 = "/";
                    break;
                case 5:
                    newOperator2 = "+";
                    break;
            }
                        
            string newLine = Environment.NewLine;
            string ans = "";
            double result = 0;

            ans = nu1 + Convert.ToString(newOperator) + nu2 + Convert.ToString(newOperator2) + nu3;
            result = Convert.ToDouble(new DataTable().Compute(ans, null));

            if (result >= 0 && result <= 100)
            {
                txtNumbers.Text = nu1 + " " + newOperator + " " + nu2 + " " + newOperator2 + " " + nu3 + " = " + " " + Convert.ToString(result);
            }
            else {
            }

            int num1 = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i < num1; i++)
            {
                nu1 = rnd1.Next(0, 20);
                nu2 = rnd2.Next(0, 50);
                nu3 = rnd3.Next(0, 101);
                mathOperator = operatorSelect.Next(5);
                switch (mathOperator)
                {
                    case 1:
                        newOperator = "+";

                        break;
                    case 2:
                        newOperator = "-";
                        break;
                    case 3:
                        newOperator = "*";
                        break;
                    case 4:
                        newOperator = "/";
                        break;
                    case 5:
                        newOperator = "+";
                        break;
                }
                mathOperator2 = operatorSelect.Next(5);
                switch (mathOperator2)
                {
                    case 1:
                        newOperator2 = "+";
                        break;
                    case 2:
                        newOperator2 = "-";
                        break;
                    case 3:
                        newOperator2 = "*";
                        break;
                    case 4:
                        newOperator2 = "/";
                        break;
                    case 5:
                        newOperator2 = "+";
                        break;
                }
                ans = nu1 + Convert.ToString(newOperator) + nu2 + Convert.ToString(newOperator2) + nu3;
                result = Convert.ToDouble(new DataTable().Compute(ans, null));
                if (result >= 0 && result <= 100)
                {
                    txtNumbers.Text = txtNumbers.Text + newLine + nu1 + " " + newOperator + " " + nu2 + " " + newOperator2 + " " + nu3 + " = " + " " + Convert.ToString(result);
                }
                else
                {
                }
            }
            textBox1.Clear();
            }
        }
         private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtNumbers.Clear();
            textBox1.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"C:\Users\betty\Desktop\Result.txt");
            writer.Write(txtNumbers.Text);
            writer.Close();

            MessageBox.Show("Successfully Exported");
        }
    }
}
