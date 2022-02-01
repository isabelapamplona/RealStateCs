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
    public partial class frmRemax : Form
    {
        public frmRemax()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            
            frmSearch search = new frmSearch();
            search.ShowDialog();
            Close();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            Close();
        }
    }
}
