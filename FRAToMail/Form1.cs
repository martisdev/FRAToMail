using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf.Content;
using PdfSharp.Pdf.Content.Objects;
using System.IO;
using System.Diagnostics;
using System.Data.OleDb;
using System.Net.Mail;

namespace FRAToMail
{
    public partial class FormMain : MetroForm
    {
        string dir_output = "";
        string nom_remitent = "Hoserpi SL";
        public FormMain()
        {
            InitializeComponent();
            metroLinkVersion.Text = string.Format("Versió: {0}", Application.ProductVersion );
        }

        private void txtFiletoImport_ButtonClick(object sender, EventArgs e)
        {

            //using (var fbd = new FolderBrowserDialog())
            //{
            //    fbd.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //    DialogResult result = fbd.ShowDialog();

            //    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            //    {

            //        txtDirToImport.Text = fbd.SelectedPath;

            //    }                                
            //}
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
                txtDirToImport.Text= openFileDialog1.FileName;

                dir_output = System.IO.Path.GetDirectoryName(txtDirToImport.Text)+"\\"+ DateTime.Now.ToString("yyyy-MM-dd");


            }
        }

        
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
                {
                    num_fra = extractedText[25];
                }
                    int pos_comp = extractedText[16].IndexOf("COMPTADOR:");
                int num_comptador = int.Parse( extractedText[16].Substring(pos_comp + 11));
                    
                int rowId = metroGridListFra.Rows.Add();
                DataGridViewRow new_row = metroGridListFra.Rows[rowId];
                new_row.Cells["col_fra"].Value = num_fra;
                new_row.Cells["col_comptador"].Value = num_comptador.ToString("D9");
                new_row.Cells["col_import"].Value = extractedText[3];

                string usuari = Get_nom_usuari(num_comptador.ToString("D9"));

                //if (extractedText[41] == "Aquest document només acredita el pagament si va amb autentificació mecànica i/o emplenat amb la data i el segell")
                //{
                //    usuari = extractedText[40];
                //}
                //else
                //{
                //    usuari = extractedText[41];
                //}

                //string new_name_user = "";
                //if (usuari.Contains(",") == true)
                //{
                //    string[] array_user = usuari.Split(new char[] { ',' });
                //    new_name_user = ToTitleCase(array_user[1].Trim()) + " " + ToTitleCase(array_user[0].Trim());
                //}
                //else
                //{
                //    new_name_user = ToTitleCase(usuari);
                //}

                //new_row.Cells["col_client"].Value = new_name_user;
                new_row.Cells["col_client"].Value = Get_nom_usuari(num_comptador.ToString("D9"));
                new_row.Cells["col_mail"].Value = Get_mail_usuari(num_comptador.ToString("D9"));

                    
                if (!System.IO.Directory.Exists(dir_output))
                {
                    System.IO.Directory.CreateDirectory(dir_output);
                }

                   
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

        private IEnumerable<string> ExtractText(CObject cObject)
        {
            var textList = new List<string>();
            if (cObject is COperator)
            {
                var cOperator = cObject as COperator;
                if (cOperator.OpCode.Name == OpCodeName.Tj.ToString() ||
                    cOperator.OpCode.Name == OpCodeName.TJ.ToString())
                {
                    foreach (var cOperand in cOperator.Operands)
                    {
                        textList.AddRange(ExtractText(cOperand));
                    }
                }
            }
            else if (cObject is CSequence)
            {
                var cSequence = cObject as CSequence;
                foreach (var element in cSequence)
                {
                    textList.AddRange(ExtractText(element));
                }
            }
            else if (cObject is CString)
            {
                var cString = cObject as CString;
                textList.Add(cString.Value);
            }            

            return textList;
        }

