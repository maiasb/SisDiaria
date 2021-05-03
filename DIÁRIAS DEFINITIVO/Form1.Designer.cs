namespace DIÁRIAS_DEFINITIVO
{
    partial class Form1
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
            this.btcadservidor = new System.Windows.Forms.Button();
            this.btbuscaservidor = new System.Windows.Forms.Button();
            this.btbuscadiaria = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lbnome = new System.Windows.Forms.Label();
            this.txtmat = new System.Windows.Forms.TextBox();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.cbolot = new System.Windows.Forms.ComboBox();
            this.lbmat = new System.Windows.Forms.Label();
            this.lbcargo = new System.Windows.Forms.Label();
            this.lbcpf = new System.Windows.Forms.Label();
            this.lblot = new System.Windows.Forms.Label();
            this.cadastrarcs = new System.Windows.Forms.Button();
            this.Limparcs = new System.Windows.Forms.Button();
            this.Voltarcs = new System.Windows.Forms.Button();
            this.buscars = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.selservidor = new System.Windows.Forms.Button();
            this.limparbs = new System.Windows.Forms.Button();
            this.txtcodv = new System.Windows.Forms.TextBox();
            this.lbcodv = new System.Windows.Forms.Label();
            this.buscard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btcadservidor
            // 
            this.btcadservidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btcadservidor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btcadservidor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btcadservidor.Location = new System.Drawing.Point(32, 63);
            this.btcadservidor.Name = "btcadservidor";
            this.btcadservidor.Size = new System.Drawing.Size(160, 34);
            this.btcadservidor.TabIndex = 0;
            this.btcadservidor.Tag = "";
            this.btcadservidor.Text = "Cadastrar Servidor";
            this.btcadservidor.UseVisualStyleBackColor = false;
            this.btcadservidor.Click += new System.EventHandler(this.mcadserv_Click);
            // 
            // btbuscaservidor
            // 
            this.btbuscaservidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btbuscaservidor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btbuscaservidor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btbuscaservidor.Location = new System.Drawing.Point(32, 159);
            this.btbuscaservidor.Name = "btbuscaservidor";
            this.btbuscaservidor.Size = new System.Drawing.Size(160, 34);
            this.btbuscaservidor.TabIndex = 1;
            this.btbuscaservidor.Text = "Pesquisar Servidor";
            this.btbuscaservidor.UseVisualStyleBackColor = false;
            this.btbuscaservidor.Click += new System.EventHandler(this.mbuscas_Click);
            // 
            // btbuscadiaria
            // 
            this.btbuscadiaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btbuscadiaria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btbuscadiaria.Location = new System.Drawing.Point(32, 254);
            this.btbuscadiaria.Name = "btbuscadiaria";
            this.btbuscadiaria.Size = new System.Drawing.Size(160, 34);
            this.btbuscadiaria.TabIndex = 5;
            this.btbuscadiaria.Text = "Diárias";
            this.btbuscadiaria.UseVisualStyleBackColor = false;
            this.btbuscadiaria.Click += new System.EventHandler(this.btbuscadiaria_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(192, 30);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(400, 20);
            this.txtnome.TabIndex = 0;
            this.txtnome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cchar);
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.BackColor = System.Drawing.Color.Transparent;
            this.lbnome.Location = new System.Drawing.Point(27, 33);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(120, 13);
            this.lbnome.TabIndex = 1;
            this.lbnome.Text = "NOME DO SERVIDOR:";
            // 
            // txtmat
            // 
            this.txtmat.Location = new System.Drawing.Point(192, 90);
            this.txtmat.Name = "txtmat";
            this.txtmat.Size = new System.Drawing.Size(101, 20);
            this.txtmat.TabIndex = 2;
            this.txtmat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num);
            // 
            // txtcargo
            // 
            this.txtcargo.Location = new System.Drawing.Point(423, 90);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(169, 20);
            this.txtcargo.TabIndex = 3;
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(403, 150);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(169, 20);
            this.txtcpf.TabIndex = 5;
            // 
            // cbolot
            // 
            this.cbolot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // lbmat
            // 
            this.lbmat.AutoSize = true;
            this.lbmat.BackColor = System.Drawing.Color.Transparent;
            this.lbmat.Location = new System.Drawing.Point(27, 93);
            this.lbmat.Name = "lbmat";
            this.lbmat.Size = new System.Drawing.Size(72, 13);
            this.lbmat.TabIndex = 7;
            this.lbmat.Text = "MATRÍCULA:";
            // 
            // lbcargo
            // 
            this.lbcargo.AutoSize = true;
            this.lbcargo.BackColor = System.Drawing.Color.Transparent;
            this.lbcargo.Location = new System.Drawing.Point(347, 93);
            this.lbcargo.Name = "lbcargo";
            this.lbcargo.Size = new System.Drawing.Size(48, 13);
            this.lbcargo.TabIndex = 9;
            this.lbcargo.Text = "CARGO:";
            // 
            // lbcpf
            // 
            this.lbcpf.AutoSize = true;
            this.lbcpf.BackColor = System.Drawing.Color.Transparent;
            this.lbcpf.Location = new System.Drawing.Point(329, 153);
            this.lbcpf.Name = "lbcpf";
            this.lbcpf.Size = new System.Drawing.Size(30, 13);
            this.lbcpf.TabIndex = 10;
            this.lbcpf.Text = "CPF:";
            // 
            // lblot
            // 
            this.lblot.AutoSize = true;
            this.lblot.BackColor = System.Drawing.Color.Transparent;
            this.lblot.Location = new System.Drawing.Point(27, 153);
            this.lblot.Name = "lblot";
            this.lblot.Size = new System.Drawing.Size(60, 13);
            this.lblot.TabIndex = 11;
            this.lblot.Text = "LOTAÇÃO:";
            // 
            // cadastrarcs
            // 
            this.cadastrarcs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cadastrarcs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cadastrarcs.Location = new System.Drawing.Point(502, 294);
            this.cadastrarcs.Name = "cadastrarcs";
            this.cadastrarcs.Size = new System.Drawing.Size(90, 29);
            this.cadastrarcs.TabIndex = 12;
            this.cadastrarcs.Text = "Cadastrar";
            this.cadastrarcs.UseVisualStyleBackColor = true;
            this.cadastrarcs.Click += new System.EventHandler(this.cadastrarcs_Click);
            // 
            // Limparcs
            // 
            this.Limparcs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Limparcs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Limparcs.Location = new System.Drawing.Point(268, 294);
            this.Limparcs.Name = "Limparcs";
            this.Limparcs.Size = new System.Drawing.Size(90, 29);
            this.Limparcs.TabIndex = 13;
            this.Limparcs.Text = "Limpar";
            this.Limparcs.UseVisualStyleBackColor = true;
            this.Limparcs.Click += new System.EventHandler(this.Limparcs_Click);
            // 
            // Voltarcs
            // 
            this.Voltarcs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Voltarcs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Voltarcs.Location = new System.Drawing.Point(30, 294);
            this.Voltarcs.Name = "Voltarcs";
            this.Voltarcs.Size = new System.Drawing.Size(90, 29);
            this.Voltarcs.TabIndex = 14;
            this.Voltarcs.Text = "Voltar";
            this.Voltarcs.UseVisualStyleBackColor = true;
            this.Voltarcs.Click += new System.EventHandler(this.Voltarcs_Click);
            // 
            // buscars
            // 
            this.buscars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buscars.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buscars.Location = new System.Drawing.Point(502, 81);
            this.buscars.Name = "buscars";
            this.buscars.Size = new System.Drawing.Size(90, 29);
            this.buscars.TabIndex = 15;
            this.buscars.Text = "Buscar";
            this.buscars.UseVisualStyleBackColor = true;
            this.buscars.Click += new System.EventHandler(this.buscars_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 128);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(562, 147);
            this.listBox1.TabIndex = 0;
            // 
            // selservidor
            // 
            this.selservidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.selservidor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selservidor.Location = new System.Drawing.Point(502, 294);
            this.selservidor.Name = "selservidor";
            this.selservidor.Size = new System.Drawing.Size(90, 29);
            this.selservidor.TabIndex = 16;
            this.selservidor.Text = "Selecionar";
            this.selservidor.UseVisualStyleBackColor = true;
            this.selservidor.Click += new System.EventHandler(this.selservidor_Click);
            // 
            // limparbs
            // 
            this.limparbs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.limparbs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.limparbs.Location = new System.Drawing.Point(268, 294);
            this.limparbs.Name = "limparbs";
            this.limparbs.Size = new System.Drawing.Size(90, 29);
            this.limparbs.TabIndex = 17;
            this.limparbs.Text = "Limpar";
            this.limparbs.UseVisualStyleBackColor = true;
            this.limparbs.Click += new System.EventHandler(this.limparbs_Click);
            // 
            // txtcodv
            // 
            this.txtcodv.Location = new System.Drawing.Point(126, 37);
            this.txtcodv.Name = "txtcodv";
            this.txtcodv.Size = new System.Drawing.Size(113, 20);
            this.txtcodv.TabIndex = 15;
            // 
            // lbcodv
            // 
            this.lbcodv.AutoSize = true;
            this.lbcodv.BackColor = System.Drawing.Color.Transparent;
            this.lbcodv.Location = new System.Drawing.Point(29, 40);
            this.lbcodv.Name = "lbcodv";
            this.lbcodv.Size = new System.Drawing.Size(91, 13);
            this.lbcodv.TabIndex = 16;
            this.lbcodv.Text = "CÓDIGO DIÁRIA:";
            // 
            // buscard
            // 
            this.buscard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buscard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buscard.Location = new System.Drawing.Point(502, 294);
            this.buscard.Name = "buscard";
            this.buscard.Size = new System.Drawing.Size(90, 29);
            this.buscard.TabIndex = 17;
            this.buscard.Text = "Buscar";
            this.buscard.UseVisualStyleBackColor = true;
            this.buscard.Click += new System.EventHandler(this.buscard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::DIÁRIAS_DEFINITIVO.Properties.Resources.logo_seap_mais_transparente_sem_fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(640, 347);
            this.Controls.Add(this.btbuscadiaria);
            this.Controls.Add(this.btbuscaservidor);
            this.Controls.Add(this.btcadservidor);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DIÁRIAS SEAP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcadservidor;
        private System.Windows.Forms.Button btbuscaservidor;
        private System.Windows.Forms.Button btbuscadiaria;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.TextBox txtmat;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.ComboBox cbolot;
        private System.Windows.Forms.Label lbmat;
        private System.Windows.Forms.Label lbcargo;
        private System.Windows.Forms.Label lbcpf;
        private System.Windows.Forms.Label lblot;
        private System.Windows.Forms.Button cadastrarcs;
        private System.Windows.Forms.Button Limparcs;
        private System.Windows.Forms.Button Voltarcs;
        private System.Windows.Forms.Button buscars;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button selservidor;
        private System.Windows.Forms.Button limparbs;
        private System.Windows.Forms.TextBox txtcodv;
        private System.Windows.Forms.Label lbcodv;
        private System.Windows.Forms.Button buscard;
    }
}

