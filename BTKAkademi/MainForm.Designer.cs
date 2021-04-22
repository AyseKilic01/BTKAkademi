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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnServer = new DevExpress.XtraEditors.SimpleButton();
            this.bntExit = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnServer
            // 
            this.btnServer.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnServer.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnServer.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnServer.Appearance.Options.UseBackColor = true;
            this.btnServer.Appearance.Options.UseFont = true;
            this.btnServer.Appearance.Options.UseForeColor = true;
            this.btnServer.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnServer.Location = new System.Drawing.Point(31, 23);
            this.btnServer.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnServer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(244, 29);
            this.btnServer.TabIndex = 1;
            this.btnServer.Text = "Server Yönetime Git";
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // bntExit
            // 
            this.bntExit.Appearance.BackColor = System.Drawing.Color.LightCoral;
            this.bntExit.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bntExit.Appearance.ForeColor = System.Drawing.Color.White;
            this.bntExit.Appearance.Options.UseBackColor = true;
            this.bntExit.Appearance.Options.UseFont = true;
            this.bntExit.Appearance.Options.UseForeColor = true;
            this.bntExit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.bntExit.Location = new System.Drawing.Point(1092, 389);
            this.bntExit.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.bntExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(153, 29);
            this.bntExit.TabIndex = 13;
            this.bntExit.Text = "Kapa";
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 450);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.btnServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnServer;
        private DevExpress.XtraEditors.SimpleButton bntExit;
    }
}