        private void metroGridListFra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if( metroGridListFra.Columns[e.ColumnIndex].Name == "col_open_pdf")
            {
                string PathFitxer = metroGridListFra.Rows[e.RowIndex].Cells["col_pdf"].Value.ToString();
                if( File.Exists(PathFitxer))
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

        private void Step_3()
        {
            metroLabelInfoProcess.Visible = true;
            metroLabelInfoProcess.Text = "Enviant correus ...";
            metroTileClose.Enabled = false;
            metroPanel2.Visible = false;
            metroProgressBarSpinner.Visible = true;
            metroProgressBar1.Value = 2;
            this.Refresh();
            
            SendEmails();

            metroProgressBarSpinner.Visible = false;
            metroPanel3.Visible = true;
            metroProgressBar1.Value = 3;
            metroTileClose.Enabled = true;
            metroLabelInfoProcess.Visible = false;
        }

        private void SendEmails()
        {
            string html_body = metroTextBoxMailBody.Text;

            int port_server = int.Parse(metroTextBoxMailPort.Text);// 25;
            string from_mail = metroTextBoxMailRemitent.Text;
            string pws = metroTextBoxMailPsw.Text;
            string smtp = metroTextBoxMailSMTP.Text;

            metroProgressBarSpinner.Maximum = metroGridListFra.Rows.Count;
            txtInforme.Text = "Inici de l'enviament de factures "+ DateTime.Now.ToLongTimeString()+ Environment.NewLine;
            int Err_mail = 0;

            
            for (int i = 0; i < metroGridListFra.Rows.Count; i++)
            {
                metroProgressBarSpinner.Value = i;
                metroProgressBarSpinner.Refresh();
                metroLabelInfoProcess.Text = string.Format("Enviant {0} de {1} correus", i + 1, metroGridListFra.Rows.Count);//"Enviant "+(i+1).ToString + " correus";
                metroLabelInfoProcess.Refresh();
                
                string client_mail = metroGridListFra.Rows[i].Cells["col_mail"].Value.ToString();
                string path_pdf = metroGridListFra.Rows[i].Cells["col_pdf"].Value.ToString();
                string nom_client = metroGridListFra.Rows[i].Cells["col_client"].Value.ToString();
                string num_factura = metroGridListFra.Rows[i].Cells["col_fra"].Value.ToString();
                string import = metroGridListFra.Rows[i].Cells["col_import"].Value.ToString();
                
                if (IsValidEmail(client_mail)==true){
                    using (MailMessage emailMessage = new MailMessage())
                    {
                        emailMessage.From = new MailAddress(from_mail, nom_remitent);
                        emailMessage.To.Add(new MailAddress(client_mail, nom_client));
                        emailMessage.Subject = "Factura " + num_factura;
                        string new_html_body = html_body.Replace("{client}", nom_client);
                        new_html_body = new_html_body.Replace("{fra}", num_factura);
                        new_html_body = new_html_body.Replace("{import}", import);
                        emailMessage.Body = new_html_body;
                        emailMessage.BodyEncoding = Encoding.UTF8;
                        emailMessage.Headers.Add("Content-Type", "text/html; charset=utf-8");
                        emailMessage.IsBodyHtml = true;
                        emailMessage.Attachments.Add(new Attachment(path_pdf));

                        emailMessage.Priority = MailPriority.Normal;
                        using (SmtpClient MailClient = new SmtpClient(smtp, port_server))
                        {
                            //MailClient.EnableSsl = true;
                            MailClient.Credentials = new System.Net.NetworkCredential(from_mail, pws);
                            try
                            {
                                MailClient.Send(emailMessage);
                                txtInforme.Text += "Factura " + num_factura + " enviada a " + nom_client + " (" + client_mail + ")" + Environment.NewLine;
                            }
                            catch (SmtpFailedRecipientsException ex)
                            {
                                for (int em = 0; em < ex.InnerExceptions.Length; em++)
                                {
                                    SmtpStatusCode status = ex.InnerExceptions[em].StatusCode;
                                    if (status == SmtpStatusCode.MailboxBusy ||
                                        status == SmtpStatusCode.MailboxUnavailable)
                                    {
                                        txtInforme.Text += "Entrega de correu fallida - provant en 5 segons";
                                        System.Threading.Thread.Sleep(5000);

                                        MailClient.Send(emailMessage);
                                        txtInforme.Text += "Factura " + num_factura + " enviada a " + nom_client + " (" + client_mail + ")" + Environment.NewLine;
                                    }
                                    else
                                    {
                                        txtInforme.Text += "Error al entregar correu amb missatge: " + ex.InnerExceptions[i].FailedRecipient;
                                        Err_mail ++;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {                                
                                txtInforme.Text += "Error al entregar correu RetryIfBusy(): " + ex.ToString();
                                Err_mail++;
                            }
                        }
                    }
                    System.Threading.Thread.Sleep(500);
                }
                else
                {
                    txtInforme.Text += "ERROR: Factura " + num_factura + "  NO enviada a " + nom_client + " (correu no vàlid)" + Environment.NewLine;
                    Err_mail++;
                }                
            }            
            txtInforme.Text += "Correus enviats: " + (metroGridListFra.Rows.Count - Err_mail).ToString() + ", enviaments errònis:  "+ Err_mail.ToString() +", d'un total de "+ metroGridListFra.Rows.Count.ToString()+"."+ Environment.NewLine;
            txtInforme.Text += "Final de l'enviament de factures " + DateTime.Now.ToLongTimeString() + Environment.NewLine;

            StreamWriter sw = new StreamWriter(dir_output + "\\informe_" + DateTime.Now.ToString("yyy-MM-dd") + ".txt");
            sw.Write(txtInforme.Text);
            sw.Close();        

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
            metroTile1.Enabled = (txtDirToImport.Text.Length > 0 && txtFileDataBase.Text.Length > 0);
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

        DataTable dt_usuaris = new DataTable();
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

            dt_usuaris.Columns.Add("comptador");
            dt_usuaris.Columns.Add("correu");
            dt_usuaris.Columns.Add("usuari");

            

            foreach (DataRow row in data.Rows)
            {

                int comptador = int.Parse( row["comptador"].ToString());
                string struser = row["usuari"].ToString().Trim();
                string new_name_user = "";
                if (struser.Contains(",")== true && struser.Contains("S.L.")==false && struser.Contains("S.A.") == false && struser.Contains("AJUNTAMENT") == false)
                {
                    string[] array_user = struser.Split(new char[] { ',' });
                    new_name_user = ToTitleCase(array_user[1].Trim() + " " + array_user[0].Trim());
                }
                else
                {
                    new_name_user = ToTitleCase(struser);
                }
                    
                DataRow newro = dt_usuaris.NewRow();
                newro["comptador"] = comptador.ToString ("D9");
                newro["correu"] = row["correu"].ToString().Trim(); ;
                newro["usuari"] = new_name_user;
                dt_usuaris.Rows.Add(newro);
            }
            //Carrega configuració
            data.Clear();
            name =  "configuració";
            oconn = new OleDbCommand("Select * From [" + name + "$]", con);
            sda = new OleDbDataAdapter(oconn);
            
            sda.Fill(data);

            metroTextBoxMailBody.Text = data.Rows[0]["cos_missatge"].ToString().Trim();
            metroTextBoxMailRemitent.Text = data.Rows[0]["correu_remitent"].ToString().Trim();
            metroTextBoxMailPsw.Text = data.Rows[0]["contrasenya"].ToString().Trim();
            metroTextBoxMailSMTP.Text = data.Rows[0]["servidor_smtp"].ToString().Trim();
            metroTextBoxMailPort.Text = data.Rows[0]["port"].ToString().Trim();
            metroTextBoxMailInform.Text = data.Rows[0]["correu_informe"].ToString().Trim();
            string sbs = data.Rows[0]["pas_a_pas"].ToString().Trim();
            
            chk_all_steps.Checked = (data.Rows[0]["pas_a_pas"].ToString().Trim()=="1");
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
                {
                    return row["usuari"].ToString();                    
                }
            }
            return "";
        }


        private void metroTile5_Click(object sender, EventArgs e)
        {
            metroTileClose.Enabled = false;
            int port_server = int.Parse( metroTextBoxMailPort.Text);
            string from_mail = metroTextBoxMailRemitent.Text;
            string to_mail = metroTextBoxMailInform.Text;
            string pws = metroTextBoxMailPsw.Text;
            string smtp = metroTextBoxMailSMTP.Text;

            using (MailMessage emailMessage = new MailMessage())
            {
                emailMessage.From = new MailAddress(from_mail, nom_remitent);
                emailMessage.To.Add(new MailAddress(to_mail));
                emailMessage.Subject = "Informe d'enviament factures de l'aigua";
                emailMessage.Body = txtInforme.Text;
                emailMessage.Priority = MailPriority.Normal;
                using (SmtpClient MailClient = new SmtpClient(smtp, port_server))
                {
                    //MailClient.EnableSsl = true;
                    MailClient.Credentials = new System.Net.NetworkCredential(from_mail, pws);
                    MailClient.Send(emailMessage);
                }
            }
            metroTileClose.Enabled = true;
            MetroFramework.MetroMessageBox.Show(this, "Informe enviat a " + from_mail , "informació", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
        }

        bool IsValidEmail(string email)
        {
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
        }
    }
}
//https://azuredevopslabs.com/labs/devopsserver/github/