using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * TJFP "App" by TWProgramming
 */
namespace TJFP
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void RepairButtonClear_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void RepairButtonSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Repair info saved.", "Success!", MessageBoxButtons.OK);
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close(); // Exit the application
        }

        private void RrSaveCustButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer info saved.", "Success!", MessageBoxButtons.OK);
        }

        private void RrCustInfoClearButton_Click(object sender, EventArgs e)
        {
            custNameBox.ResetText();
            custAddressBox.ResetText();
            custCityBox.ResetText();
            custPhoneBox.ResetText();
            custPostalBox.ResetText();
            custProvinceList.ResetText();
        }
    }
}
