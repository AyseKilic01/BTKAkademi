namespace BTKAkademi.Forms
{
    partial class CityControl
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
            this.btnCity = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnCity
            // 
            this.btnCity.Location = new System.Drawing.Point(167, 113);
            this.btnCity.Name = "btnCity";
            this.btnCity.Size = new System.Drawing.Size(184, 29);
            this.btnCity.TabIndex = 0;
            this.btnCity.Text = "Şehirleri Çek";
            this.btnCity.Click += new System.EventHandler(this.btnCity_Click);
            // 
            // CityControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 536);
            this.Controls.Add(this.btnCity);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CityControl";
            this.Text = "CityControl";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCity;
    }
}