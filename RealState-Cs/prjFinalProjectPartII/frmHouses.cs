using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace prjFinalProjectPartII
{
    public partial class frmHouses : Form
    {
        public frmHouses()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit?", "Processing", MessageBoxButtons.YesNo).ToString() == "Yes")
                Close();
        }
        DataSet myset;
        DataTable tabHouses;
        OleDbDataAdapter adpHouses;
        OleDbConnection mycon;
        int currentposition;
        string mode = "";

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentposition > 0)
            {
                currentposition--;
                Display();
                GridView();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentposition < (tabHouses.Rows.Count - 1))
            {
                currentposition++;
                Display();
                GridView();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentposition = tabHouses.Rows.Count - 1;
            Display();
            GridView();
        }

        private void frmHouses_Load(object sender, EventArgs e)
        {
            myset = new DataSet();
            mycon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bela_\source\repos\420-DA3-AS\prjFinalProjectPartI\prjFinalProjectPartII\remaxDB.mdb;Persist Security Info=True");
        
            mycon.Open();

            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM houses", mycon);
            adpHouses = new OleDbDataAdapter(mycmd);
            adpHouses.Fill(myset, "houses");

            tabHouses = myset.Tables["houses"];
           
            lblInfo.Text = "--- CONSULT MODE ---";
            Display();
            gridHouses.DataSource = tabHouses;
           
            mycon.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtHouseId.Text = "";
            txtAddress.Text = txtHouseStatus.Text = "";
            txtPrice.Text = "";
            gridHouses.DataSource = null;
            txtAddress.Focus();
            lblInfo.Text = "--- ADDING MODE ---";
            mode = "add";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtAddress.Focus();
            lblInfo.Text = "--- EDITING MODE ---";
            mode = "edit";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure to delete this house? ";
            string title = "Warning: house Deleted!";
            if (MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                tabHouses.Rows[currentposition].Delete();

                OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(adpHouses);
                adpHouses.Update(myset, "houses");

                myset.Tables.Remove("houses");
                OleDbCommand mycmd = new OleDbCommand("SELECT * FROM houses", mycon);
                adpHouses = new OleDbDataAdapter(mycmd);
                adpHouses.Fill(myset, "houses");
                tabHouses = myset.Tables["houses"];

                currentposition = 0;
                Display();
            }
        }

        private void Display()
        {
            txtHouseId.Text = tabHouses.Rows[currentposition]["houseId"].ToString();
            txtAddress.Text = tabHouses.Rows[currentposition]["address"].ToString();
            txtHouseStatus.Text = tabHouses.Rows[currentposition]["status"].ToString();
            txtPrice.Text = tabHouses.Rows[currentposition]["price"].ToString();
            txtClientNumber.Text = tabHouses.Rows[currentposition]["clientId"].ToString();

            lblInfo.Text = "House " + (currentposition + 1) + " on a total of " + tabHouses.Rows.Count;

           
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentposition = 0;
            Display();
            GridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtHouseId.Text.Trim();
            string address = txtAddress.Text.Trim();
            string status = txtHouseStatus.Text.Trim();
            decimal price = Convert.ToDecimal(txtPrice.Text);
            string clNumb = txtClientNumber.Text.Trim();


            DataRow myrow = (mode == "add") ? tabHouses.NewRow() : tabHouses.Rows[currentposition];

            myrow["houseId"] = id;
            myrow["address"] = address;
            myrow["status"] = status;
            myrow["price"] = price;
            myrow["clientId"] = clNumb;

            if (mode == "add")
            {
                tabHouses.Rows.Add(myrow);
                currentposition = tabHouses.Rows.Count - 1;
            }

            OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(adpHouses);
            adpHouses.Update(myset, "houses");
            myset.Tables.Remove("houses");
            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM houses", mycon);
            adpHouses = new OleDbDataAdapter(mycmd);
            adpHouses.Fill(myset, "houses");
            tabHouses = myset.Tables["houses"];

            mode = "";
            Display();


            lblInfo.Text = "--- SAVING MODE ---";
        }

        private void GridView()
        {


           string id = txtClientNumber.Text;

            var ClientsFound = from DataRow house in tabHouses.Rows
                            where house.Field<String>("clientId") == id
                            //select emp;
                            select new
                            {
                                Address = house.Field<String>("address"),
                                Status = house.Field<String>("status"),
                                Price = house.Field<Decimal>("price"),
                                ClientId = house.Field<String>("clientId")

                            };
            if (ClientsFound.Count() != 0)
            {

                

                gridHouses.DataSource = ClientsFound.ToList();

            }
            else { gridHouses.DataSource = null; }
        }

      
    }
    
}
