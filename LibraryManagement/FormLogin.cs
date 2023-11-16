using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryMangement
{
    public partial class FormLogin : Form
    {
        private DataAccess Da { get; set; }
        public FormLogin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string query = "select * from login where id = '" + this.txtUserID.Text + "' and password = '" + this.txtPassword.Text + "' and type = 'admin'";
            string query1 = "select * from login where id = '" + this.txtUserID.Text + "' and password = '" + this.txtPassword.Text + "' and type = 'librarian'";


            var ds = this.Da.ExecuteQuery(query);
            var ds1 = this.Da.ExecuteQuery(query1);

            if (ds.Tables[0].Rows.Count == 1)
            {
               //MessageBox.Show("Login Confirmed");
                FormAdmin f2 = new FormAdmin();
                f2.Visible = true;
                this.Visible = false;
            }

           else if (ds1.Tables[0].Rows.Count == 1)
            {
                //MessageBox.Show("Login Confirmed");
                FormLibrarian f3 = new FormLibrarian();
                f3.Visible = true;
                this.Visible = false;
            }

            else
                MessageBox.Show("Login Failed!");
        }
       
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUserID.Clear();
            this.txtPassword.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
