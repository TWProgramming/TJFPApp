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
    public partial class Form2 : Form
    {
        // Global string arrays
        string[] custFirstNames =
        {
            "Dave", "Mark", "Tyler", "Justin", "Faraz", "Pranav",
            "Lisa", "Diana", "Nicole", "Tanya", "Alexandra"
        };
        string[] custLastNames =
        {
            "Morrison", "Wendell", "Kennedy", "Morell", "Kensington",
            "Stevenson", "Garner", "Tavender", "Kaine", "Dudley"
        };
        string[] provinces =
        {
            "AB", "BC", "MB", "NB", "NL", "NS",
            "NT", "NU", "ON", "PE", "QC", "SK", "YT"
        };
        string[] cities =
        {
            "Edmonton", "Victoria", "Winnipeg", "Fredericton", "St John's", "Halifax",
            "Yellowknife", "Iqaluit", "Ottawa", "Charlottetown", "Québec", "Regina", "Whitehorse"
        };
        string[] products =
        {
            "Lawnmower", "Muffler", "Grass Bag", "Repairs"
        };
        string[] notes =
        {
            "Customer bought a new lawnmower",
            "Customer bought a new muffler",
            "Customer bought a new grass bag",
            "Customer got repairs done to their lawnmower"
        };

        Random randNum = new Random();
        // strUsername and bIsAdmin are passed through from Form1.cs
        public Form2(string strUsername, bool bIsAdmin)
        {
            InitializeComponent();

            if (bIsAdmin == true)
            {
                labelLoggedInAs.Text = "Logged in as: Sales Admin";
                for (int i = 0; i < 20; i++)
                {
                    recentSalesBox.Items.Add(custFirstNames[randNum.Next(10)] + " " + custLastNames[randNum.Next(10)]);
                }
            }
            else
            {
                labelLoggedInAs.Text = "Logged in as: Sales Employee";
                tabControl1.Controls.Remove(tabPageAdmin);
            }

            // Loop 3 times for the rows
            for (int i = 0; i < 3; i++)
            {
                // Loop 5 times for the columns
                for (int j = 0; j < 5; j++)
                {
                    // Set up item amount labels
                    Label amountLabel = new Label
                    {
                        Location = new Point(8 + 118 * j, 8 + 118 * i),
                        Parent = tabPageInv,
                        Text = "Model #: " + randNum.Next(99) + "\n" + "Amount in stock: " + randNum.Next(99).ToString(),
                        ForeColor = Color.White,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Visible = true,
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
                        Font = new Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                        AutoSize = true
                    };
                    tabPageInv.Controls.Add(amountLabel);

                    // Set up picture boxes
                    PictureBox itemPicture = new PictureBox
                    {
                        BorderStyle = BorderStyle.Fixed3D,
                        Location = new Point(6 + 118 * j, 6 + 118 * i),
                        Parent = tabPageInv,
                        Visible = true,
                        Size = new Size(114, 114),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Image = Properties.Resources.mower1,
                    };
                    tabPageInv.Controls.Add(itemPicture);
                }
            }
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            // Clear any existing search results from the ListBox
            searchResultListBox.Items.Clear();

            // Capture the entered first/last name
            string custFirstName = firstNameSearchBox.Text;
            string custLastName = lastNameSearchBox.Text;

            // Probably a cleaner way to do this but it works.
            // Make sure the first and last name boxes aren't empty
            if (custFirstName == String.Empty && custLastName == String.Empty)
            {
                MessageBox.Show("Please enter a name", "Hey", MessageBoxButtons.OK);
            }
            else if (custFirstName == String.Empty)
            {
                for (int i = 0; i < randNum.Next(10); i++)
                {
                    searchResultListBox.Items.Add(custFirstNames[i] + " " + custLastName);
                }
            }
            else if (custLastName == String.Empty)
            {
                for (int i = 0; i < randNum.Next(10); i++)
                {
                    searchResultListBox.Items.Add(custFirstName + " " + custLastNames[i]);
                }
            }
            // Nothing is empty, so let's generate some random names
            else
            {
                for (int i = 0; i < randNum.Next(10); i++)
                {
                    searchResultListBox.Items.Add(custFirstName + " " + custLastName);
                }
            }
        }

        private void RecentSalesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iRandomNum = randNum.Next(0, 13);
            int iRandomProd = randNum.Next(0, 4);

            admCustName.ResetText();
            admCustAddress.ResetText();
            admCustCity.ResetText();
            admCustProvince.ResetText();
            admCustEmail.ResetText();
            admCustPhone.ResetText();
            admSaleAmount.ResetText();
            admSaleProd.ResetText();
            admSaleNotes.ResetText();

            admCustName.Text = recentSalesBox.SelectedItem.ToString();
            admCustAddress.Text = randNum.Next(0000, 9999).ToString() + " Fake Street";
            admCustCity.Text = cities[iRandomNum];
            admCustProvince.Text = provinces[iRandomNum];
            admCustPhone.Text = randNum.Next(111, 999).ToString() + "-" + randNum.Next(111, 999).ToString() + "-" + randNum.Next(0000, 9999).ToString();
            admCustEmail.Text = "L2G 5H3";
            admSaleAmount.Text = randNum.Next(1, 3).ToString();
            admTotalCost.Text = "$" + randNum.Next(100, 2500).ToString();
            admSaleProd.Text = products[iRandomProd];
            admSaleNotes.Text = notes[iRandomProd];

        }

        private void SearchResultListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iRandomNum = randNum.Next(0, 12);
            custNameSelected.Text = searchResultListBox.SelectedItem.ToString();
            custAddressSelected.Text = randNum.Next(0000, 9999).ToString() + " Fake Street";
            custCitySelected.Text = cities[iRandomNum];
            custProvinceSelected.Text = provinces[iRandomNum];
            custPhoneSelected.Text = randNum.Next(111, 999).ToString() + "-" + randNum.Next(111, 999).ToString() + "-" + randNum.Next(0000, 9999).ToString();
            custEmailSelected.Text = "L2G 5H3";
        }

        private void SaveCustomerButton_Click(object sender, EventArgs e)
        {
            if (custNameBox.Text == String.Empty)
            {
                MessageBox.Show("Please enter a name", "Hey", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Saved new customer: " + custNameBox.Text, "Hey", MessageBoxButtons.OK);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee appreciation discount now active!", "Employee Appreciation", MessageBoxButtons.OK);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 repair = new Form3();
            repair.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form4 sale = new Form4();
            sale.Show();
        }
    }
}