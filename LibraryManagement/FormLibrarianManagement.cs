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
    public partial class FormLibrarianManagement : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public FormLibrarianManagement()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from Librarian;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvLibrarian.AutoGenerateColumns = false;
            this.dgvLibrarian.DataSource = ds.Tables[0];
        }
       
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtLibrarianId.Text) || 
                String.IsNullOrEmpty(this.txtLibrarianName.Text))

            {
                return false;
            }
            else
                return true;
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            {
                try
                {
                    string sql = "select * from Librarian where Name = '" + this.txtSearchByName.Text + "';";
                    this.PopulateGridView(sql);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("An error has occured: " + exc.Message);
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            this.RefreshContent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var name = this.dgvLibrarian.CurrentRow.Cells[0].Value.ToString();
                var id = this.dgvLibrarian.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from Librarian where id = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name + " has been deleted successfully");
                else
                    MessageBox.Show("Data deletion failed");

                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void dgvLibrarian_DoubleClick(object sender, EventArgs e)
        {
            this.txtLibrarianName.Text = this.dgvLibrarian.CurrentRow.Cells["name"].Value.ToString();
            this.txtLibrarianId.Text = this.dgvLibrarian.CurrentRow.Cells["id"].Value.ToString();
            this.dtpJoiningDate.Text = this.dgvLibrarian.CurrentRow.Cells["joiningdate"].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSaveData())
                {
                    MessageBox.Show("Invalid opration. Please fill up all the information");
                    return;
                }

                var query = "select * from Librarian where id = '" + this.txtLibrarianId.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    var sql = @"update Librarian
                                set name = '" + this.txtLibrarianName.Text + @"',
                                joiningdate= '" + this.dtpJoiningDate.Text + @"'
                                where id = '" + this.txtLibrarianId.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated successfully");
                    else
                        MessageBox.Show("Data upgradation failed");
                }
                
                else
                {
                    //insert
                    var sql = @"insert into Librarian values('" + this.txtLibrarianName.Text + "','" + this.txtLibrarianId.Text + "',' " + this.dtpJoiningDate.Text + "');";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data insertion successfull");
                    else
                        MessageBox.Show("Data insertion failed");
                }

                this.PopulateGridView();
                this.RefreshContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
        private void RefreshContent()
        {
    
            this.txtLibrarianName.Clear();
            this.txtLibrarianId.Clear();
            this.dtpJoiningDate.Text = "";


        }

        private void FormLibrarianManagement_Load(object sender, EventArgs e)
        {
            this.dgvLibrarian.ClearSelection();
            this.AutoId();
        }
        private void AutoId()
        {
            var sql = "select * from Librarian order by id desc;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);

            string lastid = dt.Rows[0][1].ToString();
            string[] temp = lastid.Split('-');
            int no = Convert.ToInt32(temp[1]);
            string newId = "22-" + (++no).ToString("d3")+"-2";
            this.txtLibrarianId.Text = newId;
            //MessageBox.Show(newId);
        }

        private void btnLmClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAdmin fd = new FormAdmin();
            fd.Show();
        }
    }
}

