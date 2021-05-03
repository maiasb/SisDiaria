namespace DIÁRIAS_DEFINITIVO
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.lbnome = new System.Windows.Forms.Label();
            this.lbmat = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtmat = new System.Windows.Forms.TextBox();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.lbcargo = new System.Windows.Forms.Label();
            this.cbolot = new System.Windows.Forms.ComboBox();
            this.lblot = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.adcdiaria = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbchegada = new System.Windows.Forms.Label();
            this.lbsaida = new System.Windows.Forms.Label();
            this.cbosaidav = new System.Windows.Forms.ComboBox();
            this.txthorac = new System.Windows.Forms.MaskedTextBox();
            this.lbhorac = new System.Windows.Forms.Label();
            this.txthoras = new System.Windows.Forms.MaskedTextBox();
            this.cbochegadav = new System.Windows.Forms.ComboBox();
            this.lbhoras = new System.Windows.Forms.Label();
            this.txtoutros = new System.Windows.Forms.TextBox();
            this.lboutros = new System.Windows.Forms.Label();
            this.lbtipo = new System.Windows.Forms.Label();
            this.rbr = new System.Windows.Forms.RadioButton();
            this.rbf = new System.Windows.Forms.RadioButton();
            this.rba = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtobj = new System.Windows.Forms.TextBox();
            this.lbobj = new System.Windows.Forms.Label();
            this.lbcodv = new System.Windows.Forms.Label();
            this.txtcodv = new System.Windows.Forms.TextBox();
            this.cviajem = new System.Windows.Forms.Button();
            this.limparv = new System.Windows.Forms.Button();
            this.voltarv = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbdatas = new System.Windows.Forms.Label();
            this.lbdatac = new System.Windows.Forms.Label();
            this.txtdatas = new System.Windows.Forms.MaskedTextBox();
            this.txtdatac = new System.Windows.Forms.MaskedTextBox();
            this.avancar = new System.Windows.Forms.Button();
            this.voltarv2 = new System.Windows.Forms.Button();
            this.limparv2 = new System.Windows.Forms.Button();
            this.lbconta = new System.Windows.Forms.Label();
            this.lbvalord = new System.Windows.Forms.Label();
            this.txtvalord = new System.Windows.Forms.MaskedTextBox();
            this.cboconta = new System.Windows.Forms.ComboBox();
            this.adcbanco = new System.Windows.Forms.Button();
            this.txtbanco = new System.Windows.Forms.TextBox();
            this.lbbanco = new System.Windows.Forms.Label();
            this.lbconta2 = new System.Windows.Forms.Label();
            this.txtconta = new System.Windows.Forms.TextBox();
            this.ccbancaria = new System.Windows.Forms.Button();
            this.limparcb = new System.Windows.Forms.Button();
            this.voltarcb = new System.Windows.Forms.Button();
            this.dBDiariasDataSet = new DIÁRIAS_DEFINITIVO.DBDiariasDataSet();
            this.cBANCARIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cBANCARIATableAdapter = new DIÁRIAS_DEFINITIVO.DBDiariasDataSetTableAdapters.CBANCARIATableAdapter();
            this.sERVIDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sERVIDORTableAdapter = new DIÁRIAS_DEFINITIVO.DBDiariasDataSetTableAdapters.SERVIDORTableAdapter();
            this.adcdoc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBDiariasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBANCARIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVIDORBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Location = new System.Drawing.Point(27, 33);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(120, 13);
            this.lbnome.TabIndex = 0;
            this.lbnome.Text = "NOME DO SERVIDOR:";
            // 
            // lbmat
            // 
            this.lbmat.AutoSize = true;
            this.lbmat.Location = new System.Drawing.Point(27, 93);
            this.lbmat.Name = "lbmat";
            this.lbmat.Size = new System.Drawing.Size(72, 13);
            this.lbmat.TabIndex = 1;
            this.lbmat.Text = "MATRÍCULA:";
            // 
            // txtnome
            // 
            this.txtnome.Enabled = false;
            this.txtnome.Location = new System.Drawing.Point(192, 30);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(400, 20);
            this.txtnome.TabIndex = 1;
            // 
            // txtmat
            // 
            this.txtmat.Enabled = false;
            this.txtmat.Location = new System.Drawing.Point(192, 90);
            this.txtmat.Name = "txtmat";
            this.txtmat.Size = new System.Drawing.Size(101, 20);
            this.txtmat.TabIndex = 2;
            // 
            // txtcargo
            // 
            this.txtcargo.Enabled = false;
            this.txtcargo.Location = new System.Drawing.Point(423, 90);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(169, 20);
            this.txtcargo.TabIndex = 3;
            // 
            // lbcargo
            // 
            this.lbcargo.AutoSize = true;
            this.lbcargo.BackColor = System.Drawing.Color.Transparent;
            this.lbcargo.Location = new System.Drawing.Point(347, 93);
            this.lbcargo.Name = "lbcargo";
            this.lbcargo.Size = new System.Drawing.Size(48, 13);
            this.lbcargo.TabIndex = 10;
            this.lbcargo.Text = "CARGO:";
            // 
            // cbolot
            // 
            this.cbolot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbolot.Enabled = false;
            this.cbolot.FormattingEnabled = true;
            this.cbolot.Items.AddRange(new object[] {
            "CRPP II",
            "CRPP III",
            "CRPP IV",
            "CRPP V",
            "NTI"});
            this.cbolot.Location = new System.Drawing.Point(192, 150);
            this.cbolot.Name = "cbolot";
            this.cbolot.Size = new System.Drawing.Size(400, 21);
            this.cbolot.TabIndex = 6;
            // 
            // lblot
            // 
            this.lblot.AutoSize = true;
            this.lblot.Location = new System.Drawing.Point(27, 153);
            this.lblot.Name = "lblot";
            this.lblot.Size = new System.Drawing.Size(60, 13);
            this.lblot.TabIndex = 15;
            this.lblot.Text = "LOTAÇÃO:";
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ok.Enabled = false;
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ok.Location = new System.Drawing.Point(502, 294);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(90, 29);
            this.ok.TabIndex = 6;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // editar
            // 
            this.editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editar.Location = new System.Drawing.Point(350, 294);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(90, 29);
            this.editar.TabIndex = 9;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = false;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Location = new System.Drawing.Point(192, 294);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(90, 29);
            this.delete.TabIndex = 8;
            this.delete.Text = "Excluir";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.voltar.Location = new System.Drawing.Point(30, 294);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(90, 29);
            this.voltar.TabIndex = 7;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // adcdiaria
            // 
            this.adcdiaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.adcdiaria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adcdiaria.Location = new System.Drawing.Point(502, 212);
            this.adcdiaria.Name = "adcdiaria";
            this.adcdiaria.Size = new System.Drawing.Size(90, 29);
            this.adcdiaria.TabIndex = 16;
            this.adcdiaria.Text = "+Diária";
            this.adcdiaria.UseVisualStyleBackColor = false;
            this.adcdiaria.Click += new System.EventHandler(this.adcdiaria_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // lbchegada
            // 
            this.lbchegada.AutoSize = true;
            this.lbchegada.Location = new System.Drawing.Point(27, 221);
            this.lbchegada.Name = "lbchegada";
            this.lbchegada.Size = new System.Drawing.Size(62, 13);
            this.lbchegada.TabIndex = 7;
            this.lbchegada.Text = "CHEGADA:";
            // 
            // lbsaida
            // 
            this.lbsaida.AutoSize = true;
            this.lbsaida.Location = new System.Drawing.Point(27, 155);
            this.lbsaida.Name = "lbsaida";
            this.lbsaida.Size = new System.Drawing.Size(42, 13);
            this.lbsaida.TabIndex = 2;
            this.lbsaida.Text = "SAÍDA:";
            // 
            // cbosaidav
            // 
            this.cbosaidav.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosaidav.FormattingEnabled = true;
            this.cbosaidav.Items.AddRange(new object[] {
            "BELÉM",
            "MARITUBA",
            "SANTA ISABEL",
            "CASTANHAL",
            "SANTARÉM"});
            this.cbosaidav.Location = new System.Drawing.Point(192, 152);
            this.cbosaidav.Name = "cbosaidav";
            this.cbosaidav.Size = new System.Drawing.Size(121, 21);
            this.cbosaidav.TabIndex = 3;
            // 
            // txthorac
            // 
            this.txthorac.Location = new System.Drawing.Point(494, 218);
            this.txthorac.Mask = "00:00";
            this.txthorac.Name = "txthorac";
            this.txthorac.Size = new System.Drawing.Size(98, 20);
            this.txthorac.TabIndex = 6;
            // 
            // lbhorac
            // 
            this.lbhorac.AutoSize = true;
            this.lbhorac.BackColor = System.Drawing.Color.Transparent;
            this.lbhorac.Location = new System.Drawing.Point(491, 202);
            this.lbhorac.Name = "lbhorac";
            this.lbhorac.Size = new System.Drawing.Size(41, 13);
            this.lbhorac.TabIndex = 9;
            this.lbhorac.Text = "HORA:";
            // 
            // txthoras
            // 
            this.txthoras.Location = new System.Drawing.Point(494, 153);
            this.txthoras.Mask = "00:00";
            this.txthoras.Name = "txthoras";
            this.txthoras.Size = new System.Drawing.Size(98, 20);
            this.txthoras.TabIndex = 4;
            // 
            // cbochegadav
            // 
            this.cbochegadav.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbochegadav.FormattingEnabled = true;
            this.cbochegadav.Items.AddRange(new object[] {
            "BELÉM",
            "MARITUBA",
            "SANTA ISABEL",
            "CASTANHAL",
            "SANTARÉM"});
            this.cbochegadav.Location = new System.Drawing.Point(192, 218);
            this.cbochegadav.Name = "cbochegadav";
            this.cbochegadav.Size = new System.Drawing.Size(121, 21);
            this.cbochegadav.TabIndex = 5;
            // 
            // lbhoras
            // 
            this.lbhoras.AutoSize = true;
            this.lbhoras.BackColor = System.Drawing.Color.Transparent;
            this.lbhoras.Location = new System.Drawing.Point(491, 136);
            this.lbhoras.Name = "lbhoras";
            this.lbhoras.Size = new System.Drawing.Size(41, 13);
            this.lbhoras.TabIndex = 8;
            this.lbhoras.Text = "HORA:";
            // 
            // txtoutros
            // 
            this.txtoutros.Location = new System.Drawing.Point(76, 54);
            this.txtoutros.Name = "txtoutros";
            this.txtoutros.Size = new System.Drawing.Size(130, 20);
            this.txtoutros.TabIndex = 10;
            this.txtoutros.TextChanged += new System.EventHandler(this.txtoutros_TextChanged);
            // 
            // lboutros
            // 
            this.lboutros.AutoSize = true;
            this.lboutros.Location = new System.Drawing.Point(3, 57);
            this.lboutros.Name = "lboutros";
            this.lboutros.Size = new System.Drawing.Size(56, 13);
            this.lboutros.TabIndex = 9;
            this.lboutros.Text = "OUTROS:";
            // 
            // lbtipo
            // 
            this.lbtipo.AutoSize = true;
            this.lbtipo.BackColor = System.Drawing.Color.Transparent;
            this.lbtipo.Location = new System.Drawing.Point(383, 128);
            this.lbtipo.Name = "lbtipo";
            this.lbtipo.Size = new System.Drawing.Size(115, 13);
            this.lbtipo.TabIndex = 8;
            this.lbtipo.Text = "TIPO DE PASSAGEM:";
            // 
            // rbr
            // 
            this.rbr.AutoSize = true;
            this.rbr.Location = new System.Drawing.Point(58, 4);
            this.rbr.Name = "rbr";
            this.rbr.Size = new System.Drawing.Size(76, 17);
            this.rbr.TabIndex = 2;
            this.rbr.TabStop = true;
            this.rbr.Text = "Rodoviária";
            this.rbr.UseVisualStyleBackColor = true;
            this.rbr.CheckedChanged += new System.EventHandler(this.rbr_CheckedChanged);
            // 
            // rbf
            // 
            this.rbf.AutoSize = true;
            this.rbf.Location = new System.Drawing.Point(140, 4);
            this.rbf.Name = "rbf";
            this.rbf.Size = new System.Drawing.Size(55, 17);
            this.rbf.TabIndex = 1;
            this.rbf.TabStop = true;
            this.rbf.Text = "Fluvial";
            this.rbf.UseVisualStyleBackColor = true;
            this.rbf.CheckedChanged += new System.EventHandler(this.rbf_CheckedChanged);
            // 
            // rba
            // 
            this.rba.AutoSize = true;
            this.rba.Location = new System.Drawing.Point(3, 3);
            this.rba.Name = "rba";
            this.rba.Size = new System.Drawing.Size(53, 17);
            this.rba.TabIndex = 0;
            this.rba.TabStop = true;
            this.rba.Text = "Aérea";
            this.rba.UseVisualStyleBackColor = true;
            this.rba.CheckedChanged += new System.EventHandler(this.rba_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 0;
            // 
            // txtobj
            // 
            this.txtobj.Location = new System.Drawing.Point(30, 226);
            this.txtobj.Multiline = true;
            this.txtobj.Name = "txtobj";
            this.txtobj.Size = new System.Drawing.Size(562, 53);
            this.txtobj.TabIndex = 19;
            // 
            // lbobj
            // 
            this.lbobj.AutoSize = true;
            this.lbobj.Location = new System.Drawing.Point(27, 210);
            this.lbobj.Name = "lbobj";
            this.lbobj.Size = new System.Drawing.Size(121, 13);
            this.lbobj.TabIndex = 18;
            this.lbobj.Text = "OBJETIVO DA VIAJEM:";
            // 
            // lbcodv
            // 
            this.lbcodv.AutoSize = true;
            this.lbcodv.BackColor = System.Drawing.Color.Transparent;
            this.lbcodv.Location = new System.Drawing.Point(344, 93);
            this.lbcodv.Name = "lbcodv";
            this.lbcodv.Size = new System.Drawing.Size(74, 13);
            this.lbcodv.TabIndex = 21;
            this.lbcodv.Text = "COD VIAJEM:";
            // 
            // txtcodv
            // 
            this.txtcodv.Location = new System.Drawing.Point(448, 90);
            this.txtcodv.Name = "txtcodv";
            this.txtcodv.Size = new System.Drawing.Size(144, 20);
            this.txtcodv.TabIndex = 22;
            // 
            // cviajem
            // 
            this.cviajem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cviajem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cviajem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cviajem.Location = new System.Drawing.Point(502, 294);
            this.cviajem.Name = "cviajem";
            this.cviajem.Size = new System.Drawing.Size(90, 29);
            this.cviajem.TabIndex = 23;
            this.cviajem.Tag = "";
            this.cviajem.Text = "Cadastrar";
            this.cviajem.UseVisualStyleBackColor = false;
            this.cviajem.Click += new System.EventHandler(this.cviajem_Click);
            // 
            // limparv
            // 
            this.limparv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.limparv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.limparv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.limparv.Location = new System.Drawing.Point(268, 294);
            this.limparv.Name = "limparv";
            this.limparv.Size = new System.Drawing.Size(90, 29);
            this.limparv.TabIndex = 24;
            this.limparv.Tag = "";
            this.limparv.Text = "Limpar";
            this.limparv.UseVisualStyleBackColor = false;
            this.limparv.Click += new System.EventHandler(this.limparv_Click);
            // 
            // voltarv
            // 
            this.voltarv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.voltarv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.voltarv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.voltarv.Location = new System.Drawing.Point(30, 294);
            this.voltarv.Name = "voltarv";
            this.voltarv.Size = new System.Drawing.Size(90, 29);
            this.voltarv.TabIndex = 25;
            this.voltarv.Tag = "";
            this.voltarv.Text = "Voltar";
            this.voltarv.UseVisualStyleBackColor = false;
            this.voltarv.Click += new System.EventHandler(this.voltarv_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel.Location = new System.Drawing.Point(350, 294);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(90, 29);
            this.cancel.TabIndex = 17;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rba);
            this.panel1.Controls.Add(this.txtoutros);
            this.panel1.Controls.Add(this.rbf);
            this.panel1.Controls.Add(this.lboutros);
            this.panel1.Controls.Add(this.rbr);
            this.panel1.Location = new System.Drawing.Point(386, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 79);
            this.panel1.TabIndex = 26;
            // 
            // lbdatas
            // 
            this.lbdatas.AutoSize = true;
            this.lbdatas.BackColor = System.Drawing.Color.Transparent;
            this.lbdatas.Location = new System.Drawing.Point(344, 136);
            this.lbdatas.Name = "lbdatas";
            this.lbdatas.Size = new System.Drawing.Size(39, 13);
            this.lbdatas.TabIndex = 27;
            this.lbdatas.Text = "DATA:";
            // 
            // lbdatac
            // 
            this.lbdatac.AutoSize = true;
            this.lbdatac.BackColor = System.Drawing.Color.Transparent;
            this.lbdatac.Location = new System.Drawing.Point(344, 202);
            this.lbdatac.Name = "lbdatac";
            this.lbdatac.Size = new System.Drawing.Size(39, 13);
            this.lbdatac.TabIndex = 28;
            this.lbdatac.Text = "DATA:";
            // 
            // txtdatas
            // 
            this.txtdatas.Location = new System.Drawing.Point(347, 152);
            this.txtdatas.Mask = "00/00/0000";
            this.txtdatas.Name = "txtdatas";
            this.txtdatas.Size = new System.Drawing.Size(98, 20);
            this.txtdatas.TabIndex = 29;
            // 
            // txtdatac
            // 
            this.txtdatac.Location = new System.Drawing.Point(347, 218);
            this.txtdatac.Mask = "00/00/0000";
            this.txtdatac.Name = "txtdatac";
            this.txtdatac.Size = new System.Drawing.Size(98, 20);
            this.txtdatac.TabIndex = 30;
            // 
            // avancar
            // 
            this.avancar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.avancar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.avancar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.avancar.Location = new System.Drawing.Point(502, 294);
            this.avancar.Name = "avancar";
            this.avancar.Size = new System.Drawing.Size(90, 29);
            this.avancar.TabIndex = 31;
            this.avancar.Tag = "";
            this.avancar.Text = "Avançar";
            this.avancar.UseVisualStyleBackColor = false;
            this.avancar.Click += new System.EventHandler(this.avancar_Click);
            // 
            // voltarv2
            // 
            this.voltarv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.voltarv2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.voltarv2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.voltarv2.Location = new System.Drawing.Point(30, 294);
            this.voltarv2.Name = "voltarv2";
            this.voltarv2.Size = new System.Drawing.Size(90, 29);
            this.voltarv2.TabIndex = 32;
            this.voltarv2.Tag = "";
            this.voltarv2.Text = "Voltar";
            this.voltarv2.UseVisualStyleBackColor = false;
            this.voltarv2.Click += new System.EventHandler(this.voltarv2_Click);
            // 
            // limparv2
            // 
            this.limparv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.limparv2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.limparv2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.limparv2.Location = new System.Drawing.Point(268, 294);
            this.limparv2.Name = "limparv2";
            this.limparv2.Size = new System.Drawing.Size(90, 29);
            this.limparv2.TabIndex = 32;
            this.limparv2.Tag = "";
            this.limparv2.Text = "Limpar";
            this.limparv2.UseVisualStyleBackColor = false;
            this.limparv2.Click += new System.EventHandler(this.limparv2_Click);
            // 
            // lbconta
            // 
            this.lbconta.AutoSize = true;
            this.lbconta.BackColor = System.Drawing.Color.Transparent;
            this.lbconta.Location = new System.Drawing.Point(383, 93);
            this.lbconta.Name = "lbconta";
            this.lbconta.Size = new System.Drawing.Size(47, 13);
            this.lbconta.TabIndex = 33;
            this.lbconta.Text = "CONTA:";
            // 
            // lbvalord
            // 
            this.lbvalord.AutoSize = true;
            this.lbvalord.Location = new System.Drawing.Point(27, 149);
            this.lbvalord.Name = "lbvalord";
            this.lbvalord.Size = new System.Drawing.Size(85, 13);
            this.lbvalord.TabIndex = 35;
            this.lbvalord.Text = "VALOR DIÁRIA:";
            // 
            // txtvalord
            // 
            this.txtvalord.Location = new System.Drawing.Point(192, 146);
            this.txtvalord.Mask = "$000.000,00";
            this.txtvalord.Name = "txtvalord";
            this.txtvalord.Size = new System.Drawing.Size(101, 20);
            this.txtvalord.TabIndex = 36;
            this.txtvalord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num);
            // 
            // cboconta
            // 
            this.cboconta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboconta.FormattingEnabled = true;
            this.cboconta.Location = new System.Drawing.Point(444, 90);
            this.cboconta.Name = "cboconta";
            this.cboconta.Size = new System.Drawing.Size(148, 21);
            this.cboconta.TabIndex = 37;
            // 
            // adcbanco
            // 
            this.adcbanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.adcbanco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adcbanco.Location = new System.Drawing.Point(350, 212);
            this.adcbanco.Name = "adcbanco";
            this.adcbanco.Size = new System.Drawing.Size(90, 29);
            this.adcbanco.TabIndex = 17;
            this.adcbanco.Text = "+Conta";
            this.adcbanco.UseVisualStyleBackColor = false;
            this.adcbanco.Click += new System.EventHandler(this.adcbanco_Click);
            // 
            // txtbanco
            // 
            this.txtbanco.Location = new System.Drawing.Point(192, 149);
            this.txtbanco.Name = "txtbanco";
            this.txtbanco.Size = new System.Drawing.Size(115, 20);
            this.txtbanco.TabIndex = 16;
            // 
            // lbbanco
            // 
            this.lbbanco.AutoSize = true;
            this.lbbanco.Location = new System.Drawing.Point(27, 152);
            this.lbbanco.Name = "lbbanco";
            this.lbbanco.Size = new System.Drawing.Size(47, 13);
            this.lbbanco.TabIndex = 17;
            this.lbbanco.Text = "BANCO:";
            // 
            // lbconta2
            // 
            this.lbconta2.AutoSize = true;
            this.lbconta2.BackColor = System.Drawing.Color.Transparent;
            this.lbconta2.Location = new System.Drawing.Point(27, 210);
            this.lbconta2.Name = "lbconta2";
            this.lbconta2.Size = new System.Drawing.Size(47, 13);
            this.lbconta2.TabIndex = 18;
            this.lbconta2.Text = "CONTA:";
            // 
            // txtconta
            // 
            this.txtconta.Location = new System.Drawing.Point(192, 207);
            this.txtconta.Name = "txtconta";
            this.txtconta.Size = new System.Drawing.Size(115, 20);
            this.txtconta.TabIndex = 19;
            // 
            // ccbancaria
            // 
            this.ccbancaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ccbancaria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ccbancaria.Location = new System.Drawing.Point(502, 294);
            this.ccbancaria.Name = "ccbancaria";
            this.ccbancaria.Size = new System.Drawing.Size(90, 29);
            this.ccbancaria.TabIndex = 20;
            this.ccbancaria.Text = "Cadastrar";
            this.ccbancaria.UseVisualStyleBackColor = false;
            this.ccbancaria.Click += new System.EventHandler(this.ccbancaria_Click);
            // 
            // limparcb
            // 
            this.limparcb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.limparcb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.limparcb.Location = new System.Drawing.Point(280, 294);
            this.limparcb.Name = "limparcb";
            this.limparcb.Size = new System.Drawing.Size(90, 29);
            this.limparcb.TabIndex = 21;
            this.limparcb.Text = "Limpar";
            this.limparcb.UseVisualStyleBackColor = false;
            this.limparcb.Click += new System.EventHandler(this.limparcb_Click);
            // 
            // voltarcb
            // 
            this.voltarcb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.voltarcb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.voltarcb.Location = new System.Drawing.Point(30, 294);
            this.voltarcb.Name = "voltarcb";
            this.voltarcb.Size = new System.Drawing.Size(90, 29);
            this.voltarcb.TabIndex = 22;
            this.voltarcb.Text = "Voltar";
            this.voltarcb.UseVisualStyleBackColor = false;
            this.voltarcb.Click += new System.EventHandler(this.voltarcb_Click);
            // 
            // dBDiariasDataSet
            // 
            this.dBDiariasDataSet.DataSetName = "DBDiariasDataSet";
            this.dBDiariasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cBANCARIABindingSource
            // 
            this.cBANCARIABindingSource.DataMember = "CBANCARIA";
            this.cBANCARIABindingSource.DataSource = this.dBDiariasDataSet;
            // 
            // cBANCARIATableAdapter
            // 
            this.cBANCARIATableAdapter.ClearBeforeFill = true;
            // 
            // sERVIDORBindingSource
            // 
            this.sERVIDORBindingSource.DataMember = "SERVIDOR";
            this.sERVIDORBindingSource.DataSource = this.dBDiariasDataSet;
            // 
            // sERVIDORTableAdapter
            // 
            this.sERVIDORTableAdapter.ClearBeforeFill = true;
            // 
            // adcdoc
            // 
            this.adcdoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.adcdoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adcdoc.Location = new System.Drawing.Point(192, 212);
            this.adcdoc.Name = "adcdoc";
            this.adcdoc.Size = new System.Drawing.Size(90, 29);
            this.adcdoc.TabIndex = 18;
            this.adcdoc.Text = "+Documento";
            this.adcdoc.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::DIÁRIAS_DEFINITIVO.Properties.Resources.logo_seap_mais_transparente_sem_fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(640, 347);
            this.Controls.Add(this.adcdoc);
            this.Controls.Add(this.adcdiaria);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.lblot);
            this.Controls.Add(this.cbolot);
            this.Controls.Add(this.lbcargo);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.txtmat);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lbmat);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.adcbanco);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SERVIDOR";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBDiariasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBANCARIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVIDORBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.Label lbmat;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtmat;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.Label lbcargo;
        private System.Windows.Forms.ComboBox cbolot;
        private System.Windows.Forms.Label lblot;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button adcdiaria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbsaida;
        private System.Windows.Forms.Label lbchegada;
        private System.Windows.Forms.ComboBox cbosaidav;
        private System.Windows.Forms.MaskedTextBox txthorac;
        private System.Windows.Forms.Label lbhorac;
        private System.Windows.Forms.MaskedTextBox txthoras;
        private System.Windows.Forms.ComboBox cbochegadav;
        private System.Windows.Forms.Label lbhoras;
        private System.Windows.Forms.TextBox txtoutros;
        private System.Windows.Forms.Label lboutros;
        private System.Windows.Forms.Label lbtipo;
        private System.Windows.Forms.RadioButton rbr;
        private System.Windows.Forms.RadioButton rbf;
        private System.Windows.Forms.RadioButton rba;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtobj;
        private System.Windows.Forms.Label lbobj;
        private System.Windows.Forms.Label lbcodv;
        private System.Windows.Forms.TextBox txtcodv;
        private System.Windows.Forms.Button cviajem;
        private System.Windows.Forms.Button limparv;
        private System.Windows.Forms.Button voltarv;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbdatas;
        private System.Windows.Forms.Label lbdatac;
        private System.Windows.Forms.MaskedTextBox txtdatas;
        private System.Windows.Forms.MaskedTextBox txtdatac;
        private System.Windows.Forms.Button avancar;
        private System.Windows.Forms.Button voltarv2;
        private System.Windows.Forms.Button limparv2;
        private System.Windows.Forms.Label lbconta;
        private System.Windows.Forms.Label lbvalord;
        private System.Windows.Forms.MaskedTextBox txtvalord;
        private System.Windows.Forms.ComboBox cboconta;
        private System.Windows.Forms.Button adcbanco;
        private System.Windows.Forms.TextBox txtbanco;
        private System.Windows.Forms.Label lbbanco;
        private System.Windows.Forms.Label lbconta2;
        private System.Windows.Forms.TextBox txtconta;
        private System.Windows.Forms.Button ccbancaria;
        private System.Windows.Forms.Button limparcb;
        private System.Windows.Forms.Button voltarcb;
        private DBDiariasDataSet dBDiariasDataSet;
        private System.Windows.Forms.BindingSource cBANCARIABindingSource;
        private DBDiariasDataSetTableAdapters.CBANCARIATableAdapter cBANCARIATableAdapter;
        private System.Windows.Forms.BindingSource sERVIDORBindingSource;
        private DBDiariasDataSetTableAdapters.SERVIDORTableAdapter sERVIDORTableAdapter;
        private System.Windows.Forms.Button adcdoc;
    }
}