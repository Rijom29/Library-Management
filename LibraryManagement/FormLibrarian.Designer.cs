namespace LibraryMangement
{
    partial class FormLibrarian
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReceiveBook = new System.Windows.Forms.Button();
            this.btnGivenBook = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Librarian";
            // 
            // btnLClose
            // 
            this.btnLClose.AccessibleName = "btnlClose";
            this.btnLClose.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLClose.Location = new System.Drawing.Point(460, 331);
            this.btnLClose.Name = "btnLClose";
            this.btnLClose.Size = new System.Drawing.Size(94, 28);
            this.btnLClose.TabIndex = 13;
            this.btnLClose.Text = "Close";
            this.btnLClose.UseVisualStyleBackColor = true;
            this.btnLClose.Click += new System.EventHandler(this.btnLClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnReceiveBook);
            this.panel1.Controls.Add(this.btnGivenBook);
            this.panel1.Controls.Add(this.btnLClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 424);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Choose your option! Which operation you want?";
            // 
            // btnReceiveBook
            // 
            this.btnReceiveBook.AccessibleName = "";
            this.btnReceiveBook.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceiveBook.Location = new System.Drawing.Point(52, 252);
            this.btnReceiveBook.Name = "btnReceiveBook";
            this.btnReceiveBook.Size = new System.Drawing.Size(191, 28);
            this.btnReceiveBook.TabIndex = 15;
            this.btnReceiveBook.Text = " Book Return";
            this.btnReceiveBook.UseVisualStyleBackColor = true;
            this.btnReceiveBook.Click += new System.EventHandler(this.btnReceiveBook_Click);
            // 
            // btnGivenBook
            // 
            this.btnGivenBook.AccessibleName = "";
            this.btnGivenBook.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGivenBook.Location = new System.Drawing.Point(52, 188);
            this.btnGivenBook.Name = "btnGivenBook";
            this.btnGivenBook.Size = new System.Drawing.Size(191, 28);
            this.btnGivenBook.TabIndex = 14;
            this.btnGivenBook.Text = " Book Issue";
            this.btnGivenBook.UseVisualStyleBackColor = true;
            this.btnGivenBook.Click += new System.EventHandler(this.btnGivenBook_Click);
            // 
            // FormLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 429);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cooper Black", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FormLibrarian";
            this.Text = "Librarian";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReceiveBook;
        private System.Windows.Forms.Button btnGivenBook;
        private System.Windows.Forms.Label label2;
    }
}