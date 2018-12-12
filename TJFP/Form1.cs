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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            // Get the text inside the username and password textboxes
            string strUsername = textBoxUsername.Text;
            string strPassword = textBoxPassword.Text;

            if (strUsername == "admin" && strPassword == "password")
            {
                LoadDashboard(true);
            }
            else
            {
                LoadDashboard(false);
            }
        }

        public void LoadDashboard(bool bIsAdmin)
        {
            string strUsername = textBoxUsername.Text;
            if (strUsername == "")
            {
                strUsername = "User"; // Empty login field handling, set a default name.
            }
            Form2 dashboard = new Form2(strUsername, bIsAdmin);
            dashboard.FormClosed += new FormClosedEventHandler(Form2_FormClosed);
            dashboard.Show(); // Show the dashboard window

            this.Hide(); // Hide the login window
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close(); // Exit the application
        }
    }
}
