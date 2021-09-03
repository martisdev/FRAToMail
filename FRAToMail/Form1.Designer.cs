namespace FRAToMail
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtDirToImport = new MetroFramework.Controls.MetroTextBox();
            this.metroGridListFra = new MetroFramework.Controls.MetroGrid();
            this.col_fra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_comptador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_import = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pdf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_open_pdf = new System.Windows.Forms.DataGridViewButtonColumn();
            this.metroTileObreDir = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTextBoxMailPort = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxMailSMTP = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxMailPsw = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxMailRemitent = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.chk_all_steps = new MetroFramework.Controls.MetroToggle();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.txtFileDataBase = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTextBoxMailBody = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressBarSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.metroTileClose = new MetroFramework.Controls.MetroTile();
            this.metroTextBoxMailInform = new MetroFramework.Controls.MetroTextBox();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.txtInforme = new MetroFramework.Controls.MetroTextBox();
            this.metroTileHelp = new MetroFramework.Controls.MetroTile();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelInfoProcess = new MetroFramework.Controls.MetroLabel();
            this.metroLinkWeb = new MetroFramework.Controls.MetroLink();
            this.metroLinkMail = new MetroFramework.Controls.MetroLink();
            this.metroLinkVersion = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridListFra)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDirToImport
            // 
            this.txtDirToImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtDirToImport.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtDirToImport.CustomButton.Location = new System.Drawing.Point(606, 1);
            this.txtDirToImport.CustomButton.Name = "";
            this.txtDirToImport.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtDirToImport.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDirToImport.CustomButton.TabIndex = 1;
            this.txtDirToImport.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDirToImport.CustomButton.UseSelectable = true;
            this.txtDirToImport.Lines = new string[0];
            this.txtDirToImport.Location = new System.Drawing.Point(73, 53);
            this.txtDirToImport.MaxLength = 32767;
            this.txtDirToImport.Name = "txtDirToImport";
            this.txtDirToImport.PasswordChar = '\0';
            this.txtDirToImport.PromptText = "Escolliu el fitxer PDF a tractar ...";
            this.txtDirToImport.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDirToImport.SelectedText = "";
            this.txtDirToImport.SelectionLength = 0;
            this.txtDirToImport.SelectionStart = 0;
            this.txtDirToImport.ShortcutsEnabled = true;
            this.txtDirToImport.ShowButton = true;
            this.txtDirToImport.Size = new System.Drawing.Size(634, 29);
            this.txtDirToImport.TabIndex = 32;
            this.toolTip1.SetToolTip(this.txtDirToImport, "Escolliu el directòri dels PDFs a tractar ...");
            this.txtDirToImport.UseSelectable = true;
            this.txtDirToImport.WaterMark = "Escolliu el fitxer PDF a tractar ...";
            this.txtDirToImport.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDirToImport.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDirToImport.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtFiletoImport_ButtonClick);
            this.txtDirToImport.TextChanged += new System.EventHandler(this.txtDirToImport_TextChanged);
            // 
            // metroGridListFra
            // 
            this.metroGridListFra.AllowUserToAddRows = false;
            this.metroGridListFra.AllowUserToDeleteRows = false;
            this.metroGridListFra.AllowUserToResizeRows = false;
            this.metroGridListFra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGridListFra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridListFra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridListFra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridListFra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridListFra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridListFra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridListFra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_fra,
            this.col_comptador,
            this.col_import,
            this.col_client,
            this.col_mail,
            this.col_pdf,
            this.col_open_pdf});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridListFra.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridListFra.EnableHeadersVisualStyles = false;
            this.metroGridListFra.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridListFra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridListFra.Location = new System.Drawing.Point(73, 53);
            this.metroGridListFra.Name = "metroGridListFra";
            this.metroGridListFra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridListFra.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridListFra.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridListFra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridListFra.Size = new System.Drawing.Size(634, 306);
            this.metroGridListFra.TabIndex = 37;
            this.metroGridListFra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridListFra_CellContentClick);
            // 
            // col_fra
            // 
            this.col_fra.HeaderText = "Factura";
            this.col_fra.Name = "col_fra";
            this.col_fra.Width = 75;
            // 
            // col_comptador
            // 
            this.col_comptador.HeaderText = "Comptador";
            this.col_comptador.Name = "col_comptador";
            this.col_comptador.Width = 75;
            // 
            // col_import
            // 
            this.col_import.HeaderText = "Import";
            this.col_import.Name = "col_import";
            this.col_import.Width = 60;
            // 
            // col_client
            // 
            this.col_client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_client.HeaderText = "Client";
            this.col_client.Name = "col_client";
            // 
            // col_mail
            // 
            this.col_mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_mail.HeaderText = "Correu";
            this.col_mail.Name = "col_mail";
            // 
            // col_pdf
            // 
            this.col_pdf.HeaderText = "File PDF";
            this.col_pdf.Name = "col_pdf";
            this.col_pdf.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_pdf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_pdf.Visible = false;
            // 
            // col_open_pdf
            // 
            this.col_open_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.col_open_pdf.HeaderText = "PDF";
            this.col_open_pdf.Name = "col_open_pdf";
            this.col_open_pdf.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_open_pdf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_open_pdf.Text = "";
            this.col_open_pdf.ToolTipText = "Obrir";
            // 
            // metroTileObreDir
            // 
            this.metroTileObreDir.ActiveControl = null;
            this.metroTileObreDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroTileObreDir.Location = new System.Drawing.Point(74, 365);
            this.metroTileObreDir.Name = "metroTileObreDir";
            this.metroTileObreDir.Size = new System.Drawing.Size(72, 46);
            this.metroTileObreDir.TabIndex = 39;
            this.metroTileObreDir.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileObreDir.TileImage")));
            this.metroTileObreDir.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileObreDir.UseSelectable = true;
            this.metroTileObreDir.UseTileImage = true;
            this.metroTileObreDir.Click += new System.EventHandler(this.metroTileObreDir_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroPanel1.Controls.Add(this.metroTextBoxMailPort);
            this.metroPanel1.Controls.Add(this.metroTextBoxMailSMTP);
            this.metroPanel1.Controls.Add(this.metroTextBoxMailPsw);
            this.metroPanel1.Controls.Add(this.metroTextBoxMailRemitent);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.chk_all_steps);
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.Controls.Add(this.txtFileDataBase);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.metroTextBoxMailBody);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txtDirToImport);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(53, 133);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(781, 433);
            this.metroPanel1.TabIndex = 40;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTextBoxMailPort
            // 
            this.metroTextBoxMailPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBoxMailPort.CustomButton.Image = null;
            this.metroTextBoxMailPort.CustomButton.Location = new System.Drawing.Point(77, 2);
            this.metroTextBoxMailPort.CustomButton.Name = "";
            this.metroTextBoxMailPort.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBoxMailPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxMailPort.CustomButton.TabIndex = 1;
            this.metroTextBoxMailPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxMailPort.CustomButton.UseSelectable = true;
            this.metroTextBoxMailPort.CustomButton.Visible = false;
            this.metroTextBoxMailPort.Lines = new string[0];
            this.metroTextBoxMailPort.Location = new System.Drawing.Point(609, 334);
            this.metroTextBoxMailPort.MaxLength = 32767;
            this.metroTextBoxMailPort.Name = "metroTextBoxMailPort";
            this.metroTextBoxMailPort.PasswordChar = '\0';
            this.metroTextBoxMailPort.PromptText = "Port";
            this.metroTextBoxMailPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxMailPort.SelectedText = "";
            this.metroTextBoxMailPort.SelectionLength = 0;
            this.metroTextBoxMailPort.SelectionStart = 0;
            this.metroTextBoxMailPort.ShortcutsEnabled = true;
            this.metroTextBoxMailPort.Size = new System.Drawing.Size(99, 24);
            this.metroTextBoxMailPort.TabIndex = 45;
            this.toolTip1.SetToolTip(this.metroTextBoxMailPort, "Servidor de Sortida (SMTP)");
            this.metroTextBoxMailPort.UseSelectable = true;
            this.metroTextBoxMailPort.WaterMark = "Port";
            this.metroTextBoxMailPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxMailPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxMailSMTP
            // 
            this.metroTextBoxMailSMTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBoxMailSMTP.CustomButton.Image = null;
            this.metroTextBoxMailSMTP.CustomButton.Location = new System.Drawing.Point(151, 2);
            this.metroTextBoxMailSMTP.CustomButton.Name = "";
            this.metroTextBoxMailSMTP.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBoxMailSMTP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxMailSMTP.CustomButton.TabIndex = 1;
            this.metroTextBoxMailSMTP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxMailSMTP.CustomButton.UseSelectable = true;
            this.metroTextBoxMailSMTP.CustomButton.Visible = false;
            this.metroTextBoxMailSMTP.Lines = new string[0];
            this.metroTextBoxMailSMTP.Location = new System.Drawing.Point(428, 334);
            this.metroTextBoxMailSMTP.MaxLength = 32767;
            this.metroTextBoxMailSMTP.Name = "metroTextBoxMailSMTP";
            this.metroTextBoxMailSMTP.PasswordChar = '\0';
            this.metroTextBoxMailSMTP.PromptText = "Servidor de Sortida (SMTP)";
            this.metroTextBoxMailSMTP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxMailSMTP.SelectedText = "";
            this.metroTextBoxMailSMTP.SelectionLength = 0;
            this.metroTextBoxMailSMTP.SelectionStart = 0;
            this.metroTextBoxMailSMTP.ShortcutsEnabled = true;
            this.metroTextBoxMailSMTP.Size = new System.Drawing.Size(173, 24);
            this.metroTextBoxMailSMTP.TabIndex = 44;
            this.toolTip1.SetToolTip(this.metroTextBoxMailSMTP, "Servidor de Sortida (SMTP)");
            this.metroTextBoxMailSMTP.UseSelectable = true;
            this.metroTextBoxMailSMTP.WaterMark = "Servidor de Sortida (SMTP)";
            this.metroTextBoxMailSMTP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxMailSMTP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxMailPsw
            // 
            this.metroTextBoxMailPsw.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.metroTextBoxMailPsw.CustomButton.Image = null;
            this.metroTextBoxMailPsw.CustomButton.Location = new System.Drawing.Point(151, 2);
            this.metroTextBoxMailPsw.CustomButton.Name = "";
            this.metroTextBoxMailPsw.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBoxMailPsw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxMailPsw.CustomButton.TabIndex = 1;
            this.metroTextBoxMailPsw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxMailPsw.CustomButton.UseSelectable = true;
            this.metroTextBoxMailPsw.CustomButton.Visible = false;
            this.metroTextBoxMailPsw.Lines = new string[0];
            this.metroTextBoxMailPsw.Location = new System.Drawing.Point(250, 334);
            this.metroTextBoxMailPsw.MaxLength = 32767;
            this.metroTextBoxMailPsw.Name = "metroTextBoxMailPsw";
            this.metroTextBoxMailPsw.PasswordChar = '*';
            this.metroTextBoxMailPsw.PromptText = "Contrasenya";
            this.metroTextBoxMailPsw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxMailPsw.SelectedText = "";
            this.metroTextBoxMailPsw.SelectionLength = 0;
            this.metroTextBoxMailPsw.SelectionStart = 0;
            this.metroTextBoxMailPsw.ShortcutsEnabled = true;
            this.metroTextBoxMailPsw.Size = new System.Drawing.Size(173, 24);
            this.metroTextBoxMailPsw.TabIndex = 43;
            this.toolTip1.SetToolTip(this.metroTextBoxMailPsw, "Contrasenya del correu sortint");
            this.metroTextBoxMailPsw.UseSelectable = true;
            this.metroTextBoxMailPsw.WaterMark = "Contrasenya";
            this.metroTextBoxMailPsw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxMailPsw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxMailRemitent
            // 
            this.metroTextBoxMailRemitent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.metroTextBoxMailRemitent.CustomButton.Image = null;
            this.metroTextBoxMailRemitent.CustomButton.Location = new System.Drawing.Point(151, 2);
            this.metroTextBoxMailRemitent.CustomButton.Name = "";
            this.metroTextBoxMailRemitent.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBoxMailRemitent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxMailRemitent.CustomButton.TabIndex = 1;
            this.metroTextBoxMailRemitent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxMailRemitent.CustomButton.UseSelectable = true;
            this.metroTextBoxMailRemitent.CustomButton.Visible = false;
            this.metroTextBoxMailRemitent.Lines = new string[0];
            this.metroTextBoxMailRemitent.Location = new System.Drawing.Point(73, 334);
            this.metroTextBoxMailRemitent.MaxLength = 32767;
            this.metroTextBoxMailRemitent.Name = "metroTextBoxMailRemitent";
            this.metroTextBoxMailRemitent.PasswordChar = '\0';
            this.metroTextBoxMailRemitent.PromptText = "Adreça de correu remitent";
            this.metroTextBoxMailRemitent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxMailRemitent.SelectedText = "";
            this.metroTextBoxMailRemitent.SelectionLength = 0;
            this.metroTextBoxMailRemitent.SelectionStart = 0;
            this.metroTextBoxMailRemitent.ShortcutsEnabled = true;
            this.metroTextBoxMailRemitent.Size = new System.Drawing.Size(173, 24);
            this.metroTextBoxMailRemitent.TabIndex = 42;
            this.metroTextBoxMailRemitent.UseSelectable = true;
            this.metroTextBoxMailRemitent.WaterMark = "Adreça de correu remitent";
            this.metroTextBoxMailRemitent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxMailRemitent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(713, 131);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 15);
            this.metroLabel5.TabIndex = 41;
            this.metroLabel5.Text = "Variables:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(152, 378);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(112, 19);
            this.metroLabel4.TabIndex = 40;
            this.metroLabel4.Text = "Executa pas a pas";
            this.toolTip1.SetToolTip(this.metroLabel4, "Executa pas a pas");
            // 
            // chk_all_steps
            // 
            this.chk_all_steps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_all_steps.AutoSize = true;
            this.chk_all_steps.Checked = true;
            this.chk_all_steps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_all_steps.Location = new System.Drawing.Point(67, 379);
            this.chk_all_steps.Name = "chk_all_steps";
            this.chk_all_steps.Size = new System.Drawing.Size(80, 17);
            this.chk_all_steps.TabIndex = 39;
            this.chk_all_steps.Text = "On";
            this.toolTip1.SetToolTip(this.chk_all_steps, "Executa pas a pas");
            this.chk_all_steps.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile1.Enabled = false;
            this.metroTile1.Location = new System.Drawing.Point(549, 364);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(160, 46);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile1.TabIndex = 37;
            this.metroTile1.Text = "Següent";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.metroTile1, "Inicia el procés");
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // txtFileDataBase
            // 
            this.txtFileDataBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtFileDataBase.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.txtFileDataBase.CustomButton.Location = new System.Drawing.Point(606, 1);
            this.txtFileDataBase.CustomButton.Name = "";
            this.txtFileDataBase.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtFileDataBase.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFileDataBase.CustomButton.TabIndex = 1;
            this.txtFileDataBase.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFileDataBase.CustomButton.UseSelectable = true;
            this.txtFileDataBase.Lines = new string[0];
            this.txtFileDataBase.Location = new System.Drawing.Point(73, 92);
            this.txtFileDataBase.MaxLength = 32767;
            this.txtFileDataBase.Name = "txtFileDataBase";
            this.txtFileDataBase.PasswordChar = '\0';
            this.txtFileDataBase.PromptText = "Escolliu el full de càlcul amb les dades dels clients";
            this.txtFileDataBase.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFileDataBase.SelectedText = "";
            this.txtFileDataBase.SelectionLength = 0;
            this.txtFileDataBase.SelectionStart = 0;
            this.txtFileDataBase.ShortcutsEnabled = true;
            this.txtFileDataBase.ShowButton = true;
            this.txtFileDataBase.Size = new System.Drawing.Size(634, 29);
            this.txtFileDataBase.TabIndex = 36;
            this.toolTip1.SetToolTip(this.txtFileDataBase, "Escolliu el full de càlcul amb les dades dels clients");
            this.txtFileDataBase.UseSelectable = true;
            this.txtFileDataBase.WaterMark = "Escolliu el full de càlcul amb les dades dels clients";
            this.txtFileDataBase.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFileDataBase.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFileDataBase.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtFileDataBase_ButtonClick);
            this.txtFileDataBase.TextChanged += new System.EventHandler(this.txtDirToImport_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(713, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 76);
            this.label1.TabIndex = 35;
            this.label1.Text = "{client}\r\n{fra}\r\n{import}\r\n";
            this.toolTip1.SetToolTip(this.label1, "Comodins per introduïr en el text");
            // 
            // metroTextBoxMailBody
            // 
            this.metroTextBoxMailBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBoxMailBody.CustomButton.Image = null;
            this.metroTextBoxMailBody.CustomButton.Location = new System.Drawing.Point(438, 1);
            this.metroTextBoxMailBody.CustomButton.Name = "";
            this.metroTextBoxMailBody.CustomButton.Size = new System.Drawing.Size(195, 195);
            this.metroTextBoxMailBody.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxMailBody.CustomButton.TabIndex = 1;
            this.metroTextBoxMailBody.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxMailBody.CustomButton.UseSelectable = true;
            this.metroTextBoxMailBody.CustomButton.Visible = false;
            this.metroTextBoxMailBody.Lines = new string[0];
            this.metroTextBoxMailBody.Location = new System.Drawing.Point(73, 131);
            this.metroTextBoxMailBody.MaxLength = 32767;
            this.metroTextBoxMailBody.Multiline = true;
            this.metroTextBoxMailBody.Name = "metroTextBoxMailBody";
            this.metroTextBoxMailBody.PasswordChar = '\0';
            this.metroTextBoxMailBody.PromptText = "Cos del missatge (accepta HTML)";
            this.metroTextBoxMailBody.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxMailBody.SelectedText = "";
            this.metroTextBoxMailBody.SelectionLength = 0;
            this.metroTextBoxMailBody.SelectionStart = 0;
            this.metroTextBoxMailBody.ShortcutsEnabled = true;
            this.metroTextBoxMailBody.Size = new System.Drawing.Size(634, 197);
            this.metroTextBoxMailBody.TabIndex = 34;
            this.toolTip1.SetToolTip(this.metroTextBoxMailBody, "Cos del missatge (accepta HTML)");
            this.metroTextBoxMailBody.UseSelectable = true;
            this.metroTextBoxMailBody.WaterMark = "Cos del missatge (accepta HTML)";
            this.metroTextBoxMailBody.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxMailBody.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(287, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(206, 25);
            this.metroLabel1.TabIndex = 33;
            this.metroLabel1.Text = "Configuracions Prèvies";
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressBar1.HideProgressText = false;
            this.metroProgressBar1.Location = new System.Drawing.Point(127, 83);
            this.metroProgressBar1.Maximum = 3;
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(633, 22);
            this.metroProgressBar1.TabIndex = 41;
            this.metroProgressBar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroProgressBarSpinner
            // 
            this.metroProgressBarSpinner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroProgressBarSpinner.Location = new System.Drawing.Point(305, 163);
            this.metroProgressBarSpinner.Maximum = 100;
            this.metroProgressBarSpinner.Name = "metroProgressBarSpinner";
            this.metroProgressBarSpinner.Size = new System.Drawing.Size(280, 280);
            this.metroProgressBarSpinner.TabIndex = 42;
            this.metroProgressBarSpinner.UseSelectable = true;
            this.metroProgressBarSpinner.Visible = false;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel2.BackgroundImage")));
            this.metroPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroTile3);
            this.metroPanel2.Controls.Add(this.metroTileObreDir);
            this.metroPanel2.Controls.Add(this.metroGridListFra);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(53, 133);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(781, 433);
            this.metroPanel2.TabIndex = 43;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            this.metroPanel2.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(246, 23);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(288, 25);
            this.metroLabel2.TabIndex = 40;
            this.metroLabel2.Text = "Dades detectades als PDF origen";
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile3.Location = new System.Drawing.Point(549, 364);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(160, 46);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile3.TabIndex = 39;
            this.metroTile3.Text = "Següent";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.metroTile3, "Envia correus i veure informe");
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseStyleColors = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTileClose
            // 
            this.metroTileClose.ActiveControl = null;
            this.metroTileClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTileClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroTileClose.Location = new System.Drawing.Point(809, 51);
            this.metroTileClose.Name = "metroTileClose";
            this.metroTileClose.Size = new System.Drawing.Size(58, 54);
            this.metroTileClose.TabIndex = 42;
            this.metroTileClose.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileClose.TileImage")));
            this.metroTileClose.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.metroTileClose, "Finalitza la aplicació");
            this.metroTileClose.UseSelectable = true;
            this.metroTileClose.UseTileImage = true;
            this.metroTileClose.Click += new System.EventHandler(this.metroTileClose_Click);
            // 
            // metroTextBoxMailInform
            // 
            this.metroTextBoxMailInform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.metroTextBoxMailInform.CustomButton.Image = null;
            this.metroTextBoxMailInform.CustomButton.Location = new System.Drawing.Point(177, 2);
            this.metroTextBoxMailInform.CustomButton.Name = "";
            this.metroTextBoxMailInform.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBoxMailInform.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxMailInform.CustomButton.TabIndex = 1;
            this.metroTextBoxMailInform.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxMailInform.CustomButton.UseSelectable = true;
            this.metroTextBoxMailInform.CustomButton.Visible = false;
            this.metroTextBoxMailInform.Lines = new string[0];
            this.metroTextBoxMailInform.Location = new System.Drawing.Point(291, 380);
            this.metroTextBoxMailInform.MaxLength = 32767;
            this.metroTextBoxMailInform.Name = "metroTextBoxMailInform";
            this.metroTextBoxMailInform.PasswordChar = '\0';
            this.metroTextBoxMailInform.PromptText = "Correu on enviar còpia de l\'informe";
            this.metroTextBoxMailInform.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxMailInform.SelectedText = "";
            this.metroTextBoxMailInform.SelectionLength = 0;
            this.metroTextBoxMailInform.SelectionStart = 0;
            this.metroTextBoxMailInform.ShortcutsEnabled = true;
            this.metroTextBoxMailInform.Size = new System.Drawing.Size(199, 24);
            this.metroTextBoxMailInform.TabIndex = 44;
            this.toolTip1.SetToolTip(this.metroTextBoxMailInform, "Correu on enviar còpia de l\'informe");
            this.metroTextBoxMailInform.UseSelectable = true;
            this.metroTextBoxMailInform.WaterMark = "Correu on enviar còpia de l\'informe";
            this.metroTextBoxMailInform.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxMailInform.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroTile5.Location = new System.Drawing.Point(549, 364);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(160, 46);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile5.TabIndex = 45;
            this.metroTile5.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile5.TileImage")));
            this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.metroTile5, "Envia informe");
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseTileImage = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // txtInforme
            // 
            this.txtInforme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtInforme.CustomButton.Image = null;
            this.txtInforme.CustomButton.Location = new System.Drawing.Point(332, 2);
            this.txtInforme.CustomButton.Name = "";
            this.txtInforme.CustomButton.Size = new System.Drawing.Size(299, 299);
            this.txtInforme.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInforme.CustomButton.TabIndex = 1;
            this.txtInforme.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInforme.CustomButton.UseSelectable = true;
            this.txtInforme.CustomButton.Visible = false;
            this.txtInforme.Lines = new string[0];
            this.txtInforme.Location = new System.Drawing.Point(73, 52);
            this.txtInforme.MaxLength = 32767;
            this.txtInforme.Multiline = true;
            this.txtInforme.Name = "txtInforme";
            this.txtInforme.PasswordChar = '\0';
            this.txtInforme.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInforme.SelectedText = "";
            this.txtInforme.SelectionLength = 0;
            this.txtInforme.SelectionStart = 0;
            this.txtInforme.ShortcutsEnabled = true;
            this.txtInforme.Size = new System.Drawing.Size(634, 304);
            this.txtInforme.TabIndex = 46;
            this.toolTip1.SetToolTip(this.txtInforme, "Informe de l\'enviament de factures");
            this.txtInforme.UseSelectable = true;
            this.txtInforme.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInforme.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTileHelp
            // 
            this.metroTileHelp.ActiveControl = null;
            this.metroTileHelp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroTileHelp.Location = new System.Drawing.Point(23, 51);
            this.metroTileHelp.Name = "metroTileHelp";
            this.metroTileHelp.Size = new System.Drawing.Size(58, 54);
            this.metroTileHelp.TabIndex = 50;
            this.metroTileHelp.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileHelp.TileImage")));
            this.metroTileHelp.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.metroTileHelp, "Finalitza la aplicació");
            this.metroTileHelp.UseSelectable = true;
            this.metroTileHelp.UseTileImage = true;
            this.metroTileHelp.Visible = false;
            this.metroTileHelp.Click += new System.EventHandler(this.metroTileHelp_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel3.BackgroundImage")));
            this.metroPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroPanel3.Controls.Add(this.txtInforme);
            this.metroPanel3.Controls.Add(this.metroTile5);
            this.metroPanel3.Controls.Add(this.metroTextBoxMailInform);
            this.metroPanel3.Controls.Add(this.metroLabel6);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(53, 133);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(781, 433);
            this.metroPanel3.TabIndex = 45;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            this.metroPanel3.Visible = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(295, 14);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(191, 25);
            this.metroLabel6.TabIndex = 41;
            this.metroLabel6.Text = "Informe d\'enviament";
            // 
            // metroLabelInfoProcess
            // 
            this.metroLabelInfoProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabelInfoProcess.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelInfoProcess.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelInfoProcess.Location = new System.Drawing.Point(127, 108);
            this.metroLabelInfoProcess.Name = "metroLabelInfoProcess";
            this.metroLabelInfoProcess.Size = new System.Drawing.Size(633, 25);
            this.metroLabelInfoProcess.TabIndex = 46;
            this.metroLabelInfoProcess.Text = "Generant factures individuals ....";
            this.metroLabelInfoProcess.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabelInfoProcess.Visible = false;
            // 
            // metroLinkWeb
            // 
            this.metroLinkWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLinkWeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLinkWeb.Location = new System.Drawing.Point(563, 572);
            this.metroLinkWeb.Name = "metroLinkWeb";
            this.metroLinkWeb.Size = new System.Drawing.Size(138, 23);
            this.metroLinkWeb.TabIndex = 47;
            this.metroLinkWeb.Text = "www.MSC-Soft.com";
            this.metroLinkWeb.UseSelectable = true;
            this.metroLinkWeb.Click += new System.EventHandler(this.metroLinkWeb_Click);
            // 
            // metroLinkMail
            // 
            this.metroLinkMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLinkMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLinkMail.Location = new System.Drawing.Point(697, 572);
            this.metroLinkMail.Name = "metroLinkMail";
            this.metroLinkMail.Size = new System.Drawing.Size(65, 23);
            this.metroLinkMail.TabIndex = 48;
            this.metroLinkMail.Text = "Contacte";
            this.metroLinkMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLinkMail.UseSelectable = true;
            this.metroLinkMail.Click += new System.EventHandler(this.metroLinkMail_Click);
            // 
            // metroLinkVersion
            // 
            this.metroLinkVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLinkVersion.Location = new System.Drawing.Point(126, 572);
            this.metroLinkVersion.Name = "metroLinkVersion";
            this.metroLinkVersion.Size = new System.Drawing.Size(172, 23);
            this.metroLinkVersion.TabIndex = 49;
            this.metroLinkVersion.Text = "Versió: 1.0.0";
            this.metroLinkVersion.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroLinkVersion.UseSelectable = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.metroTileClose;
            this.ClientSize = new System.Drawing.Size(890, 606);
            this.Controls.Add(this.metroTileHelp);
            this.Controls.Add(this.metroLinkVersion);
            this.Controls.Add(this.metroLinkMail);
            this.Controls.Add(this.metroLinkWeb);
            this.Controls.Add(this.metroLabelInfoProcess);
            this.Controls.Add(this.metroProgressBarSpinner);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.metroTileClose);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Enviador de factures per e-mail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridListFra)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtDirToImport;
        private MetroFramework.Controls.MetroGrid metroGridListFra;
        private MetroFramework.Controls.MetroTile metroTileObreDir;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxMailBody;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroToggle chk_all_steps;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTextBox txtFileDataBase;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressBarSpinner;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private System.Windows.Forms.ToolTip toolTip1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroTile metroTileClose;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtInforme;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTextBox metroTextBoxMailInform;
        private MetroFramework.Controls.MetroTextBox metroTextBoxMailSMTP;
        private MetroFramework.Controls.MetroTextBox metroTextBoxMailPsw;
        private MetroFramework.Controls.MetroTextBox metroTextBoxMailRemitent;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fra;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_comptador;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_import;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pdf;
        private System.Windows.Forms.DataGridViewButtonColumn col_open_pdf;
        private MetroFramework.Controls.MetroTextBox metroTextBoxMailPort;
        private MetroFramework.Controls.MetroLabel metroLabelInfoProcess;
        private MetroFramework.Controls.MetroLink metroLinkWeb;
        private MetroFramework.Controls.MetroLink metroLinkMail;
        private MetroFramework.Controls.MetroLink metroLinkVersion;
        private MetroFramework.Controls.MetroTile metroTileHelp;
    }
}

