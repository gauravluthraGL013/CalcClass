using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CalcClass
{
    public partial class Form1 : Form
    {
        private Calc myCalc = new Calc();
        public Form1()
        {
            InitializeComponent();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            cbxOperation.Items.AddRange(myCalc.loadSymbols());
            cbxOperation.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result;
            myCalc.num1 = Convert.ToDouble( txtNum1.Text);
            myCalc.num2 = Convert.ToDouble( txtNum2.Text);

            myCalc.selectedSymbol = cbxOperation.SelectedItem.ToString();

            result = myCalc.selectedOperation();

            lbxOutput.Items.Add(myCalc.num1 + " " + myCalc.selectedSymbol + " " + myCalc.num2 + " = " + result);
        }
    }
}
