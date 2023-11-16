namespace LibraryMangement
{
    partial class FormBookIssue
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
            this.btnGBClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAvaliableQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtBId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGivenConfirm = new System.Windows.Forms.Button();
            this.txtGBQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGivenBook = new System.Windows.Forms.DataGridView();
            this.bname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGivenBook)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGBClose
            // 
            this.btnGBClose.AccessibleName = "btnlClose";
            this.btnGBClose.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGBClose.Location = new System.Drawing.Point(672, 190);
            this.btnGBClose.Name = "btnGBClose";
            this.btnGBClose.Size = new System.Drawing.Size(94, 28);
            this.btnGBClose.TabIndex = 14;
            this.btnGBClose.Text = "Close";
            this.btnGBClose.UseVisualStyleBackColor = true;
            this.btnGBClose.Click += new System.EventHandler(this.btnGBClose_Click);
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
            this.panel1.Controls.Add(this.btnGivenConfirm);
            this.panel1.Controls.Add(this.txtGBQuantity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSearchByName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvGivenBook);
            this.panel1.Controls.Add(this.btnGBClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 15;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(574, 191);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(92, 28);
            this.btnPrevious.TabIndex = 35;
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
            this.btnShow.Location = new System.Drawing.Point(679, 133);
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
            // btnGivenConfirm
            // 
            this.btnGivenConfirm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGivenConfirm.Location = new System.Drawing.Point(574, 133);
            this.btnGivenConfirm.Name = "btnGivenConfirm";
            this.btnGivenConfirm.Size = new System.Drawing.Size(92, 28);
            this.btnGivenConfirm.TabIndex = 22;
            this.btnGivenConfirm.Text = "Confirm";
            this.btnGivenConfirm.UseVisualStyleBackColor = true;
            this.btnGivenConfirm.Click += new System.EventHandler(this.btnGivenConfirm_Click);
            // 
            // txtGBQuantity
            // 
            this.txtGBQuantity.Location = new System.Drawing.Point(203, 119);
            this.txtGBQuantity.Name = "txtGBQuantity";
            this.txtGBQuantity.Size = new System.Drawing.Size(98, 22);
            this.txtGBQuantity.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Quantity of issue book";
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
            // dgvGivenBook
            // 
            this.dgvGivenBook.AllowUserToAddRows = false;
            this.dgvGivenBook.AllowUserToDeleteRows = false;
            this.dgvGivenBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGivenBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bname,
            this.bid,
            this.bquantity});
            this.dgvGivenBook.Location = new System.Drawing.Point(3, 243);
            this.dgvGivenBook.Name = "dgvGivenBook";
            this.dgvGivenBook.ReadOnly = true;
            this.dgvGivenBook.RowHeadersWidth = 51;
            this.dgvGivenBook.RowTemplate.Height = 24;
            this.dgvGivenBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGivenBook.Size = new System.Drawing.Size(794, 195);
            this.dgvGivenBook.TabIndex = 15;
            this.dgvGivenBook.DoubleClick += new System.EventHandler(this.dgvGivenBook_DoubleClick);
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
            // FormBookIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormBookIssue";
            this.Text = "BookIssue";
            this.Load += new System.EventHandler(this.FormGivenBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGivenBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGBClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGivenBook;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGBQuantity;
        private System.Windows.Forms.Button btnGivenConfirm;
        private System.Windows.Forms.TextBox txtBId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtAvaliableQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.DataGridViewTextBoxColumn bname;
        private System.Windows.Forms.DataGridViewTextBoxColumn bid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bquantity;
    }
}