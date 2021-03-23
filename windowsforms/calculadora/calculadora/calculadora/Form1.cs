using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void input_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '=':
                case (char)Keys.Enter:
                    calculadora calc= new calculadora();
                    input.Text=calc.calculate(input.Text);
                    input.SelectionStart = input.TextLength;
                    input.SelectionLength = 0;
                    break;
            }
        }
    }
}
