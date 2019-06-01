namespace LDV_DESIGNE_BZ
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDebit = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAllAccounts = new System.Windows.Forms.Button();
            this.btnUnicAccount = new System.Windows.Forms.Button();
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumConta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNumConta = new MetroFramework.Controls.MetroComboBox();
            this.lDVBANKACCOUNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lDV_PEDREIRADataSet = new LDV_DESIGNE_BZ.LDV_PEDREIRADataSet();
            this.lDVBANKACCOUNTTableAdapter = new LDV_DESIGNE_BZ.LDV_PEDREIRADataSetTableAdapters.LDVBANKACCOUNTTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumContaNegativo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblValorNegativo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumContaPositivo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblValorDeposito = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lDVBANKACCOUNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDV_PEDREIRADataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDebit);
            this.groupBox1.Controls.Add(this.btnDeposit);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 170);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada / Saída de dinheiro";
            this.metroToolTip1.SetToolTip(this.groupBox1, "Aqui faça o controle total do\r\ndinheiro que entra/sai da(s) sua(s) conta(s).");
            // 
            // btnDebit
            // 
            this.btnDebit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDebit.FlatAppearance.BorderSize = 0;
            this.btnDebit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDebit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebit.Image = global::LDV_DESIGNE_BZ.Properties.Resources.Debit96;
            this.btnDebit.Location = new System.Drawing.Point(182, 29);
            this.btnDebit.Name = "btnDebit";
            this.btnDebit.Size = new System.Drawing.Size(176, 135);
            this.btnDebit.TabIndex = 2;
            this.btnDebit.Text = "Débito";
            this.btnDebit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.metroToolTip1.SetToolTip(this.btnDebit, "Registrar um débito.");
            this.btnDebit.UseVisualStyleBackColor = true;
            this.btnDebit.Click += new System.EventHandler(this.btnDebit_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Image = global::LDV_DESIGNE_BZ.Properties.Resources.Balance96;
            this.btnDeposit.Location = new System.Drawing.Point(6, 29);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(170, 135);
            this.btnDeposit.TabIndex = 1;
            this.btnDeposit.Text = "Depósito";
            this.btnDeposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.metroToolTip1.SetToolTip(this.btnDeposit, "Registrar um depósito.");
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAllAccounts);
            this.groupBox2.Controls.Add(this.btnUnicAccount);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 170);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gerenciamento de conta(s)";
            this.metroToolTip1.SetToolTip(this.groupBox2, "Aqui faça o controle total do\r\ndinheiro que entra/sai da(s) sua(s) conta(s).");
            // 
            // btnAllAccounts
            // 
            this.btnAllAccounts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAllAccounts.FlatAppearance.BorderSize = 0;
            this.btnAllAccounts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAllAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllAccounts.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllAccounts.Image = global::LDV_DESIGNE_BZ.Properties.Resources.Search;
            this.btnAllAccounts.Location = new System.Drawing.Point(182, 29);
            this.btnAllAccounts.Name = "btnAllAccounts";
            this.btnAllAccounts.Size = new System.Drawing.Size(176, 135);
            this.btnAllAccounts.TabIndex = 2;
            this.btnAllAccounts.Text = "Pesquisar conta(s)";
            this.btnAllAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.metroToolTip1.SetToolTip(this.btnAllAccounts, "Click para ver o saldo de \r\ntodas as contas bancárias.");
            this.btnAllAccounts.UseVisualStyleBackColor = true;
            this.btnAllAccounts.Click += new System.EventHandler(this.btnAllAccounts_Click);
            // 
            // btnUnicAccount
            // 
            this.btnUnicAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUnicAccount.FlatAppearance.BorderSize = 0;
            this.btnUnicAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUnicAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnicAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnicAccount.Image = global::LDV_DESIGNE_BZ.Properties.Resources.ConfigSilver;
            this.btnUnicAccount.Location = new System.Drawing.Point(6, 29);
            this.btnUnicAccount.Name = "btnUnicAccount";
            this.btnUnicAccount.Size = new System.Drawing.Size(170, 135);
            this.btnUnicAccount.TabIndex = 1;
            this.btnUnicAccount.Text = "Gerenciar conta(s)";
            this.btnUnicAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.metroToolTip1.SetToolTip(this.btnUnicAccount, "Click para ver o saldo de uma\r\núnica conta bancária.");
            this.btnUnicAccount.UseVisualStyleBackColor = true;
            this.btnUnicAccount.Click += new System.EventHandler(this.btnUnicAccount_Click);
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.AutoSize = true;
            this.lblSaldoTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSaldoTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoTotal.ForeColor = System.Drawing.Color.White;
            this.lblSaldoTotal.Location = new System.Drawing.Point(278, 61);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(0, 38);
            this.lblSaldoTotal.TabIndex = 6;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Image = global::LDV_DESIGNE_BZ.Properties.Resources.atualizar30;
            this.btnAtualizar.Location = new System.Drawing.Point(651, 43);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(180, 51);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar valores";
            this.btnAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.metroToolTip1.SetToolTip(this.btnAtualizar, "Click aqui para atualizar os valores.");
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::LDV_DESIGNE_BZ.Properties.Resources.Home480;
            this.pictureBox1.Location = new System.Drawing.Point(905, 547);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblNumConta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblSaldoTotal);
            this.panel1.Location = new System.Drawing.Point(429, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 111);
            this.panel1.TabIndex = 8;
            // 
            // lblNumConta
            // 
            this.lblNumConta.AutoSize = true;
            this.lblNumConta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumConta.ForeColor = System.Drawing.Color.White;
            this.lblNumConta.Location = new System.Drawing.Point(201, 3);
            this.lblNumConta.Name = "lblNumConta";
            this.lblNumConta.Size = new System.Drawing.Size(0, 28);
            this.lblNumConta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo total da conta:";
            // 
            // cbNumConta
            // 
            this.cbNumConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbNumConta.DataSource = this.lDVBANKACCOUNTBindingSource;
            this.cbNumConta.DisplayMember = "NUMBERACCOUNT";
            this.cbNumConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNumConta.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbNumConta.FormattingEnabled = true;
            this.cbNumConta.ItemHeight = 29;
            this.cbNumConta.Location = new System.Drawing.Point(429, 54);
            this.cbNumConta.Name = "cbNumConta";
            this.cbNumConta.PromptText = "Selecione sua conta...";
            this.cbNumConta.Size = new System.Drawing.Size(216, 35);
            this.cbNumConta.TabIndex = 9;
            this.cbNumConta.UseSelectable = true;
            this.cbNumConta.ValueMember = "NUMBERACCOUNT";
            this.cbNumConta.SelectedIndexChanged += new System.EventHandler(this.cbNumConta_SelectedIndexChanged);
            this.cbNumConta.MouseEnter += new System.EventHandler(this.cbNumConta_MouseEnter);
            // 
            // lDVBANKACCOUNTBindingSource
            // 
            this.lDVBANKACCOUNTBindingSource.DataMember = "LDVBANKACCOUNT";
            this.lDVBANKACCOUNTBindingSource.DataSource = this.lDV_PEDREIRADataSet;
            // 
            // lDV_PEDREIRADataSet
            // 
            this.lDV_PEDREIRADataSet.DataSetName = "LDV_PEDREIRADataSet";
            this.lDV_PEDREIRADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lDVBANKACCOUNTTableAdapter
            // 
            this.lDVBANKACCOUNTTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(228, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "R$";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblNumContaNegativo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblValorNegativo);
            this.panel2.Location = new System.Drawing.Point(429, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 111);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(228, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "R$";
            // 
            // lblNumContaNegativo
            // 
            this.lblNumContaNegativo.AutoSize = true;
            this.lblNumContaNegativo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumContaNegativo.ForeColor = System.Drawing.Color.White;
            this.lblNumContaNegativo.Location = new System.Drawing.Point(247, 3);
            this.lblNumContaNegativo.Name = "lblNumContaNegativo";
            this.lblNumContaNegativo.Size = new System.Drawing.Size(0, 28);
            this.lblNumContaNegativo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total de débito da conta:";
            // 
            // lblValorNegativo
            // 
            this.lblValorNegativo.AutoSize = true;
            this.lblValorNegativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValorNegativo.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorNegativo.ForeColor = System.Drawing.Color.White;
            this.lblValorNegativo.Location = new System.Drawing.Point(278, 61);
            this.lblValorNegativo.Name = "lblValorNegativo";
            this.lblValorNegativo.Size = new System.Drawing.Size(0, 38);
            this.lblValorNegativo.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblNumContaPositivo);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblValorDeposito);
            this.panel3.Location = new System.Drawing.Point(429, 334);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 111);
            this.panel3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(228, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "R$";
            // 
            // lblNumContaPositivo
            // 
            this.lblNumContaPositivo.AutoSize = true;
            this.lblNumContaPositivo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumContaPositivo.ForeColor = System.Drawing.Color.White;
            this.lblNumContaPositivo.Location = new System.Drawing.Point(262, 2);
            this.lblNumContaPositivo.Name = "lblNumContaPositivo";
            this.lblNumContaPositivo.Size = new System.Drawing.Size(0, 28);
            this.lblNumContaPositivo.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total de deposito da conta:";
            // 
            // lblValorDeposito
            // 
            this.lblValorDeposito.AutoSize = true;
            this.lblValorDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValorDeposito.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDeposito.ForeColor = System.Drawing.Color.White;
            this.lblValorDeposito.Location = new System.Drawing.Point(278, 61);
            this.lblValorDeposito.Name = "lblValorDeposito";
            this.lblValorDeposito.Size = new System.Drawing.Size(0, 38);
            this.lblValorDeposito.TabIndex = 6;
            // 
            // frmMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(992, 619);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbNumConta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lDVBANKACCOUNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDV_PEDREIRADataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnDebit;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAllAccounts;
        private System.Windows.Forms.Button btnUnicAccount;
        private System.Windows.Forms.Label lblSaldoTotal;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumConta;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cbNumConta;
        private LDV_PEDREIRADataSet lDV_PEDREIRADataSet;
        private System.Windows.Forms.BindingSource lDVBANKACCOUNTBindingSource;
        private LDV_PEDREIRADataSetTableAdapters.LDVBANKACCOUNTTableAdapter lDVBANKACCOUNTTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumContaNegativo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblValorNegativo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumContaPositivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblValorDeposito;
    }
}

