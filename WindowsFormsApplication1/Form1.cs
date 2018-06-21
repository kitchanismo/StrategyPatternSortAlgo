using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSort.Text == "" || cboSort.Text == "-Select Sort-")
            {
                MessageBox.Show("Missing Input");
                lblSort.Text = "*";
                return;
            }

            var strategy = new Factory().Make(cboSort.Text.ToLower());
            var sorter   = new SortedList(strategy);

            for (int i = 0; i < txtSort.TextLength; i++)
            {
                sorter.Add(txtSort.Text.Substring(i,1));
            }
           
            //alternative adding list of string to a list
            //var unsortList = new Helper().ToList(txtSort.Text);
            //sorter.AddList(unsortList);

            sorter.Sort();

            lblSort.Text = sorter.SortedString();
            txtSort.Text = "";
        }

      

    }
}
