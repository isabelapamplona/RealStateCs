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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblInfoEmp_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit?", "Processing", MessageBoxButtons.YesNo).ToString() == "Yes")
                Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string phone;
            phone = txtPhone.Text.Trim(); 
            string pass;
            pass = txtPassword.Text.Trim();
            
            OleDbConnection mycon;
            mycon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bela_\source\repos\420-DA3-AS\prjFinalProjectPartI\prjFinalProjectPartI\remaxDB.mdb;Persist Security Info=True");
            mycon.Open();
            string sql = "SELECT empPhone, [empPin] FROM employees WHERE empPhone = '" + phone + "' AND [empPin] = '" + pass + "'";
            OleDbCommand myCmd = new OleDbCommand(sql, mycon);
            OleDbDataReader myRder = myCmd.ExecuteReader();
            if (myRder.Read())
            {
                this.Hide();
                frmManagement manage = new frmManagement();
                manage.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect credentials. Try again.");
                txtPhone.Clear();
                txtPassword.Clear();
                txtPhone.Focus();
            }

           // this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPhone.Focus();
            txtPhone.Text = "";
            txtPassword.Text = "";
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
