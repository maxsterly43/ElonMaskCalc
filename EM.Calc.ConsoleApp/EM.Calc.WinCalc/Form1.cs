using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EM.Calc.WinCalc
{
    public partial class Form1 : Form
    {
        private Core.Calc calc;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calc = new Core.Calc();
            cbOperation.Items.AddRange(calc.GetOperationsName);
            cbOperation.SelectedIndex = 0;
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            try
            {
                var values = input.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Convert.ToDouble).ToArray();
                var operation = cbOperation.Text;
                var result = calc.Execute(operation, values);
                lblResult.Text = $"{result}";
            }
            catch (Exception ex)
            {

            }
        }

        private void input_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8 && number != 32)
            {
                e.Handled = true;
            }
        }
    }
}