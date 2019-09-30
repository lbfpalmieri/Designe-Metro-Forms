namespace LDV_DESIGNE_BZ.Forms
{
    partial class frmCriarConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCriarConta));
            this.lblCPF = new MetroFramework.Controls.MetroLabel();
            this.lblNomeUser = new MetroFramework.Controls.MetroLabel();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.lblTel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.lblSobrenome = new MetroFramework.Controls.MetroLabel();
            this.btnCriarConta = new System.Windows.Forms.Button();
            this.txtCpf = new MetroFramework.Controls.MetroTextBox();
            this.txtNomeUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtTelefone = new MetroFramework.Controls.MetroTextBox();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.txtSobrenome = new MetroFramework.Controls.MetroTextBox();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.lblSenha = new MetroFramework.Controls.MetroLabel();
            this.txtCodConta = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCPF.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCPF.Location = new System.Drawing.Point(73, 118);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(42, 25);
            this.lblCPF.TabIndex = 0;
            this.lblCPF.Text = "CPF";
            this.lblCPF.Visible = false;
            // 
            // lblNomeUser
            // 
            this.lblNomeUser.AutoSize = true;
            this.lblNomeUser.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNomeUser.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNomeUser.Location = new System.Drawing.Point(73, 155);
            this.lblNomeUser.Name = "lblNomeUser";
            this.lblNomeUser.Size = new System.Drawing.Size(149, 25);
            this.lblNomeUser.TabIndex = 1;
            this.lblNomeUser.Text = "Nome de usuário";
            this.lblNomeUser.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEmail.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblEmail.Location = new System.Drawing.Point(73, 189);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 25);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            this.lblEmail.Visible = false;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTel.Location = new System.Drawing.Point(73, 225);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(77, 25);
            this.lblTel.TabIndex = 3;
            this.lblTel.Text = "Telefone";
            this.lblTel.Visible = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(23, 193);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(0, 0);
            this.metroLabel5.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNome.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNome.Location = new System.Drawing.Point(73, 260);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 25);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome";
            this.lblNome.Visible = false;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSobrenome.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSobrenome.Location = new System.Drawing.Point(73, 299);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(105, 25);
            this.lblSobrenome.TabIndex = 6;
            this.lblSobrenome.Text = "Sobrenome";
            this.lblSobrenome.Visible = false;
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCriarConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarConta.FlatAppearance.BorderSize = 0;
            this.btnCriarConta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCriarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarConta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarConta.Location = new System.Drawing.Point(134, 412);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(177, 46);
            this.btnCriarConta.TabIndex = 13;
            this.btnCriarConta.Text = "Criar conta";
            this.btnCriarConta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCriarConta.UseVisualStyleBackColor = true;
            this.btnCriarConta.Visible = false;
            this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
            // 
            // txtCpf
            // 
            // 
            // 
            // 
            this.txtCpf.CustomButton.Image = null;
            this.txtCpf.CustomButton.Location = new System.Drawing.Point(254, 2);
            this.txtCpf.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpf.CustomButton.Name = "";
            this.txtCpf.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCpf.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCpf.CustomButton.TabIndex = 1;
            this.txtCpf.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCpf.CustomButton.UseSelectable = true;
            this.txtCpf.CustomButton.Visible = false;
            this.txtCpf.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCpf.Lines = new string[0];
            this.txtCpf.Location = new System.Drawing.Point(122, 118);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpf.MaxLength = 32767;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.PasswordChar = '\0';
            this.txtCpf.PromptText = "Ex: 445.751.918/92";
            this.txtCpf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCpf.SelectedText = "";
            this.txtCpf.SelectionLength = 0;
            this.txtCpf.SelectionStart = 0;
            this.txtCpf.ShortcutsEnabled = true;
            this.txtCpf.Size = new System.Drawing.Size(280, 28);
            this.txtCpf.TabIndex = 14;
            this.txtCpf.UseSelectable = true;
            this.txtCpf.Visible = false;
            this.txtCpf.WaterMark = "Ex: 445.751.918/92";
            this.txtCpf.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCpf.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtNomeUsuario
            // 
            // 
            // 
            // 
            this.txtNomeUsuario.CustomButton.Image = null;
            this.txtNomeUsuario.CustomButton.Location = new System.Drawing.Point(147, 2);
            this.txtNomeUsuario.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeUsuario.CustomButton.Name = "";
            this.txtNomeUsuario.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNomeUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeUsuario.CustomButton.TabIndex = 1;
            this.txtNomeUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeUsuario.CustomButton.UseSelectable = true;
            this.txtNomeUsuario.CustomButton.Visible = false;
            this.txtNomeUsuario.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNomeUsuario.Lines = new string[0];
            this.txtNomeUsuario.Location = new System.Drawing.Point(229, 155);
            this.txtNomeUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeUsuario.MaxLength = 32767;
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.PasswordChar = '\0';
            this.txtNomeUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeUsuario.SelectedText = "";
            this.txtNomeUsuario.SelectionLength = 0;
            this.txtNomeUsuario.SelectionStart = 0;
            this.txtNomeUsuario.ShortcutsEnabled = true;
            this.txtNomeUsuario.Size = new System.Drawing.Size(173, 28);
            this.txtNomeUsuario.TabIndex = 15;
            this.txtNomeUsuario.UseSelectable = true;
            this.txtNomeUsuario.Visible = false;
            this.txtNomeUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(191, 2);
            this.txtEmail.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(185, 189);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(217, 28);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.Visible = false;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtTelefone
            // 
            // 
            // 
            // 
            this.txtTelefone.CustomButton.Image = null;
            this.txtTelefone.CustomButton.Location = new System.Drawing.Point(191, 2);
            this.txtTelefone.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.CustomButton.Name = "";
            this.txtTelefone.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtTelefone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelefone.CustomButton.TabIndex = 1;
            this.txtTelefone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelefone.CustomButton.UseSelectable = true;
            this.txtTelefone.CustomButton.Visible = false;
            this.txtTelefone.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtTelefone.Lines = new string[0];
            this.txtTelefone.Location = new System.Drawing.Point(185, 225);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.MaxLength = 32767;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PasswordChar = '\0';
            this.txtTelefone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefone.SelectedText = "";
            this.txtTelefone.SelectionLength = 0;
            this.txtTelefone.SelectionStart = 0;
            this.txtTelefone.ShortcutsEnabled = true;
            this.txtTelefone.Size = new System.Drawing.Size(217, 28);
            this.txtTelefone.TabIndex = 17;
            this.txtTelefone.UseSelectable = true;
            this.txtTelefone.Visible = false;
            this.txtTelefone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelefone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(191, 2);
            this.txtNome.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(185, 260);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(217, 28);
            this.txtNome.TabIndex = 18;
            this.txtNome.UseSelectable = true;
            this.txtNome.Visible = false;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtSobrenome
            // 
            // 
            // 
            // 
            this.txtSobrenome.CustomButton.Image = null;
            this.txtSobrenome.CustomButton.Location = new System.Drawing.Point(191, 2);
            this.txtSobrenome.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtSobrenome.CustomButton.Name = "";
            this.txtSobrenome.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSobrenome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSobrenome.CustomButton.TabIndex = 1;
            this.txtSobrenome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSobrenome.CustomButton.UseSelectable = true;
            this.txtSobrenome.CustomButton.Visible = false;
            this.txtSobrenome.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSobrenome.Lines = new string[0];
            this.txtSobrenome.Location = new System.Drawing.Point(185, 299);
            this.txtSobrenome.Margin = new System.Windows.Forms.Padding(4);
            this.txtSobrenome.MaxLength = 32767;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.PasswordChar = '\0';
            this.txtSobrenome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSobrenome.SelectedText = "";
            this.txtSobrenome.SelectionLength = 0;
            this.txtSobrenome.SelectionStart = 0;
            this.txtSobrenome.ShortcutsEnabled = true;
            this.txtSobrenome.Size = new System.Drawing.Size(217, 28);
            this.txtSobrenome.TabIndex = 19;
            this.txtSobrenome.UseSelectable = true;
            this.txtSobrenome.Visible = false;
            this.txtSobrenome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSobrenome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtSenha
            // 
            // 
            // 
            // 
            this.txtSenha.CustomButton.Image = null;
            this.txtSenha.CustomButton.Location = new System.Drawing.Point(191, 2);
            this.txtSenha.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.CustomButton.Name = "";
            this.txtSenha.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSenha.CustomButton.TabIndex = 1;
            this.txtSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenha.CustomButton.UseSelectable = true;
            this.txtSenha.CustomButton.Visible = false;
            this.txtSenha.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSenha.Lines = new string[0];
            this.txtSenha.Location = new System.Drawing.Point(185, 337);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.ShortcutsEnabled = true;
            this.txtSenha.Size = new System.Drawing.Size(217, 28);
            this.txtSenha.TabIndex = 21;
            this.txtSenha.UseSelectable = true;
            this.txtSenha.Visible = false;
            this.txtSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSenha.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSenha.Location = new System.Drawing.Point(73, 337);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(60, 25);
            this.lblSenha.TabIndex = 20;
            this.lblSenha.Text = "Senha";
            this.lblSenha.Visible = false;
            // 
            // txtCodConta
            // 
            // 
            // 
            // 
            this.txtCodConta.CustomButton.Image = null;
            this.txtCodConta.CustomButton.Location = new System.Drawing.Point(129, 2);
            this.txtCodConta.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodConta.CustomButton.Name = "";
            this.txtCodConta.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCodConta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodConta.CustomButton.TabIndex = 1;
            this.txtCodConta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodConta.CustomButton.UseSelectable = true;
            this.txtCodConta.CustomButton.Visible = false;
            this.txtCodConta.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCodConta.Lines = new string[0];
            this.txtCodConta.Location = new System.Drawing.Point(259, 72);
            this.txtCodConta.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodConta.MaxLength = 32767;
            this.txtCodConta.Name = "txtCodConta";
            this.txtCodConta.PasswordChar = '\0';
            this.txtCodConta.PromptText = "Digite o código aqui";
            this.txtCodConta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodConta.SelectedText = "";
            this.txtCodConta.SelectionLength = 0;
            this.txtCodConta.SelectionStart = 0;
            this.txtCodConta.ShortcutsEnabled = true;
            this.txtCodConta.Size = new System.Drawing.Size(155, 28);
            this.txtCodConta.TabIndex = 23;
            this.txtCodConta.UseSelectable = true;
            this.txtCodConta.WaterMark = "Digite o código aqui";
            this.txtCodConta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodConta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodConta.TextChanged += new System.EventHandler(this.txtCodConta_TextChanged);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(41, 72);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(211, 25);
            this.metroLabel9.TabIndex = 22;
            this.metroLabel9.Text = "Código para criar conta";
            // 
            // frmCriarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 516);
            this.Controls.Add(this.txtCodConta);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.btnCriarConta);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNomeUser);
            this.Controls.Add(this.lblCPF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCriarConta";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Criar uma nova conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblCPF;
        private MetroFramework.Controls.MetroLabel lblNomeUser;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroLabel lblTel;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroLabel lblSobrenome;
        private System.Windows.Forms.Button btnCriarConta;
        private MetroFramework.Controls.MetroTextBox txtCpf;
        private MetroFramework.Controls.MetroTextBox txtNomeUsuario;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtTelefone;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroTextBox txtSobrenome;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroLabel lblSenha;
        private MetroFramework.Controls.MetroTextBox txtCodConta;
        private MetroFramework.Controls.MetroLabel metroLabel9;
    }
}