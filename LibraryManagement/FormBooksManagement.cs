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
    public partial class FormBooksManagement : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public FormBooksManagement()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from Book;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvBook.AutoGenerateColumns = false;
            this.dgvBook.DataSource = ds.Tables[0];
        }

        private void btnBmClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtBookId.Text) ||
                String.IsNullOrEmpty(this.txtBookName.Text) ||
                String.IsNullOrEmpty(this.txtBookQuantity.Text))

            {
                return false;
            }
            else
                return true;
        }


        private void btnBookSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSaveData())
                {
                    MessageBox.Show("Invalid opration. Please fill up all the information");
                    return;
                }

                var query = "select * from Book where bid = '" + this.txtBookId.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    var sql = @"update Book
                                set bname = '" + this.txtBookName.Text + @"',
                                bquantity = '" + this.txtBookQuantity.Text + @"'
                                where bid = '" + this.txtBookId.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated successfully");
                    else
                        MessageBox.Show("Data upgradation failed");
                }
                else
                {
                    //insert
                    var sql = @"insert into Book values('" + this.txtBookName.Text + "','" + this.txtBookId.Text + "',' " + this.txtBookQuantity.Text + "');";
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

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                var bname = this.dgvBook.CurrentRow.Cells[0].Value.ToString();
                var bid = this.dgvBook.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from Book where bid = '" + bid + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(bname + " has been deleted successfully");
                else
                    MessageBox.Show("Data deletion failed");

                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }

        }

        private void txtBookSearch_TextChanged(object sender, EventArgs e)
        {
            {
                try
                {
                    string sql = "select * from Book where bname = '" + this.txtBookSearch.Text + "';";
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void FormBooksManagement_Load(object sender, EventArgs e)
        {
            this.dgvBook.ClearSelection();
            this.AutoId();

        }

        private void dgvBook_DoubleClick(object sender, EventArgs e)
        {
            this.txtBookName.Text = this.dgvBook.CurrentRow.Cells["bname"].Value.ToString();
            this.txtBookId.Text = this.dgvBook.CurrentRow.Cells["bid"].Value.ToString();
            this.txtBookQuantity.Text = this.dgvBook.CurrentRow.Cells["bquantity"].Value.ToString();
        }
        private void RefreshContent()
        {
            this.txtBookName.Clear();
            this.txtBookId.Clear();
            this.txtBookQuantity.Clear();
        }
        private void AutoId()
        {
            var sql = "select * from Book order by bid desc;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);

            string lastid = dt.Rows[0][1].ToString();
            string[] temp = lastid.Split('-');
            int no = Convert.ToInt32(temp[1]);
            string newId = "B-" + (++no).ToString("d3");
            this.txtBookId.Text = newId;
            //MessageBox.Show(newId);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAdmin fd = new FormAdmin();
            fd.Show();
        }

        
    }
}
