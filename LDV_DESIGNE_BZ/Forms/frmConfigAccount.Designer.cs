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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigAccount));
            this.txtNumAcc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCpfHolder = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.NUMBERACCOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFHOLDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNumAccAlter = new MetroFramework.Controls.MetroTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.CPFUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lDVACCOUNTUSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lDV_PEDREIRADataSet = new LDV_DESIGNE_BZ.LDV_PEDREIRADataSet();
            this.txtCPFHOLDERparam = new MetroFramework.Controls.MetroTextBox();
            this.lDVBANKACCOUNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lDVACCOUNTUSERTableAdapter = new LDV_DESIGNE_BZ.LDV_PEDREIRADataSetTableAdapters.LDVACCOUNTUSERTableAdapter();
            this.lDVBANKACCOUNTTableAdapter = new LDV_DESIGNE_BZ.LDV_PEDREIRADataSetTableAdapters.LDVBANKACCOUNTTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDVACCOUNTUSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDV_PEDREIRADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDVBANKACCOUNTBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.txtNumAcc.FontSize = MetroFramework.MetroTextBoxSize.Tall;
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
            this.txtNumAcc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(48, 50);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(152, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Número da conta";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(48, 118);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 25);
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
            this.txtCpfHolder.FontSize = MetroFramework.MetroTextBoxSize.Tall;
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
            this.txtCpfHolder.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAddAccount);
            this.groupBox1.Controls.Add(this.txtNumAcc);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtCpfHolder);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(657, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 349);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerencie uma conta";
            this.metroToolTip1.SetToolTip(this.groupBox1, "Aqui você pode inserir novas contas\r\nbancarias para controlar seus gastos.");
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::LDV_DESIGNE_BZ.Properties.Resources.edit30;
            this.btnEdit.Location = new System.Drawing.Point(18, 288);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(232, 41);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Alterar uma conta";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.metroToolTip1.SetToolTip(this.btnEdit, "Click para editar a conta que você\r\npreencheu no \"Número da conta\" e no\r\n\"CPF tit" +
        "ular\".");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Image = global::LDV_DESIGNE_BZ.Properties.Resources.remove30;
            this.btnRemove.Location = new System.Drawing.Point(18, 239);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(232, 41);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remover uma conta";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.metroToolTip1.SetToolTip(this.btnRemove, "Click para remover a conta que você\r\npreencheu no \"Número da conta\" e no\r\n\"CPF ti" +
        "tular\".");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            this.btnAddAccount.Location = new System.Drawing.Point(18, 190);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(232, 41);
            this.btnAddAccount.TabIndex = 9;
            this.btnAddAccount.Text = "Adicionar uma conta";
            this.btnAddAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.metroToolTip1.SetToolTip(this.btnAddAccount, "Click para adicionar a conta que você\r\npreencheu no \"Número da conta\" e no\r\n\"CPF " +
        "titular\".");
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
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
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(365, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 349);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contas vinculadas";
            this.metroToolTip1.SetToolTip(this.groupBox2, "Aqui se encontram as contas\r\nque ja estão cadastradas no \r\nsistema.");
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
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
            this.NUMBERACCOUNT,
            this.CPFHOLDER});
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
            this.metroGrid1.Size = new System.Drawing.Size(233, 300);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroGrid1.TabIndex = 10;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // NUMBERACCOUNT
            // 
            this.NUMBERACCOUNT.DataPropertyName = "NUMBERACCOUNT";
            this.NUMBERACCOUNT.HeaderText = "Número da conta";
            this.NUMBERACCOUNT.Name = "NUMBERACCOUNT";
            this.NUMBERACCOUNT.ReadOnly = true;
            this.NUMBERACCOUNT.Width = 190;
            // 
            // CPFHOLDER
            // 
            this.CPFHOLDER.DataPropertyName = "CPFUSER";
            this.CPFHOLDER.HeaderText = "CPFHOLDER";
            this.CPFHOLDER.Name = "CPFHOLDER";
            this.CPFHOLDER.ReadOnly = true;
            this.CPFHOLDER.Visible = false;
            // 
            // txtNumAccAlter
            // 
            // 
            // 
            // 
            this.txtNumAccAlter.CustomButton.Image = null;
            this.txtNumAccAlter.CustomButton.Location = new System.Drawing.Point(128, 2);
            this.txtNumAccAlter.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumAccAlter.CustomButton.Name = "";
            this.txtNumAccAlter.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNumAccAlter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumAccAlter.CustomButton.TabIndex = 1;
            this.txtNumAccAlter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumAccAlter.CustomButton.UseSelectable = true;
            this.txtNumAccAlter.CustomButton.Visible = false;
            this.txtNumAccAlter.Enabled = false;
            this.txtNumAccAlter.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNumAccAlter.Lines = new string[0];
            this.txtNumAccAlter.Location = new System.Drawing.Point(456, 42);
            this.txtNumAccAlter.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumAccAlter.MaxLength = 32767;
            this.txtNumAccAlter.Name = "txtNumAccAlter";
            this.txtNumAccAlter.PasswordChar = '\0';
            this.txtNumAccAlter.PromptText = "Ex: 21.877-2";
            this.txtNumAccAlter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumAccAlter.SelectedText = "";
            this.txtNumAccAlter.SelectionLength = 0;
            this.txtNumAccAlter.SelectionStart = 0;
            this.txtNumAccAlter.ShortcutsEnabled = true;
            this.txtNumAccAlter.Size = new System.Drawing.Size(154, 28);
            this.txtNumAccAlter.TabIndex = 12;
            this.metroToolTip1.SetToolTip(this.txtNumAccAlter, "Aqui você insere o número da conta\r\nque deseja cadastrar.");
            this.txtNumAccAlter.UseSelectable = true;
            this.txtNumAccAlter.Visible = false;
            this.txtNumAccAlter.WaterMark = "Ex: 21.877-2";
            this.txtNumAccAlter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumAccAlter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroGrid2);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(23, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 349);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CPF existente no sistema";
            this.metroToolTip1.SetToolTip(this.groupBox3, "Aqui se encontram as contas\r\nque ja estão cadastradas no \r\nsistema.");
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToAddRows = false;
            this.metroGrid2.AllowUserToDeleteRows = false;
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.AutoGenerateColumns = false;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPFUSER});
            this.metroGrid2.DataSource = this.lDVACCOUNTUSERBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(6, 29);
            this.metroGrid2.MultiSelect = false;
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.ReadOnly = true;
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroGrid2.RowTemplate.Height = 24;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(250, 300);
            this.metroGrid2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroGrid2.TabIndex = 10;
            this.metroGrid2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGrid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid2_CellContentClick);
            // 
            // CPFUSER
            // 
            this.CPFUSER.DataPropertyName = "CPFUSER";
            this.CPFUSER.HeaderText = "CPF no sistema";
            this.CPFUSER.Name = "CPFUSER";
            this.CPFUSER.ReadOnly = true;
            this.CPFUSER.Width = 205;
            // 
            // lDVACCOUNTUSERBindingSource
            // 
            this.lDVACCOUNTUSERBindingSource.DataMember = "LDVACCOUNTUSER";
            this.lDVACCOUNTUSERBindingSource.DataSource = this.lDV_PEDREIRADataSet;
            // 
            // lDV_PEDREIRADataSet
            // 
            this.lDV_PEDREIRADataSet.DataSetName = "LDV_PEDREIRADataSet";
            this.lDV_PEDREIRADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCPFHOLDERparam
            // 
            // 
            // 
            // 
            this.txtCPFHOLDERparam.CustomButton.Image = null;
            this.txtCPFHOLDERparam.CustomButton.Location = new System.Drawing.Point(57, 2);
            this.txtCPFHOLDERparam.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPFHOLDERparam.CustomButton.Name = "";
            this.txtCPFHOLDERparam.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCPFHOLDERparam.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCPFHOLDERparam.CustomButton.TabIndex = 1;
            this.txtCPFHOLDERparam.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCPFHOLDERparam.CustomButton.UseSelectable = true;
            this.txtCPFHOLDERparam.CustomButton.Visible = false;
            this.txtCPFHOLDERparam.Enabled = false;
            this.txtCPFHOLDERparam.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCPFHOLDERparam.Lines = new string[0];
            this.txtCPFHOLDERparam.Location = new System.Drawing.Point(365, 42);
            this.txtCPFHOLDERparam.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPFHOLDERparam.MaxLength = 32767;
            this.txtCPFHOLDERparam.Name = "txtCPFHOLDERparam";
            this.txtCPFHOLDERparam.PasswordChar = '\0';
            this.txtCPFHOLDERparam.PromptText = "Ex: 21.877-2";
            this.txtCPFHOLDERparam.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCPFHOLDERparam.SelectedText = "";
            this.txtCPFHOLDERparam.SelectionLength = 0;
            this.txtCPFHOLDERparam.SelectionStart = 0;
            this.txtCPFHOLDERparam.ShortcutsEnabled = true;
            this.txtCPFHOLDERparam.Size = new System.Drawing.Size(83, 28);
            this.txtCPFHOLDERparam.TabIndex = 14;
            this.metroToolTip1.SetToolTip(this.txtCPFHOLDERparam, "Aqui você insere o número da conta\r\nque deseja cadastrar.");
            this.txtCPFHOLDERparam.UseSelectable = true;
            this.txtCPFHOLDERparam.Visible = false;
            this.txtCPFHOLDERparam.WaterMark = "Ex: 21.877-2";
            this.txtCPFHOLDERparam.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCPFHOLDERparam.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lDVBANKACCOUNTBindingSource
            // 
            this.lDVBANKACCOUNTBindingSource.DataMember = "LDVBANKACCOUNT";
            this.lDVBANKACCOUNTBindingSource.DataSource = this.lDV_PEDREIRADataSet;
            // 
            // lDVACCOUNTUSERTableAdapter
            // 
            this.lDVACCOUNTUSERTableAdapter.ClearBeforeFill = true;
            // 
            // lDVBANKACCOUNTTableAdapter
            // 
            this.lDVBANKACCOUNTTableAdapter.ClearBeforeFill = true;
            // 
            // frmConfigAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(960, 447);
            this.Controls.Add(this.txtCPFHOLDERparam);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtNumAccAlter);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDVACCOUNTUSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDV_PEDREIRADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDVBANKACCOUNTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtNumAcc;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtCpfHolder;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemove;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.Button btnEdit;
        private MetroFramework.Controls.MetroTextBox txtNumAccAlter;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private MetroFramework.Controls.MetroTextBox txtCPFHOLDERparam;
        private LDV_PEDREIRADataSet lDV_PEDREIRADataSet;
        private System.Windows.Forms.BindingSource lDVACCOUNTUSERBindingSource;
        private LDV_PEDREIRADataSetTableAdapters.LDVACCOUNTUSERTableAdapter lDVACCOUNTUSERTableAdapter;
        private System.Windows.Forms.BindingSource lDVBANKACCOUNTBindingSource;
        private LDV_PEDREIRADataSetTableAdapters.LDVBANKACCOUNTTableAdapter lDVBANKACCOUNTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFUSER;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMBERACCOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFHOLDER;
    }
}