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
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }
        DataSet myset;
        DataTable tabHouses, tabEmployees;
        OleDbDataAdapter adpHouses;
        OleDbConnection mycon;
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            //myset = new DataSet();
            //mycon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bela_\source\repos\420-DA3-AS\prjFinalProjectPartI\prjFinalProjectPartII\remaxDB.mdb;Persist Security Info=True");

            //mycon.Open();

            //OleDbCommand mycmd = new OleDbCommand("SELECT * FROM houses", mycon);
            //adpHouses = new OleDbDataAdapter(mycmd);
            //adpHouses.Fill(myset, "houses");

            //tabHouses = myset.Tables["houses"];

            gridResult.DataSource = tabHouses;

            mycon.Close();
        }

        private void btnSearchHouse_Click(object sender, EventArgs e)
        {
            string id = txtHouseId.Text;

            var HousesFound = from DataRow house in tabHouses.Rows
                               where house.Field<String>("HouseId") == id
                               
                               select new
                               {
                                   Address = house.Field<String>("address"),
                                   Status = house.Field<String>("status"),
                                   Price = house.Field<Decimal>("price"),
                                   ClientId = house.Field<String>("clientId")

                               };
            if (HousesFound.Count() != 0)
            {
                gridResult.DataSource = HousesFound.ToList();

            }
            else { gridResult.DataSource = null; }
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            myset = new DataSet();
            mycon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bela_\source\repos\420-DA3-AS\prjFinalProjectPartI\prjFinalProjectPartII\remaxDB.mdb;Persist Security Info=True");

            mycon.Open();

            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM houses", mycon);
            adpHouses = new OleDbDataAdapter(mycmd);
            adpHouses.Fill(myset, "houses");

            string val = "agent";
            mycmd = new OleDbCommand("SELECT * FROM employees WHERE empPosition = '" + val + "'", mycon);
            OleDbDataAdapter adpEmployees = new OleDbDataAdapter(mycmd);
            adpEmployees.Fill(myset, "employees");

            tabEmployees = myset.Tables["employees"];

            tabHouses = myset.Tables["houses"];
        }

        private void btnSearchAgent_Click(object sender, EventArgs e)
        {
            string id = txtAgentId.Text;

            var AgentsFound = from DataRow agent in tabEmployees.Rows
                              where agent.Field<String>("empId") == id

                              select new
                              {
                                  Name = agent.Field<String>("empName"),
                                  Phone = agent.Field<String>("empPhone"),
                                  Position = agent.Field<String>("empPosition"),
                              };

            if (AgentsFound.Count() != 0)
            {
                gridResult.DataSource = AgentsFound.ToList();

            }
            else { gridResult.DataSource = null; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit?", "Processing", MessageBoxButtons.YesNo).ToString() == "Yes")
                Close();
        }

        private void btnListAgents_Click(object sender, EventArgs e)
        {
      
            gridResult.DataSource = tabEmployees;

            mycon.Close();
        }
    }
}
