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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDebit = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAllAccounts = new System.Windows.Forms.Button();
            this.btnUnicAccount = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 264);
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::LDV_DESIGNE_BZ.Properties.Resources.Home480;
            this.pictureBox1.Location = new System.Drawing.Point(464, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 405);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(898, 563);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

