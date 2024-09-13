using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class VendorInfo : Form
    {
        public VendorInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "The vendor is: " + txtName.Text + "from " + txtCompany.Text + "Phone: " + txtCell.Text + "in " + listBox1.GetItemText(listBox1.SelectedItem);
            MessageBox.Show(message);
        }
    }
}
