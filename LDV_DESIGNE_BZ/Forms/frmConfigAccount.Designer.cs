namespace LDV_DESIGNE_BZ.Forms
{
    partial class frmConfigAccount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigAccount));
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.nUMBERACCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFHOLDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lDVBANKACCOUNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lDV_PEDREIRADataSet = new LDV_DESIGNE_BZ.LDV_PEDREIRADataSet();
            this.lDVBANKACCOUNTTableAdapter = new LDV_DESIGNE_BZ.LDV_PEDREIRADataSetTableAdapters.LDVBANKACCOUNTTableAdapter();
            this.txtNumAcc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCpfHolder = new MetroFramework.Controls.MetroTextBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDVBANKACCOUNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDV_PEDREIRADataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nUMBERACCOUNTDataGridViewTextBoxColumn,
            this.cPFHOLDERDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.lDVBANKACCOUNTBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(6, 29);
            this.metroGrid1.MultiSelect = false;
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(233, 245);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // nUMBERACCOUNTDataGridViewTextBoxColumn
            // 
            this.nUMBERACCOUNTDataGridViewTextBoxColumn.DataPropertyName = "NUMBERACCOUNT";
            this.nUMBERACCOUNTDataGridViewTextBoxColumn.HeaderText = "Número da conta";
            this.nUMBERACCOUNTDataGridViewTextBoxColumn.Name = "nUMBERACCOUNTDataGridViewTextBoxColumn";
            this.nUMBERACCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.nUMBERACCOUNTDataGridViewTextBoxColumn.Width = 190;
            // 
            // cPFHOLDERDataGridViewTextBoxColumn
            // 
            this.cPFHOLDERDataGridViewTextBoxColumn.DataPropertyName = "CPFHOLDER";
            this.cPFHOLDERDataGridViewTextBoxColumn.HeaderText = "CPFHOLDER";
            this.cPFHOLDERDataGridViewTextBoxColumn.Name = "cPFHOLDERDataGridViewTextBoxColumn";
            this.cPFHOLDERDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPFHOLDERDataGridViewTextBoxColumn.Visible = false;
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
            // txtNumAcc
            // 
            // 
            // 
            // 
            this.txtNumAcc.CustomButton.Image = null;
            this.txtNumAcc.CustomButton.Location = new System.Drawing.Point(147, 2);
            this.txtNumAcc.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumAcc.CustomButton.Name = "";
            this.txtNumAcc.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNumAcc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumAcc.CustomButton.TabIndex = 1;
            this.txtNumAcc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumAcc.CustomButton.UseSelectable = true;
            this.txtNumAcc.CustomButton.Visible = false;
            this.txtNumAcc.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNumAcc.Lines = new string[0];
            this.txtNumAcc.Location = new System.Drawing.Point(48, 77);
            this.txtNumAcc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumAcc.MaxLength = 32767;
            this.txtNumAcc.Name = "txtNumAcc";
            this.txtNumAcc.PasswordChar = '\0';
            this.txtNumAcc.PromptText = "Ex: 21.877-2";
            this.txtNumAcc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumAcc.SelectedText = "";
            this.txtNumAcc.SelectionLength = 0;
            this.txtNumAcc.SelectionStart = 0;
            this.txtNumAcc.ShortcutsEnabled = true;
            this.txtNumAcc.Size = new System.Drawing.Size(173, 28);
            this.txtNumAcc.TabIndex = 2;
            this.metroToolTip1.SetToolTip(this.txtNumAcc, "Aqui você insere o número da conta\r\nque deseja cadastrar.");
            this.txtNumAcc.UseSelectable = true;
            this.txtNumAcc.WaterMark = "Ex: 21.877-2";
            this.txtNumAcc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumAcc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(48, 50);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(118, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Número da conta";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(48, 118);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "CPF titular";
            // 
            // txtCpfHolder
            // 
            // 
            // 
            // 
            this.txtCpfHolder.CustomButton.Image = null;
            this.txtCpfHolder.CustomButton.Location = new System.Drawing.Point(147, 2);
            this.txtCpfHolder.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpfHolder.CustomButton.Name = "";
            this.txtCpfHolder.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCpfHolder.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCpfHolder.CustomButton.TabIndex = 1;
            this.txtCpfHolder.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCpfHolder.CustomButton.UseSelectable = true;
            this.txtCpfHolder.CustomButton.Visible = false;
            this.txtCpfHolder.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCpfHolder.Lines = new string[0];
            this.txtCpfHolder.Location = new System.Drawing.Point(48, 145);
            this.txtCpfHolder.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpfHolder.MaxLength = 32767;
            this.txtCpfHolder.Name = "txtCpfHolder";
            this.txtCpfHolder.PasswordChar = '\0';
            this.txtCpfHolder.PromptText = "Ex: 445.751.918/92";
            this.txtCpfHolder.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCpfHolder.SelectedText = "";
            this.txtCpfHolder.SelectionLength = 0;
            this.txtCpfHolder.SelectionStart = 0;
            this.txtCpfHolder.ShortcutsEnabled = true;
            this.txtCpfHolder.Size = new System.Drawing.Size(173, 28);
            this.txtCpfHolder.TabIndex = 4;
            this.metroToolTip1.SetToolTip(this.txtCpfHolder, "Aqui você insere o CPF que é\r\ntitular da conta bancaria.");
            this.txtCpfHolder.UseSelectable = true;
            this.txtCpfHolder.WaterMark = "Ex: 445.751.918/92";
            this.txtCpfHolder.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCpfHolder.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAccount.FlatAppearance.BorderSize = 0;
            this.btnAddAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.Image = global::LDV_DESIGNE_BZ.Properties.Resources.add30;
            this.btnAddAccount.Location = new System.Drawing.Point(28, 194);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(212, 41);
            this.btnAddAccount.TabIndex = 9;
            this.btnAddAccount.Text = "Adicionar uma conta";
            this.btnAddAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.metroToolTip1.SetToolTip(this.btnAddAccount, "Click para adicionar a conta que você\r\npreencheu no \"Número da conta\" e no\r\n\"CPF " +
        "titular\".");
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddAccount);
            this.groupBox1.Controls.Add(this.txtNumAcc);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtCpfHolder);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(292, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 280);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicione uma conta";
            this.metroToolTip1.SetToolTip(this.groupBox1, "Aqui você pode inserir novas contas\r\nbancarias para controlar seus gastos.");
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroGrid1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(24, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 280);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contas já cadastradas";
            this.metroToolTip1.SetToolTip(this.groupBox2, "Aqui se encontram as contas\r\nque ja estão cadastradas no \r\nsistema.");
            // 
            // frmConfigAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(589, 390);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfigAccount";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Gerenciar conta(s)";
            this.Load += new System.EventHandler(this.frmConfigAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDVBANKACCOUNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDV_PEDREIRADataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private LDV_PEDREIRADataSet lDV_PEDREIRADataSet;
        private System.Windows.Forms.BindingSource lDVBANKACCOUNTBindingSource;
        private LDV_PEDREIRADataSetTableAdapters.LDVBANKACCOUNTTableAdapter lDVBANKACCOUNTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMBERACCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFHOLDERDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox txtNumAcc;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtCpfHolder;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}