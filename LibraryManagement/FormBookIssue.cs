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
    public partial class FormBookIssue : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public FormBookIssue()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from Book;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvGivenBook.AutoGenerateColumns = false;
            this.dgvGivenBook.DataSource = ds.Tables[0];
        }

        private void btnGBClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtBId.Text))
                

            {
                return false;
            }
            else
                return true;
        }


        private void btnGivenConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSaveData())
                {
                    MessageBox.Show("Invalid opration. Please fill up all the information");
                    return;
                }
                var query = "select * from Book where bid = '" + this.txtBId.Text + "';";
                string query1 = "select * from Book where bquantity = 0 and bid = '" + this.txtBId.Text + "';";
                var ds = this.Da.ExecuteQuery(query);
                var ds1 = this.Da.ExecuteQuery(query1);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    if (ds1.Tables[0].Rows.Count == 1)
                    {
                        MessageBox.Show("Book is not avaliable");
                    }
                    else
                    {
                        int txt1 = Convert.ToInt32(txtGBQuantity.Text);
                        int txt2 = Convert.ToInt32(txtAvaliableQuantity.Text);
                        int sum = txt2 - txt1;
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

        private void dgvGivenBook_DoubleClick(object sender, EventArgs e)
        {
            this.txtBId.Text = this.dgvGivenBook.CurrentRow.Cells["bid"].Value.ToString();
           
            this.txtAvaliableQuantity.Text = this.dgvGivenBook.CurrentRow.Cells["bquantity"].Value.ToString();
        }

        private void FormGivenBook_Load(object sender, EventArgs e)
        {
            this.dgvGivenBook.ClearSelection(); 
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
            this.txtGBQuantity.Clear();
          
        }
    }
        
}
