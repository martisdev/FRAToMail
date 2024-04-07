using MetroFramework.Forms;
using PdfSharp.Pdf;
using PdfSharp.Pdf.Content;
using PdfSharp.Pdf.Content.Objects;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mail;
using MimeKit;
using System.Text;
using System.Windows.Forms;
using Google.Apis.Gmail.v1;
using System.Text.RegularExpressions;


namespace FRAToMail
{
    public partial class FormMain : MetroForm
    {

        #region CONSTS
        
        const string APPLICATION_NAME = "FraToMail";
        #endregion

        #region PROPERTIES
        string NameMailFrom
        {
            get;
            set;
        }
        #endregion

        #region FIELDS

        string dir_output = "";

        DataTable dt_usuaris = new DataTable();

        Boolean CancelAction = false;
        #endregion

        #region CONSTRUCTOR

        public FormMain()
        {
            InitializeComponent();
            metroLinkVersion.Text = string.Format("Versió: {0}", Application.ProductVersion);
        }

        #endregion

        #region EVENTS

        private void txtFiletoImport_ButtonClick(object sender, EventArgs e)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = path,
                Title = "Busca el fitxer PDF que conté totes les factures",
                
                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "pdf",
                Filter = "fitxer pdf (*.pdf)|*.pdf",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDirToImport.Text = openFileDialog1.FileName;
                dir_output = System.IO.Path.GetDirectoryName(txtDirToImport.Text) + "\\" + DateTime.Now.ToString("yyyy-MM-dd");                
            }
        }

        private void metroGridListFra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGridListFra.Columns[e.ColumnIndex].Name == "col_open_pdf")
            {
                string PathFitxer = metroGridListFra.Rows[e.RowIndex].Cells["col_pdf"].Value.ToString();
                if (File.Exists(PathFitxer))
                {
                    try
                    {
                        ProcessStartInfo info = new ProcessStartInfo();
                        info.FileName = PathFitxer;
                        string s = "";
                        //btn.Tag Contains the full file path 
                        info.Arguments = s;
                        Process.Start(info);
                    }
                    catch { }
                }
            }
        }

        private void metroTileObreDir_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", dir_output);
            }
            catch { }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Step_2();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Step_3();
        }

        private void metroTileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDirToImport_TextChanged(object sender, EventArgs e)
        {
            //metroTile1.Enabled = (txtDirToImport.Text.Length > 0 && txtFileDataBase.Text.Length > 0);
        }

        private void txtFileDataBase_ButtonClick(object sender, EventArgs e)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {

                InitialDirectory = path,
                Title = "Busca el fitxer de les dades dels clients",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "fitxer xlsx (*.xlsx)|*.xlsx",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileDataBase.Text = openFileDialog1.FileName;
                Load_dbs();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //salvar paràmetres.
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            metroTileClose.Enabled = false;
            
            string to_mail = metroTextBoxMailInform.Text;
            string from_mail = "aigua@hostalets.cat";

            // Your client ID and secret obtained from the Google Developer Console
            string clientId = "XXXXXXXXXXXXXXXXXXXXXXXXXX.apps.googleusercontent.com";
            string clientSecret = "XXXXXXXXXXX_tm";

            // Scopes for the Gmail API
            string[] scopes = { GmailService.Scope.GmailSend };

            // Path to the credentials file
            string strWorkPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string CredentialFile = Path.Combine(strWorkPath, "credential.json");
            //string credPath = "C:\\temp\\GmailOAuthExample\\GmailOAuthExample\\credentials\\credentials2.json";
            OAuthGmail oAuthGmail = new OAuthGmail(clientId, clientSecret, scopes, CredentialFile, APPLICATION_NAME);
            var message = new MimeMessage();
            
            //message.From.Add(new MailboxAddress("Servei aigua", "aigua@elshostaletsdepierola.cat"));
            message.From.Add(new MailboxAddress(this.NameMailFrom, from_mail));
            message.To.Add(new MailboxAddress("Hoserpi", to_mail));
            message.Subject = "Informe d'enviament factures de l'aigua";

            var bodyBuilder = new BodyBuilder();                        
            bodyBuilder.TextBody = txtInforme.Text;
            message.Body = bodyBuilder.ToMessageBody();

            // Send email
            try
            {
                SendEmail(oAuthGmail.Service, "me", message);
                
            }
            catch{}

            metroTileClose.Enabled = true;
            MetroFramework.MetroMessageBox.Show(this, "Informe enviat a " + to_mail, "informació", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
        }

        private void metroLinkWeb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://msc-soft.com/",
                UseShellExecute = true
            });
        }

        private void metroLinkMail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "mailto:info@msc-soft.com?subject=Hola&body=" + Application.ProductName + " " + Application.ProductVersion,
                UseShellExecute = true
            });
        }

        private void metroTileHelp_Click(object sender, EventArgs e)
        {

            var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase) + @"\help\index.html";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = path,
                UseShellExecute = true
            });
            //the end.
        }

        #endregion

        #region METHODS


        private void buttonExctratPDF()
        {

            metroGridListFra.Rows.Clear();

            string filename = txtDirToImport.Text;
            PdfDocument inputDocument = PdfReader.Open(filename, PdfDocumentOpenMode.Import);

            metroProgressBarSpinner.Maximum = inputDocument.PageCount;
            for (int idx = 0; idx < inputDocument.PageCount; idx++)
            {

                metroProgressBarSpinner.Value = idx;
                metroProgressBarSpinner.Refresh();
                var page = inputDocument.Pages[idx];
                var content = ContentReader.ReadContent(page);
                var extractedText = ExtractText(content).ToArray();

                int pos_fra = extractedText[16].IndexOf("NUM.FACTURA:");
                string num_fra = extractedText[16].Substring(pos_fra + 13, 10).Trim();
                if (num_fra.Length == 0)
                    num_fra = extractedText[25];

                int pos_comp = extractedText[16].IndexOf("COMPTADOR:");
                int num_comptador = int.Parse(extractedText[16].Substring(pos_comp + 11));

                int rowId = metroGridListFra.Rows.Add();
                DataGridViewRow new_row = metroGridListFra.Rows[rowId];
                new_row.Cells["col_fra"].Value = num_fra;
                new_row.Cells["col_comptador"].Value = num_comptador.ToString("D9");
                new_row.Cells["col_import"].Value = extractedText[3];

                //string usuari = Get_nom_usuari(num_comptador.ToString("D9"));
                new_row.Cells["col_client"].Value = Get_nom_usuari(num_comptador.ToString("D9"));
                new_row.Cells["col_mail"].Value = Get_mail_usuari(num_comptador.ToString("D9"));


                if (!System.IO.Directory.Exists(dir_output))
                    System.IO.Directory.CreateDirectory(dir_output);

                string output_name_pdf = String.Format("fra-aigua-{0}.pdf", num_fra);
                string path_pdf = dir_output + "\\" + output_name_pdf;
                // Create new document
                PdfDocument outputDocument = new PdfDocument();
                outputDocument.Version = inputDocument.Version;
                outputDocument.Info.Title = String.Format("Page {0} of {1}", idx + 1, inputDocument.Info.Title);
                outputDocument.Info.Creator = inputDocument.Info.Creator;
                // Add the page and save it
                outputDocument.AddPage(inputDocument.Pages[idx]);

                outputDocument.Save(path_pdf);
                new_row.Cells["col_pdf"].Value = path_pdf;
                new_row.Cells["col_open_pdf"].Value = "Obrir";
            }

        }

        private void Load_dbs()
        {
            string FileToImport = this.txtFileDataBase.Text;
            String name = "usuaris";
            String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                            FileToImport +
                            ";Extended Properties='Excel 8.0;HDR=YES;';";

            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand oconn = new OleDbCommand("Select * From [" + name + "$]", con);

            try
            {
                con.Open();
            }
            catch (OleDbException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Errors[0].Message, "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
                return;
            }
            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            DataTable data = new DataTable();

            sda.Fill(data);

            data.DefaultView.Sort = "usuari";
            data = data.DefaultView.ToTable();
            dt_usuaris.Clear();
            dt_usuaris.Columns.Clear();
            dt_usuaris.Columns.Add("comptador");
            dt_usuaris.Columns.Add("correu");
            dt_usuaris.Columns.Add("usuari");

            int NumLine = 0;
            foreach (DataRow row in data.Rows)
            {
                string Str_comptador = row["comptador"].ToString();
                if ("" != Str_comptador)
                {
                    try
                    {
                        string struser = row["usuari"].ToString().Trim();
                        int comptador = int.Parse(Str_comptador.ToString());
                        string new_name_user = "";
                        if (struser.Contains(",") == true && struser.Contains("S.L.") == false && struser.Contains("S.A.") == false && struser.Contains("AJUNTAMENT") == false)
                        {
                            string[] array_user = struser.Split(new char[] { ',' });
                            new_name_user = ToTitleCase(array_user[1].Trim() + " " + array_user[0].Trim());
                        }
                        else
                            new_name_user = ToTitleCase(struser);

                        DataRow newro = dt_usuaris.NewRow();
                        newro["comptador"] = comptador.ToString("D9");
                        newro["correu"] = row["correu"].ToString().Trim(); ;
                        newro["usuari"] = new_name_user;
                        dt_usuaris.Rows.Add(newro);
                        NumLine++;
                    }
                    catch
                    {
                        if (DialogResult.OK != MetroFramework.MetroMessageBox.Show(this, string.Format("Error a la línia {0} i número de comptador {1}, vols continuar?", NumLine, Str_comptador), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, 100))
                            break;
                    }
                }

            }
            //Carrega configuració
            try
            {
                data.Clear();
                name = "configuració";
                oconn = new OleDbCommand("Select * From [" + name + "$]", con);
                sda = new OleDbDataAdapter(oconn);

                sda.Fill(data);

                this.NameMailFrom = data.Rows[0]["name_mail_from"].ToString().Trim();
                metroTextBoxMailBody.Text = data.Rows[0]["cos_missatge"].ToString().Trim();
                metroTextBoxMailInform.Text = data.Rows[0]["correu_informe"].ToString().Trim();
                string sbs = data.Rows[0]["pas_a_pas"].ToString().Trim();

                chk_all_steps.Checked = (data.Rows[0]["pas_a_pas"].ToString().Trim() == "1");
                metroTile1.Enabled = true;
            }
            catch (Exception Ex)
            {
                ResetMailConf();
                MetroFramework.MetroMessageBox.Show(this, string.Format("Error en la configuració: {0}", Ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }

        }

        private void ResetMailConf()
        {
            metroTextBoxMailBody.Text = string.Empty;
            metroTextBoxMailRemitent.Text = string.Empty;
            metroTextBoxMailPsw.Text = string.Empty;
            metroTextBoxMailSMTP.Text = string.Empty;
            metroTextBoxMailPort.Text = string.Empty;
            metroTextBoxMailInform.Text = string.Empty;
            metroTile1.Enabled = false;
        }

        private IEnumerable<string> ExtractText(CObject cObject)
        {
            var textList = new List<string>();
            if (cObject is COperator)
            {
                var cOperator = cObject as COperator;
                if (cOperator.OpCode.Name == OpCodeName.Tj.ToString() ||
                            cOperator.OpCode.Name == OpCodeName.TJ.ToString())
                    foreach (var cOperand in cOperator.Operands)
                        textList.AddRange(ExtractText(cOperand));
            }
            else if (cObject is CSequence)
            {
                var cSequence = cObject as CSequence;
                foreach (var element in cSequence)
                    textList.AddRange(ExtractText(element));
            }
            else if (cObject is CString)
            {
                var cString = cObject as CString;
                textList.Add(cString.Value);
            }

            return textList;
        }

        private void Step_2()
        {
            metroLabelInfoProcess.Visible = true;
            metroTileClose.Enabled = false;
            metroPanel1.Visible = false;
            metroProgressBarSpinner.Visible = true;
            metroProgressBar1.Value = 1;
            this.Refresh();

            buttonExctratPDF();
            metroProgressBarSpinner.Visible = false;
            metroPanel2.Visible = true;
            metroTileClose.Enabled = true;
            metroLabelInfoProcess.Visible = false;
            this.Refresh();
            if (chk_all_steps.Checked == false) { Step_3(); }
        }

        private bool Step_3()
        {
            metroLabelInfoProcess.Visible = true;
            metroLabelInfoProcess.Text = "Enviant correus ...";
            metroTileClose.Enabled = false;
            metroPanel2.Visible = false;
            metroProgressBarSpinner.Visible = true;
            metroProgressBar1.Value = 2;
            this.Refresh();

            string Informe = SendEmails();

            txtInforme.Text = Informe;

            StreamWriter sw = new StreamWriter(dir_output + "\\informe_" + DateTime.Now.ToString("yyy-MM-dd") + ".txt");
            sw.Write(Informe);
            sw.Close();


            metroProgressBarSpinner.Visible = false;
            metroPanel3.Visible = true;
            metroProgressBar1.Value = 3;
            metroTileClose.Enabled = true;
            metroLabelInfoProcess.Visible = false;
            return true;
        }

        private string SendEmails()
        {

            // Your client ID and secret obtained from the Google Developer Console
            string clientId = "XXXXX.apps.googleusercontent.com";
            string clientSecret = "XXXXXX_tm";

            // Scopes for the Gmail API
            string[] scopes = { GmailService.Scope.GmailSend };

            // Path to the credentials file
            string strWorkPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string CredentialFile = Path.Combine(strWorkPath, "credential.json");
            //string credPath = "C:\\temp\\GmailOAuthExample\\GmailOAuthExample\\credentials\\credentials2.json";
            OAuthGmail oAuthGmail = new OAuthGmail(clientId, clientSecret, scopes, CredentialFile, APPLICATION_NAME);

            StringBuilder txtInforme = new StringBuilder();
            string html_body = metroTextBoxMailBody.Text;
            //int port_server = int.Parse(metroTextBoxMailPort.Text);// 25;
            //string from_mail = metroTextBoxMailRemitent.Text;
            //string pws = metroTextBoxMailPsw.Text;
            //string smtp = metroTextBoxMailSMTP.Text;

            metroProgressBarSpinner.Maximum = metroGridListFra.Rows.Count;
            txtInforme.AppendLine("Inici de l'enviament de factures " + DateTime.Now.ToLongTimeString());
            int Err_mail = 0;

            for (int i = 0; i < metroGridListFra.Rows.Count; i++)
            {
                Stopwatch timerPerMail = new Stopwatch();
                if (CancelAction)
                {
                    txtInforme.AppendLine("L'usuari ha cancel·lat l'enviament de factures.");
                    break;
                }

                metroProgressBarSpinner.Value = i;
                metroProgressBarSpinner.Refresh();
                metroLabelInfoProcess.Text = string.Format("Enviant {0} de {1} correus", i + 1, metroGridListFra.Rows.Count);//"Enviant "+(i+1).ToString + " correus";
                metroLabelInfoProcess.Refresh();

                string client_mail = metroGridListFra.Rows[i].Cells["col_mail"].Value.ToString();
                string path_pdf = metroGridListFra.Rows[i].Cells["col_pdf"].Value.ToString();

                string nom_client = metroGridListFra.Rows[i].Cells["col_client"].Value.ToString();
                string num_factura = metroGridListFra.Rows[i].Cells["col_fra"].Value.ToString();
                string import = metroGridListFra.Rows[i].Cells["col_import"].Value.ToString();

                if (IsValidEmail(client_mail) == true)
                {
                    var message = new MimeMessage();
                    //message.From.Add(new MailboxAddress("Servei aigua", "aigua@elshostaletsdepierola.cat"));
                    message.From.Add(new MailboxAddress(this.NameMailFrom, "aigua@hostalets.cat"));
                    message.To.Add(new MailboxAddress(nom_client, client_mail));
                    message.Subject = "Factura " + num_factura;

                    string new_html_body = html_body.Replace("{client}", nom_client);
                    new_html_body = new_html_body.Replace("{fra}", num_factura);
                    new_html_body = new_html_body.Replace("{import}", import);

                    var bodyBuilder = new BodyBuilder();
                    bodyBuilder.Attachments.Add(path_pdf);
                    
                    bodyBuilder.HtmlBody = MyHtmlEncode(new_html_body);
                    message.Body = bodyBuilder.ToMessageBody();

                    // Send email
                    try
                    {
                        SendEmail(oAuthGmail.Service, "me", message);
                        txtInforme.AppendLine("Factura " + num_factura + " enviada a " + nom_client + " (" + client_mail + ") Temps(ms): " + timerPerMail.ElapsedMilliseconds);
                    }
                    catch (Exception ex)
                    {
                        txtInforme.AppendLine("Error al entregar correu: " + ex.ToString() + " Temps(ms): " + timerPerMail.ElapsedMilliseconds);
                        Err_mail++;
                    }

                    System.Threading.Thread.Sleep(500);
                }
                else
                {
                    txtInforme.AppendLine("ERROR: Factura " + num_factura + "  NO enviada a " + nom_client + " (correu no vàlid) Temps(ms): " + timerPerMail.ElapsedMilliseconds);
                    Err_mail++;
                }
            }
            txtInforme.AppendLine("Correus enviats: " + (metroGridListFra.Rows.Count - Err_mail).ToString() + ", enviaments errònis:  " + Err_mail.ToString() + ", d'un total de " + metroGridListFra.Rows.Count.ToString() + ".");
            txtInforme.AppendLine("Final de l'enviament de factures " + DateTime.Now.ToLongTimeString());

            return txtInforme.ToString();
        }


        static void SendEmail(GmailService service, string userId, MimeMessage emailMessage)
        {
            var message = new Google.Apis.Gmail.v1.Data.Message
            {
                Raw = Base64UrlEncode(emailMessage.ToString())
            };

            // Send email
            service.Users.Messages.Send(message, userId).Execute();
        }

        static string Base64UrlEncode(string input)
        {
            var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(inputBytes)
                .Replace('+', '-')
                .Replace('/', '_')
                .Replace("=", "");
        }

        public string ToTitleCase(string str)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }

        private string Get_mail_usuari(string num_comptador)
        {
            foreach (DataRow row in dt_usuaris.Rows)
            {
                string comptador = row["comptador"].ToString();
                if (comptador == num_comptador)
                {
                    return row["correu"].ToString();
                }
            }
            return "";
        }

        private string Get_nom_usuari(string num_comptador)
        {
            foreach (DataRow row in dt_usuaris.Rows)
            {
                string comptador = row["comptador"].ToString();
                if (comptador == num_comptador)
                    return row["usuari"].ToString();
            }
            return "";
        }

        bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        #endregion
        private void linkHtml_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = linkHtml.Text,
                UseShellExecute = true
            });
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {            
            metroTextBoxMailBody.Text = MyHtmlEncode(metroTextBoxMailBody.Text);
        }

        private string MyHtmlEncode(string inputHTML)
        {
            string Finaltxt = string.Empty;
            //string pattern2 = @"(<[^>]*>)";
            string pattern2 = @"<\s*([^ >]+)[^>]*>.*?<\s*/\s*\1\s*>";
            //string pattern2 = @"<(.|\n)*?>";
            var allTagList = new List<string>();

            var patternMatch = Regex.Matches(inputHTML, pattern2);
            for (int i = 0; i < patternMatch.Count; i++)
            {
                allTagList.Add(patternMatch[i].ToString());
            }

            foreach( string tag in allTagList )
            {
                int PuntOut = tag.IndexOf(">")+1;
                string tagIn = tag.Substring(0, PuntOut);
                string tagOut = tag.Substring(tag.Length - PuntOut-1, PuntOut+1);
                string txt = tag.Replace(tagIn, "").Replace(tagOut, "");
                
                string resultTxt = tagIn + System.Net.WebUtility.HtmlEncode(txt) + tagOut;
                if (resultTxt.Contains("€"))
                    resultTxt = resultTxt.Replace("€", "&euro;");

                Finaltxt += resultTxt;

            }

            return Finaltxt;
        }
    }
}
//https://azuredevopslabs.com/labs/devopsserver/github/