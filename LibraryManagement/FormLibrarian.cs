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
    public partial class FormLibrarian : Form
    {
        private FormLogin F1 { get; set; }
        private FormAdmin F2 { get; set; }
        private DataAccess Da { get; set; }
        public FormLibrarian()
        {
            InitializeComponent();
            this.Da = new DataAccess();

        }

        private void btnLClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGivenBook_Click(object sender, EventArgs e)
        {
            FormBookIssue fl = new FormBookIssue();
            fl.Visible = true;
            this.Visible = false;
        }

        private void btnReceiveBook_Click(object sender, EventArgs e)
        {
            FormReturnBook fl = new FormReturnBook();
            fl.Visible = true;
            this.Visible = false;
        }
    }
}
