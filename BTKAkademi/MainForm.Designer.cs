namespace BTKAkademi
{
    partial class MainForm
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
            this.bntExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnSqlAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnSqlUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnSqlDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnOracleAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnOracleUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnOracleDelete = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // bntExit
            // 
            this.bntExit.Location = new System.Drawing.Point(1139, 399);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(94, 29);
            this.bntExit.TabIndex = 0;
            this.bntExit.Text = "Kapa";
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(31, 23);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(136, 29);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(31, 80);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(136, 29);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            // 
            // btnSqlAdd
            // 
            this.btnSqlAdd.Location = new System.Drawing.Point(397, 23);
            this.btnSqlAdd.Name = "btnSqlAdd";
            this.btnSqlAdd.Size = new System.Drawing.Size(185, 29);
            this.btnSqlAdd.TabIndex = 3;
            this.btnSqlAdd.Text = "Sql Server Ekle";
            this.btnSqlAdd.Click += new System.EventHandler(this.btnSqlAdd_Click);
            // 
            // btnSqlUpdate
            // 
            this.btnSqlUpdate.Location = new System.Drawing.Point(397, 80);
            this.btnSqlUpdate.Name = "btnSqlUpdate";
            this.btnSqlUpdate.Size = new System.Drawing.Size(185, 29);
            this.btnSqlUpdate.TabIndex = 4;
            this.btnSqlUpdate.Text = "Sql Server Güncelle";
            this.btnSqlUpdate.Click += new System.EventHandler(this.btnSqlUpdate_Click);
            // 
            // btnSqlDelete
            // 
            this.btnSqlDelete.Location = new System.Drawing.Point(397, 132);
            this.btnSqlDelete.Name = "btnSqlDelete";
            this.btnSqlDelete.Size = new System.Drawing.Size(185, 29);
            this.btnSqlDelete.TabIndex = 5;
            this.btnSqlDelete.Text = "Sql Server Sil";
            this.btnSqlDelete.Click += new System.EventHandler(this.btnSqlDelete_Click);
            // 
            // btnOracleAdd
            // 
            this.btnOracleAdd.Location = new System.Drawing.Point(622, 23);
            this.btnOracleAdd.Name = "btnOracleAdd";
            this.btnOracleAdd.Size = new System.Drawing.Size(185, 29);
            this.btnOracleAdd.TabIndex = 6;
            this.btnOracleAdd.Text = "Oracle Server Ekle";
            this.btnOracleAdd.Click += new System.EventHandler(this.btnOracleAdd_Click);
            // 
            // btnOracleUpdate
            // 
            this.btnOracleUpdate.Location = new System.Drawing.Point(622, 80);
            this.btnOracleUpdate.Name = "btnOracleUpdate";
            this.btnOracleUpdate.Size = new System.Drawing.Size(185, 29);
            this.btnOracleUpdate.TabIndex = 7;
            this.btnOracleUpdate.Text = "Oracle Server Güncelle";
            this.btnOracleUpdate.Click += new System.EventHandler(this.btnOracleUpdate_Click);
            // 
            // btnOracleDelete
            // 
            this.btnOracleDelete.Location = new System.Drawing.Point(622, 132);
            this.btnOracleDelete.Name = "btnOracleDelete";
            this.btnOracleDelete.Size = new System.Drawing.Size(185, 29);
            this.btnOracleDelete.TabIndex = 8;
            this.btnOracleDelete.Text = "Oracle Server Sil";
            this.btnOracleDelete.Click += new System.EventHandler(this.btnOracleDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 450);
            this.Controls.Add(this.btnOracleDelete);
            this.Controls.Add(this.btnOracleUpdate);
            this.Controls.Add(this.btnOracleAdd);
            this.Controls.Add(this.btnSqlDelete);
            this.Controls.Add(this.btnSqlUpdate);
            this.Controls.Add(this.btnSqlAdd);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.bntExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bntExit;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnSqlAdd;
        private DevExpress.XtraEditors.SimpleButton btnSqlUpdate;
        private DevExpress.XtraEditors.SimpleButton btnSqlDelete;
        private DevExpress.XtraEditors.SimpleButton btnOracleAdd;
        private DevExpress.XtraEditors.SimpleButton btnOracleUpdate;
        private DevExpress.XtraEditors.SimpleButton btnOracleDelete;
    }
}

