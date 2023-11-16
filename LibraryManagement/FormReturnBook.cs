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
    public partial class FormReturnBook : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public FormReturnBook()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Book where bname = '" + this.txtSearchByName.Text + "';";
                this.PopulateGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
        private void PopulateGridView(string sql = "select * from Book;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvReturnBook.AutoGenerateColumns = false;
            this.dgvReturnBook.DataSource = ds.Tables[0];
        }
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtBId.Text))
                

            {
                return false;
            }
            else
                return true;
        }

        private void btnReturnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSaveData())
                {
                    MessageBox.Show("Invalid opration. Please fill up all the information");
                    return;
                }
                var query = "select * from Book where bid = '" + this.txtBId.Text + "';";

                var ds = this.Da.ExecuteQuery(query);  

                if (ds.Tables[0].Rows.Count == 1)
                {

                    int txt1 = Convert.ToInt32(txtRQuantity.Text);
                    int txt2 = Convert.ToInt32(txtAvaliableQuantity.Text);
                    int sum = txt2 + txt1;
                    txtAvaliableQuantity.Text = sum.ToString();
                    //update
                    var sql = @"update Book
                                set bquantity = '" + this.txtAvaliableQuantity.Text + @"'
                                where bid = '" + this.txtBId.Text + "';";

                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated successfully");
                    else
                        MessageBox.Show("Data upgradation failed");



                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
            this.PopulateGridView();
            this.RefreshContent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();

        }

        private void dgvReturnBook_DoubleClick(object sender, EventArgs e)
        {
            this.txtBId.Text = this.dgvReturnBook.CurrentRow.Cells["bid"].Value.ToString();

            this.txtAvaliableQuantity.Text = this.dgvReturnBook.CurrentRow.Cells["bquantity"].Value.ToString();

        }

        private void FormReturnBook_Load(object sender, EventArgs e)
        {
            this.dgvReturnBook.ClearSelection();
        }

        private void btnReturnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLibrarian fl = new FormLibrarian();
            fl.Show();
        }
        private void RefreshContent()
        {

            this.txtAvaliableQuantity.Clear();
            this.txtBId.Clear();
            this.txtRQuantity.Clear();

        }
    }
}
