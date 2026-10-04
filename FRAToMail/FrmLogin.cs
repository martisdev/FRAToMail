using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Apis.Gmail.v1.GmailService;

namespace FRAToMail
{
    public partial class FrmLogin : MetroForm
    {
        
        public FrmLogin()
        {
            InitializeComponent();
            metroLinkVersion.Text = string.Format("Versió: {0}", Application.ProductVersion);
        }

        private async void FrmLogin_Shown(object sender, EventArgs e)
        {                        
            metroProgressConnect.Value = 1;
            metroProgressConnect.Refresh();
            Thread.Sleep(2);
            string ErrMsg = string.Empty;
            var ConnectTask = Task<Boolean>.Factory.StartNew(() => Connect(ref ErrMsg));
            await ConnectTask;
            if(!ConnectTask.Result)
            {
                MetroFramework.MetroMessageBox.Show(this, ErrMsg, "Error a la autentificació", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
            else
            {
                metroProgressConnect.Visible = false;
                metroTileOK.Visible = true;
            }            
        }

        private Boolean Connect(ref string ErrStr)
        {
            try
            {
                string clientId = "";
                string clientSecret = "";

                // Scopes for the Gmail API
                string[] scopes = { GmailService.Scope.GmailSend };

                // Path to the credentials file
                string strWorkPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                string CredentialPath = Path.Combine(strWorkPath, "data");

                Program.oAuthGmail = new OAuthGmail(clientId, clientSecret, scopes, CredentialPath, Program.APPLICATION_NAME);
            }
            catch (Exception ex)
            {
                ErrStr = ex.Message;
                return false;
            }
            return true;
        }

        private void metroTileOK_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}
