using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjFinalProjectPartII
{
    public partial class frmManagement : Form
    {
        public frmManagement()
        {
            InitializeComponent();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            frmEmployees employee = new frmEmployees();
            employee.ShowDialog();
            this.Close();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            frmClients client = new frmClients();
            client.ShowDialog();
            this.Close();
        }

        private void btnHouses_Click(object sender, EventArgs e)
        {
            frmHouses house = new frmHouses();
            house.ShowDialog();
            this.Close();
        }
    }
}
