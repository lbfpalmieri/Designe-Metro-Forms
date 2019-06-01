namespace LDV_DESIGNE_BZ.Forms
{
    partial class frmDeposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeposit));
            this.txtSetValue = new System.Windows.Forms.TextBox();
            this.lblPositive = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNumAccount = new MetroFramework.Controls.MetroComboBox();
            this.lDVBANKACCOUNTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lDV_PEDREIRADataSet = new LDV_DESIGNE_BZ.LDV_PEDREIRADataSet();
            this.lDVBANKACCOUNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtDesc = new MetroFramework.Controls.MetroTextBox();
            this.txtData = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtValue = new MetroFramework.Controls.MetroTextBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.lDVBANKACCOUNTTableAdapter = new LDV_DESIGNE_BZ.LDV_PEDREIRADataSetTableAdapters.LDVBANKACCOUNTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lDVBANKACCOUNTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDV_PEDREIRADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDVBANKACCOUNTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSetValue
            // 
            this.txtSetValue.Location = new System.Drawing.Point(508, 10);
            this.txtSetValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtSetValue.Name = "txtSetValue";
            this.txtSetValue.Size = new System.Drawing.Size(56, 22);
            this.txtSetValue.TabIndex = 21;
            this.txtSetValue.Visible = false;
            // 
            // lblPositive
            // 
            this.lblPositive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPositive.AutoSize = true;
            this.lblPositive.Location = new System.Drawing.Point(484, 10);
            this.lblPositive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPositive.Name = "lblPositive";
            this.lblPositive.Size = new System.Drawing.Size(16, 17);
            this.lblPositive.TabIndex = 20;
            this.lblPositive.Text = "+";
            this.lblPositive.Visible = false;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Image = global::LDV_DESIGNE_BZ.Properties.Resources.depositALLrz;
            this.btnDeposit.Location = new System.Drawing.Point(172, 387);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(236, 57);
            this.btnDeposit.TabIndex = 19;
            this.btnDeposit.Text = "Finalizar depósito";
            this.btnDeposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.metroToolTip1.SetToolTip(this.btnDeposit, "Click aqui para finalizar seu deposito.");
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(44, 302);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(135, 25);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Data atual/hora";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(44, 239);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(131, 25);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Conta bancária";
            // 
            // txtNumAccount
            // 
            this.txtNumAccount.DataSource = this.lDVBANKACCOUNTBindingSource1;
            this.txtNumAccount.DisplayMember = "NUMBERACCOUNT";
            this.txtNumAccount.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.txtNumAccount.FormattingEnabled = true;
            this.txtNumAccount.ItemHeight = 29;
            this.txtNumAccount.Location = new System.Drawing.Point(183, 229);
            this.txtNumAccount.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumAccount.Name = "txtNumAccount";
            this.txtNumAccount.PromptText = "Escolha a conta...";
            this.txtNumAccount.Size = new System.Drawing.Size(182, 35);
            this.txtNumAccount.TabIndex = 16;
            this.metroToolTip1.SetToolTip(this.txtNumAccount, "Selecione a conta bancária \r\nque deseja fazer o deposito.");
            this.txtNumAccount.UseSelectable = true;
            this.txtNumAccount.ValueMember = "NUMBERACCOUNT";
            // 
            // lDVBANKACCOUNTBindingSource1
            // 
            this.lDVBANKACCOUNTBindingSource1.DataMember = "LDVBANKACCOUNT";
            this.lDVBANKACCOUNTBindingSource1.DataSource = this.lDV_PEDREIRADataSet;
            // 
            // lDV_PEDREIRADataSet
            // 
            this.lDV_PEDREIRADataSet.DataSetName = "LDV_PEDREIRADataSet";
            this.lDV_PEDREIRADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(44, 127);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 25);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Descrição";
            // 
            // txtDesc
            // 
            // 
            // 
            // 
            this.txtDesc.CustomButton.Image = null;
            this.txtDesc.CustomButton.Location = new System.Drawing.Point(370, 2);
            this.txtDesc.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesc.CustomButton.Name = "";
            this.txtDesc.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDesc.CustomButton.TabIndex = 1;
            this.txtDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDesc.CustomButton.UseSelectable = true;
            this.txtDesc.CustomButton.Visible = false;
            this.txtDesc.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDesc.Lines = new string[0];
            this.txtDesc.Location = new System.Drawing.Point(140, 124);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesc.MaxLength = 32767;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.PromptText = "Faça uma breve descrição do débito realizado";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesc.SelectedText = "";
            this.txtDesc.SelectionLength = 0;
            this.txtDesc.SelectionStart = 0;
            this.txtDesc.ShortcutsEnabled = true;
            this.txtDesc.Size = new System.Drawing.Size(396, 28);
            this.txtDesc.TabIndex = 14;
            this.metroToolTip1.SetToolTip(this.txtDesc, "Digite uma descrição breve sobre o \r\nque você está depositando em sua conta.");
            this.txtDesc.UseSelectable = true;
            this.txtDesc.WaterMark = "Faça uma breve descrição do débito realizado";
            this.txtDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.CustomFormat = "dd/MM/yyyy";
            this.txtData.Enabled = false;
            this.txtData.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtData.Location = new System.Drawing.Point(187, 292);
            this.txtData.Margin = new System.Windows.Forms.Padding(4);
            this.txtData.MinimumSize = new System.Drawing.Size(0, 35);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(178, 35);
            this.txtData.TabIndex = 13;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(44, 180);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(136, 25);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Valor do débito";
            // 
            // txtValue
            // 
            // 
            // 
            // 
            this.txtValue.CustomButton.Image = null;
            this.txtValue.CustomButton.Location = new System.Drawing.Point(147, 2);
            this.txtValue.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtValue.CustomButton.Name = "";
            this.txtValue.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValue.CustomButton.TabIndex = 1;
            this.txtValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValue.CustomButton.UseSelectable = true;
            this.txtValue.CustomButton.Visible = false;
            this.txtValue.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtValue.Lines = new string[0];
            this.txtValue.Location = new System.Drawing.Point(192, 177);
            this.txtValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtValue.MaxLength = 32767;
            this.txtValue.Name = "txtValue";
            this.txtValue.PasswordChar = '\0';
            this.txtValue.PromptText = "R$ 1000.00";
            this.txtValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValue.SelectedText = "";
            this.txtValue.SelectionLength = 0;
            this.txtValue.SelectionStart = 0;
            this.txtValue.ShortcutsEnabled = true;
            this.txtValue.Size = new System.Drawing.Size(173, 28);
            this.txtValue.TabIndex = 11;
            this.metroToolTip1.SetToolTip(this.txtValue, "Digite aqui o valor \r\nque deseja depositar.");
            this.txtValue.UseSelectable = true;
            this.txtValue.WaterMark = "R$ 1000.00";
            this.txtValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Enter += new System.EventHandler(this.txtValue_Enter);
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lDVBANKACCOUNTTableAdapter
            // 
            this.lDVBANKACCOUNTTableAdapter.ClearBeforeFill = true;
            // 
            // frmDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 490);
            this.Controls.Add(this.txtSetValue);
            this.Controls.Add(this.lblPositive);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtNumAccount);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtValue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeposit";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.ShowInTaskbar = false;
            this.Text = "Faça um depósito na conta";
            this.Load += new System.EventHandler(this.frmDeposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lDVBANKACCOUNTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDV_PEDREIRADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDVBANKACCOUNTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSetValue;
        private System.Windows.Forms.Label lblPositive;
        private System.Windows.Forms.Button btnDeposit;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox txtNumAccount;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtDesc;
        private MetroFramework.Controls.MetroDateTime txtData;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtValue;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.BindingSource lDVBANKACCOUNTBindingSource;
        private LDV_PEDREIRADataSet lDV_PEDREIRADataSet;
        private System.Windows.Forms.BindingSource lDVBANKACCOUNTBindingSource1;
        private LDV_PEDREIRADataSetTableAdapters.LDVBANKACCOUNTTableAdapter lDVBANKACCOUNTTableAdapter;
    }
}