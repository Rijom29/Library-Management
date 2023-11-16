namespace LibraryMangement
{
    partial class FormReturnBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAvaliableQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtBId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReturnConfirm = new System.Windows.Forms.Button();
            this.txtRQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReturnBook = new System.Windows.Forms.DataGridView();
            this.btnReturnClose = new System.Windows.Forms.Button();
            this.bname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtAvaliableQuantity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.txtBId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnReturnConfirm);
            this.panel1.Controls.Add(this.txtRQuantity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSearchByName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvReturnBook);
            this.panel1.Controls.Add(this.btnReturnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 16;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(563, 190);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(92, 28);
            this.btnPrevious.TabIndex = 34;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "(Double click the book from the list)";
            // 
            // txtAvaliableQuantity
            // 
            this.txtAvaliableQuantity.Location = new System.Drawing.Point(203, 181);
            this.txtAvaliableQuantity.Name = "txtAvaliableQuantity";
            this.txtAvaliableQuantity.ReadOnly = true;
            this.txtAvaliableQuantity.Size = new System.Drawing.Size(98, 22);
            this.txtAvaliableQuantity.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Avaliable Quantity";
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(679, 137);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(87, 28);
            this.btnShow.TabIndex = 25;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtBId
            // 
            this.txtBId.Location = new System.Drawing.Point(203, 87);
            this.txtBId.Name = "txtBId";
            this.txtBId.ReadOnly = true;
            this.txtBId.Size = new System.Drawing.Size(98, 22);
            this.txtBId.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Book ID";
            // 
            // btnReturnConfirm
            // 
            this.btnReturnConfirm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnConfirm.Location = new System.Drawing.Point(563, 137);
            this.btnReturnConfirm.Name = "btnReturnConfirm";
            this.btnReturnConfirm.Size = new System.Drawing.Size(92, 28);
            this.btnReturnConfirm.TabIndex = 22;
            this.btnReturnConfirm.Text = "Confirm";
            this.btnReturnConfirm.UseVisualStyleBackColor = true;
            this.btnReturnConfirm.Click += new System.EventHandler(this.btnReturnConfirm_Click);
            // 
            // txtRQuantity
            // 
            this.txtRQuantity.Location = new System.Drawing.Point(203, 119);
            this.txtRQuantity.Name = "txtRQuantity";
            this.txtRQuantity.Size = new System.Drawing.Size(98, 22);
            this.txtRQuantity.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Quantity of return book";
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(13, 41);
            this.txtSearchByName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(400, 22);
            this.txtSearchByName.TabIndex = 17;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Search by name";
            // 
            // dgvReturnBook
            // 
            this.dgvReturnBook.AllowUserToAddRows = false;
            this.dgvReturnBook.AllowUserToDeleteRows = false;
            this.dgvReturnBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bname,
            this.bid,
            this.bquantity});
            this.dgvReturnBook.Location = new System.Drawing.Point(3, 243);
            this.dgvReturnBook.Name = "dgvReturnBook";
            this.dgvReturnBook.ReadOnly = true;
            this.dgvReturnBook.RowHeadersWidth = 51;
            this.dgvReturnBook.RowTemplate.Height = 24;
            this.dgvReturnBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnBook.Size = new System.Drawing.Size(794, 195);
            this.dgvReturnBook.TabIndex = 15;
            this.dgvReturnBook.DoubleClick += new System.EventHandler(this.dgvReturnBook_DoubleClick);
            // 
            // btnReturnClose
            // 
            this.btnReturnClose.AccessibleName = "";
            this.btnReturnClose.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnClose.Location = new System.Drawing.Point(672, 190);
            this.btnReturnClose.Name = "btnReturnClose";
            this.btnReturnClose.Size = new System.Drawing.Size(94, 28);
            this.btnReturnClose.TabIndex = 14;
            this.btnReturnClose.Text = "Close";
            this.btnReturnClose.UseVisualStyleBackColor = true;
            this.btnReturnClose.Click += new System.EventHandler(this.btnReturnClose_Click);
            // 
            // bname
            // 
            this.bname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bname.DataPropertyName = "bname";
            this.bname.HeaderText = "Name";
            this.bname.MinimumWidth = 6;
            this.bname.Name = "bname";
            this.bname.ReadOnly = true;
            // 
            // bid
            // 
            this.bid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bid.DataPropertyName = "bid";
            this.bid.HeaderText = "Id";
            this.bid.MinimumWidth = 6;
            this.bid.Name = "bid";
            this.bid.ReadOnly = true;
            // 
            // bquantity
            // 
            this.bquantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bquantity.DataPropertyName = "bquantity";
            this.bquantity.HeaderText = "Quantity";
            this.bquantity.MinimumWidth = 6;
            this.bquantity.Name = "bquantity";
            this.bquantity.ReadOnly = true;
            // 
            // FormReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormReturnBook";
            this.Text = "BookReturn";
            this.Load += new System.EventHandler(this.FormReturnBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAvaliableQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtBId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReturnConfirm;
        private System.Windows.Forms.TextBox txtRQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReturnBook;
        private System.Windows.Forms.Button btnReturnClose;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.DataGridViewTextBoxColumn bname;
        private System.Windows.Forms.DataGridViewTextBoxColumn bid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bquantity;
    }
}