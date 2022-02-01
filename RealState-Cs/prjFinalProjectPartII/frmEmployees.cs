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
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }

       
        DataSet myset;
        DataTable tabClients, tabEmployees, tabHouses;
        OleDbDataAdapter adpEmployees;
        OleDbConnection mycon;
        int currentposition;
        string mode = "";
        private void frmEmployees_Load(object sender, EventArgs e)
        {
            myset = new DataSet();
            mycon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bela_\source\repos\420-DA3-AS\prjFinalProjectPartI\prjFinalProjectPartII\remaxDB.mdb;Persist Security Info=True");
            mycon.Open();                                                              

            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM employees", mycon);
            OleDbDataAdapter adpEmployees = new OleDbDataAdapter(mycmd);
            adpEmployees.Fill(myset, "employees");


            tabHouses = myset.Tables["houses"];
            tabClients = myset.Tables["clients"];
            tabEmployees = myset.Tables["employees"];

            gridEmp.DataSource = tabEmployees;

            lblInfo.Text = "--- CONSULT MODE ---";

            Display();
            
            mycon.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit?", "Processing", MessageBoxButtons.YesNo).ToString() == "Yes")
                Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentposition = 0;
            Display();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentposition > 0)
            {
                currentposition--;
                Display();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentposition < (tabEmployees.Rows.Count - 1))
            {
                currentposition++;
                Display();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentposition = tabEmployees.Rows.Count - 1;
            Display();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtEmpId.Text.Trim();
            string name = txtEmpName.Text.Trim();
            string phone = txtEmpPhone.Text.Trim();
            string pos = txtEmpPosition.Text.Trim();
            string pin = txtEmpPassword.Text.Trim();

            
            DataRow myrow = (mode == "add") ? tabEmployees.NewRow() : tabEmployees.Rows[currentposition];

            myrow["empId"] = id;
            myrow["empName"] = name;
            myrow["empPhone"] = phone;
            myrow["empPosition"] = pos;
            myrow["empPin"] = pin;

            if (mode == "add")
            {
                tabEmployees.Rows.Add(myrow);
                currentposition = tabEmployees.Rows.Count - 1;
            }

            OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(adpEmployees);
            adpEmployees.Update(myset, "employees");
            myset.Tables.Remove("employees");
            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM employees", mycon);
            adpEmployees = new OleDbDataAdapter(mycmd);
            adpEmployees.Fill(myset, "employees");
            tabEmployees = myset.Tables["employees"];

            mode = "";
            Display();


            lblInfo.Text = "--- SAVING MODE ---";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtEmpId.Text = "Auto Number";
            txtEmpName.Text = txtEmpPhone.Text = txtEmpPosition.Text = txtEmpPassword.Text = "";
            txtEmpName.Focus();
            lblInfo.Text = "--- ADDING MODE ---";
            mode = "add";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtEmpName.Focus();
            lblInfo.Text = "--- EDITING MODE ---";
            mode = "edit";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure to delete this employee? ";
            string title = "Warning: Employee Deleted!";
            if (MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                tabEmployees.Rows[currentposition].Delete();

                OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(adpEmployees);
                adpEmployees.Update(myset, "employees");
               
                myset.Tables.Remove("employees");
                OleDbCommand mycmd = new OleDbCommand("SELECT * FROM employees", mycon);
                adpEmployees = new OleDbDataAdapter(mycmd);
                adpEmployees.Fill(myset, "employees");
                tabEmployees = myset.Tables["employees"];

                currentposition = 0;
                Display();
            }
        }

        private void gridEmpClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Display()
        {
            txtEmpId.Text = tabEmployees.Rows[currentposition]["empId"].ToString();
            txtEmpName.Text = tabEmployees.Rows[currentposition]["empName"].ToString();
            txtEmpPhone.Text = tabEmployees.Rows[currentposition]["empPhone"].ToString();
            txtEmpPosition.Text = tabEmployees.Rows[currentposition]["empPosition"].ToString();
            txtEmpPassword.Text = tabEmployees.Rows[currentposition]["empPin"].ToString();

            gridEmp.DataSource = tabEmployees;

            lblInfo.Text = "Employee " + (currentposition + 1) + " on a total of " + tabEmployees.Rows.Count;

            
        }

       
    }
}