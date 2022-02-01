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
    public partial class frmClients : Form
    {
        public frmClients()
        {
            InitializeComponent();
        }
        DataSet myset;
        DataTable tabClients, tabAgents;
        OleDbDataAdapter adpClients;
        OleDbConnection mycon;
        int currentposition;
        string mode = "";

        private void frmClients_Load(object sender, EventArgs e)
        {
            myset = new DataSet();
            mycon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bela_\source\repos\420-DA3-AS\prjFinalProjectPartI\prjFinalProjectPartI\remaxDB.mdb;Persist Security Info=True");
            mycon.Open();

            OleDbCommand mycmd = new OleDbCommand("SELECT empId, empName FROM employees", mycon);
            OleDbDataAdapter myadp = new OleDbDataAdapter(mycmd);
            myadp.Fill(myset, "agents");

            mycmd = new OleDbCommand("SELECT * FROM clients", mycon);
            adpClients = new OleDbDataAdapter(mycmd);
            adpClients.Fill(myset, "clients1");

            tabClients = myset.Tables["clients1"];
            tabAgents = myset.Tables["agents"];

            lbllnfo.Text = "--- CONSULT MODE ---";
            FillComboWithAgents();
            Display();

           mycon.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit?", "Processing", MessageBoxButtons.YesNo).ToString() == "Yes")
                Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Display()
        {
            txtClientId.Text = tabClients.Rows[currentposition]["clientId"].ToString();
            txtClientName.Text = tabClients.Rows[currentposition]["clientName"].ToString();
            txtClientEmail.Text = tabClients.Rows[currentposition]["clientEmail"].ToString();
            txtClientPhone.Text = tabClients.Rows[currentposition]["clientPhone"].ToString();
            txtClientStatus.Text = tabClients.Rows[currentposition]["clientStatus"].ToString();
            cboAgentNo.Text = tabClients.Rows[currentposition]["agentNumber"].ToString();

            int referAgent = Convert.ToInt32(tabClients.Rows[currentposition]["agentNumber"]);
            cboAgentNo.SelectedValue = referAgent;
            lbllnfo.Text = "Client " + (currentposition + 1) + " on a total of " + tabClients.Rows.Count;
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
            if (currentposition < (tabClients.Rows.Count - 1))
            {
                currentposition++;
                Display();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentposition = tabClients.Rows.Count - 1;
            Display();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtClientId.Text = "Auto Number";
            txtClientName.Text = txtClientEmail.Text = txtClientPhone.Text = txtClientStatus.Text = "";
            txtClientName.Focus();
            cboAgentNo.Text = "Select an Agent";
            lbllnfo.Text = "--- ADDING MODE ---";
            mode = "add";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtClientName.Focus();
            lbllnfo.Text = "--- EDITING MODE ---";
            mode = "edit";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtClientName.Text.Trim();
            string email = txtClientEmail.Text.Trim();
            string phone = txtClientPhone.Text.Trim();
            string stat = txtClientStatus.Text.Trim();
            int refAgent = Convert.ToInt32(cboAgentNo.SelectedValue);

           
            DataRow myrow = (mode == "add") ? tabClients.NewRow() : tabClients.Rows[currentposition];

            myrow["clientName"] = name;
            myrow["clientEmail"] = email;
            myrow["clientPhone"] = phone;
            myrow["clientStatus"] = stat;
            myrow["agentNumber"] = refAgent;
            
            if (mode == "add")
            {
                tabClients.Rows.Add(myrow);
                currentposition = tabClients.Rows.Count - 1;
            }

            OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(adpClients);
            adpClients.Update(myset, "clients1");
            myset.Tables.Remove("clients1");
            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM clients", mycon);
            adpClients = new OleDbDataAdapter(mycmd);
            adpClients.Fill(myset, "clients1");
            tabClients = myset.Tables["clients1"];

            mode = "";
            Display();


            lbllnfo.Text = "--- SAVING MODE ---";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure to delete this client? ";
            string title = "Warning: Employee Deleted!";
            if (MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                tabClients.Rows[currentposition].Delete();

                OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(adpClients);
                adpClients.Update(myset, "clients1");

                myset.Tables.Remove("clients1");
                OleDbCommand mycmd = new OleDbCommand("SELECT * FROM clients", mycon);
                adpClients = new OleDbDataAdapter(mycmd);
                adpClients.Fill(myset, "clients1");
                tabClients = myset.Tables["clients1"];

                currentposition = 0;
                Display();
            }
        }

        private void gridClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FillComboWithAgents()
        {
            cboAgentNo.DisplayMember = "empName";
            cboAgentNo.ValueMember = "ID";
            cboAgentNo.DataSource = tabAgents;
        }


    }
}
