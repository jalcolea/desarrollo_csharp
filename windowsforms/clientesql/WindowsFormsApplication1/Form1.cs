using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        dataconnection dataconn = new dataconnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void sqlexecute_Click(object sender, EventArgs e)
        {
            //sqloutput.Text= dataconn.executequery(sqlinput.Text);
            string log = "";
            DataTable tbl = dataconn.executequery(sqlinput.Text, out log);
            if (log == "")
            {
                gridoutput.DataSource = tbl;
                //foreach (DataGridViewColumn col in gridoutput.Columns) col.Frozen = false;
                //gridoutput.Refresh();
                outnumresults.Text = Convert.ToString(tbl.Rows.Count);
                foreach (DataGridViewColumn col in gridoutput.Columns) col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                sqlhistory.Text += sqlinput.Text + "\r\n";
                sqlinput.Select(0, 0);
            }
            else
            {
                sqllog.Text += "<"+sqlinput.Text+">"+ ": " + log + "\r\n";
            }
            
            
            
            /*
            // Set your desired AutoSize Mode:
            gridoutput.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gridoutput.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gridoutput.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            */
            // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
            /*for (int i = 0; i <= gridoutput.Columns.Count - 1; i++)
            {
                // Store Auto Sized Widths:
                int colw = gridoutput.Columns[i].Width;

                // Remove AutoSizing:
                gridoutput.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                gridoutput.Columns[i].Width = colw;
            }*/
        }

        private void gridoutput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void sqlinput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.sqlexecute_Click(new Object(), new EventArgs());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlinput.Text = "";
        }
    }
}
