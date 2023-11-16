using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMangement
{
    
    public partial class FormAdmin : Form
    {
        private FormAdmin F1 { get; set; }
        private DataAccess Da { get; set; }
        public FormAdmin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnLibrarianManagement_Click(object sender, EventArgs e)
        {
            FormLibrarianManagement fl = new FormLibrarianManagement();
            fl.Visible = true;
            this.Visible = false;
        }
        private void btnBooksManagment_Click(object sender, EventArgs e)
        {
            FormBooksManagement fbm = new FormBooksManagement();
            fbm.Visible = true;
            this.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
