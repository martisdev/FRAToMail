namespace FRAToMail
{
    partial class FrmLogin
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
            this.metroProgressConnect = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroTileOK = new MetroFramework.Controls.MetroTile();
            this.metroLinkVersion = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // metroProgressConnect
            // 
            this.metroProgressConnect.Location = new System.Drawing.Point(132, 50);
            this.metroProgressConnect.Maximum = 100;
            this.metroProgressConnect.Name = "metroProgressConnect";
            this.metroProgressConnect.Size = new System.Drawing.Size(139, 133);
            this.metroProgressConnect.TabIndex = 0;
            this.metroProgressConnect.UseSelectable = true;
            // 
            // metroTileOK
            // 
            this.metroTileOK.ActiveControl = null;
            this.metroTileOK.Location = new System.Drawing.Point(111, 96);
            this.metroTileOK.Name = "metroTileOK";
            this.metroTileOK.Size = new System.Drawing.Size(192, 53);
            this.metroTileOK.TabIndex = 1;
            this.metroTileOK.Text = "OK";
            this.metroTileOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileOK.UseSelectable = true;
            this.metroTileOK.Visible = false;
            this.metroTileOK.Click += new System.EventHandler(this.metroTileOK_Click);
            // 
            // metroLinkVersion
            // 
            this.metroLinkVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLinkVersion.Location = new System.Drawing.Point(2, 171);
            this.metroLinkVersion.Name = "metroLinkVersion";
            this.metroLinkVersion.Size = new System.Drawing.Size(172, 15);
            this.metroLinkVersion.TabIndex = 50;
            this.metroLinkVersion.Text = "Versió: 1.0.0";
            this.metroLinkVersion.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroLinkVersion.UseSelectable = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 189);
            this.Controls.Add(this.metroLinkVersion);
            this.Controls.Add(this.metroTileOK);
            this.Controls.Add(this.metroProgressConnect);
            this.Name = "FrmLogin";
            this.Text = "Comprovant les seves credencials";
            this.Shown += new System.EventHandler(this.FrmLogin_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner metroProgressConnect;
        private MetroFramework.Controls.MetroTile metroTileOK;
        private MetroFramework.Controls.MetroLink metroLinkVersion;
    }
}