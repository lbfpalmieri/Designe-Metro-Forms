namespace LDV_DESIGNE_BZ.Forms
{
    partial class frmDebit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDebit));
            this.txtValue = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtData = new MetroFramework.Controls.MetroDateTime();
            this.txtDesc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtNumAccount = new MetroFramework.Controls.MetroComboBox();
            this.lDVBANKACCOUNTBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lDV_PEDREIRADataSet = new LDV_DESIGNE_BZ.LDV_PEDREIRADataSet();
            this.lDVBANKACCOUNTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lDVBANKACCOUNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnDebit = new System.Windows.Forms.Button();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.txtSetValue = new System.Windows.Forms.TextBox();
            this.lblNegative = new System.Windows.Forms.Label();
            this.lDVBANKACCOUNTTableAdapter = new LDV_DESIGNE_BZ.LDV_PEDREIRADataSetTableAdapters.LDVBANKACCOUNTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lDVBANKACCOUNTBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDV_PEDREIRADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDVBANKACCOUNTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDVBANKACCOUNTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            // 
            // 
            // 
            this.txtValue.CustomButton.Image = null;
            this.txtValue.CustomButton.Location = new System.Drawing.Point(81, 1);
            this.txtValue.CustomButton.Name = "";
            this.txtValue.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValue.CustomButton.TabIndex = 1;
            this.txtValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValue.CustomButton.UseSelectable = true;
            this.txtValue.CustomButton.Visible = false;
            this.txtValue.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtValue.Lines = new string[0];
            this.txtValue.Location = new System.Drawing.Point(165, 146);
            this.txtValue.MaxLength = 32767;
            this.txtValue.Name = "txtValue";
            this.txtValue.PasswordChar = '\0';
            this.txtValue.PromptText = "R$ 1000.00";
            this.txtValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValue.SelectedText = "";
            this.txtValue.SelectionLength = 0;
            this.txtValue.SelectionStart = 0;
            this.txtValue.ShortcutsEnabled = true;
            this.txtValue.Size = new System.Drawing.Size(130, 23);
            this.txtValue.TabIndex = 0;
            this.metroToolTip1.SetToolTip(this.txtValue, "Digite aqui o valor \r\nque deseja debitar.");
            this.txtValue.UseSelectable = true;
            this.txtValue.WaterMark = "R$ 1000.00";
            this.txtValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Enter += new System.EventHandler(this.txtValue_Enter);
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 146);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(136, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Valor do débito";
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
            this.txtData.Location = new System.Drawing.Point(161, 239);
            this.txtData.MinimumSize = new System.Drawing.Size(0, 35);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(134, 35);
            this.txtData.TabIndex = 2;
            this.metroToolTip1.SetToolTip(this.txtData, "Esse campo não é modificavel \r\npor quentão de segurança.");
            // 
            // txtDesc
            // 
            // 
            // 
            // 
            this.txtDesc.CustomButton.Image = null;
            this.txtDesc.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.txtDesc.CustomButton.Name = "";
            this.txtDesc.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDesc.CustomButton.TabIndex = 1;
            this.txtDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDesc.CustomButton.UseSelectable = true;
            this.txtDesc.CustomButton.Visible = false;
            this.txtDesc.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDesc.Lines = new string[0];
            this.txtDesc.Location = new System.Drawing.Point(115, 103);
            this.txtDesc.MaxLength = 32767;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.PromptText = "Faça uma breve descrição do débito realizado";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesc.SelectedText = "";
            this.txtDesc.SelectionLength = 0;
            this.txtDesc.SelectionStart = 0;
            this.txtDesc.ShortcutsEnabled = true;
            this.txtDesc.Size = new System.Drawing.Size(297, 23);
            this.txtDesc.TabIndex = 3;
            this.metroToolTip1.SetToolTip(this.txtDesc, "Digite uma descrição breve sobre o \r\nque você está debitando de sua conta.");
            this.txtDesc.UseSelectable = true;
            this.txtDesc.WaterMark = "Faça uma breve descrição do débito realizado";
            this.txtDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 103);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Descrição";
            // 
            // txtNumAccount
            // 
            this.txtNumAccount.DataSource = this.lDVBANKACCOUNTBindingSource2;
            this.txtNumAccount.DisplayMember = "NUMBERACCOUNT";
            this.txtNumAccount.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.txtNumAccount.FormattingEnabled = true;
            this.txtNumAccount.ItemHeight = 29;
            this.txtNumAccount.Location = new System.Drawing.Point(158, 188);
            this.txtNumAccount.Name = "txtNumAccount";
            this.txtNumAccount.PromptText = "Escolha a conta...";
            this.txtNumAccount.Size = new System.Drawing.Size(138, 35);
            this.txtNumAccount.TabIndex = 5;
            this.metroToolTip1.SetToolTip(this.txtNumAccount, "Selecione a conta bancária \r\nque deseja fazer o débito.");
            this.txtNumAccount.UseSelectable = true;
            this.txtNumAccount.ValueMember = "NUMBERACCOUNT";
            // 
            // lDVBANKACCOUNTBindingSource2
            // 
            this.lDVBANKACCOUNTBindingSource2.DataMember = "LDVBANKACCOUNT";
            this.lDVBANKACCOUNTBindingSource2.DataSource = this.lDV_PEDREIRADataSet;
            // 
            // lDV_PEDREIRADataSet
            // 
            this.lDV_PEDREIRADataSet.DataSetName = "LDV_PEDREIRADataSet";
            this.lDV_PEDREIRADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lDVBANKACCOUNTBindingSource
            // 
            this.lDVBANKACCOUNTBindingSource.DataMember = "LDVBANKACCOUNT";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(23, 194);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(130, 25);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Conta bancária";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(23, 245);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(135, 25);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Data atual/hora";
            // 
            // btnDebit
            // 
            this.btnDebit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDebit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDebit.FlatAppearance.BorderSize = 0;
            this.btnDebit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDebit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebit.Image = global::LDV_DESIGNE_BZ.Properties.Resources.debitALLrz;
            this.btnDebit.Location = new System.Drawing.Point(129, 314);
            this.btnDebit.Name = "btnDebit";
            this.btnDebit.Size = new System.Drawing.Size(177, 46);
            this.btnDebit.TabIndex = 8;
            this.btnDebit.Text = "Finalizar débito";
            this.btnDebit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.metroToolTip1.SetToolTip(this.btnDebit, "Click aqui para finalizar seu débito.");
            this.btnDebit.UseVisualStyleBackColor = true;
            this.btnDebit.Click += new System.EventHandler(this.btnDebit_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtSetValue
            // 
            this.txtSetValue.Location = new System.Drawing.Point(384, 12);
            this.txtSetValue.Name = "txtSetValue";
            this.txtSetValue.Size = new System.Drawing.Size(43, 20);
            this.txtSetValue.TabIndex = 10;
            this.txtSetValue.Visible = false;
            // 
            // lblNegative
            // 
            this.lblNegative.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNegative.AutoSize = true;
            this.lblNegative.Location = new System.Drawing.Point(368, 12);
            this.lblNegative.Name = "lblNegative";
            this.lblNegative.Size = new System.Drawing.Size(10, 13);
            this.lblNegative.TabIndex = 9;
            this.lblNegative.Text = "-";
            this.lblNegative.Visible = false;
            // 
            // lDVBANKACCOUNTTableAdapter
            // 
            this.lDVBANKACCOUNTTableAdapter.ClearBeforeFill = true;
            // 
            // frmDebit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 398);
            this.Controls.Add(this.txtSetValue);
            this.Controls.Add(this.lblNegative);
            this.Controls.Add(this.btnDebit);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtNumAccount);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtValue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDebit";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.ShowInTaskbar = false;
            this.Text = "Faça um débito na conta";
            this.Load += new System.EventHandler(this.frmDebit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lDVBANKACCOUNTBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDV_PEDREIRADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDVBANKACCOUNTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDVBANKACCOUNTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtValue;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime txtData;
        private MetroFramework.Controls.MetroTextBox txtDesc;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox txtNumAccount;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Button btnDebit;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.BindingSource lDVBANKACCOUNTBindingSource;
        private System.Windows.Forms.TextBox txtSetValue;
        private System.Windows.Forms.Label lblNegative;
        private LDV_PEDREIRADataSet lDV_PEDREIRADataSet;
        private System.Windows.Forms.BindingSource lDVBANKACCOUNTBindingSource1;
        private LDV_PEDREIRADataSetTableAdapters.LDVBANKACCOUNTTableAdapter lDVBANKACCOUNTTableAdapter;
        private System.Windows.Forms.BindingSource lDVBANKACCOUNTBindingSource2;
    }
}