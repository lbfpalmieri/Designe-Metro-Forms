namespace LDV_DESIGNE_BZ.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtNumAcc = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.btnEfetuarLogin = new System.Windows.Forms.Button();
            this.btnSuporte = new System.Windows.Forms.Button();
            this.btnEsqSenha = new System.Windows.Forms.Button();
            this.btnCriarConta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(95, 147);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Usuário";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(95, 194);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Senha";
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
            this.txtNumAcc.Location = new System.Drawing.Point(166, 147);
            this.txtNumAcc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumAcc.MaxLength = 32767;
            this.txtNumAcc.Name = "txtNumAcc";
            this.txtNumAcc.PasswordChar = '\0';
            this.txtNumAcc.PromptText = "digite seu usuário...";
            this.txtNumAcc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumAcc.SelectedText = "";
            this.txtNumAcc.SelectionLength = 0;
            this.txtNumAcc.SelectionStart = 0;
            this.txtNumAcc.ShortcutsEnabled = true;
            this.txtNumAcc.Size = new System.Drawing.Size(173, 28);
            this.txtNumAcc.TabIndex = 3;
            this.txtNumAcc.UseSelectable = true;
            this.txtNumAcc.WaterMark = "digite seu usuário...";
            this.txtNumAcc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumAcc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(147, 2);
            this.metroTextBox1.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(166, 194);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '*';
            this.metroTextBox1.PromptText = "digite sua senha...";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(173, 28);
            this.metroTextBox1.TabIndex = 4;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "digite sua senha...";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnEfetuarLogin
            // 
            this.btnEfetuarLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEfetuarLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEfetuarLogin.FlatAppearance.BorderSize = 0;
            this.btnEfetuarLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEfetuarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEfetuarLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEfetuarLogin.Location = new System.Drawing.Point(95, 251);
            this.btnEfetuarLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnEfetuarLogin.Name = "btnEfetuarLogin";
            this.btnEfetuarLogin.Size = new System.Drawing.Size(244, 41);
            this.btnEfetuarLogin.TabIndex = 10;
            this.btnEfetuarLogin.Text = "Efetuar login";
            this.btnEfetuarLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEfetuarLogin.UseVisualStyleBackColor = true;
            this.btnEfetuarLogin.Click += new System.EventHandler(this.btnEfetuarLogin_Click);
            // 
            // btnSuporte
            // 
            this.btnSuporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuporte.FlatAppearance.BorderSize = 0;
            this.btnSuporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSuporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuporte.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuporte.Location = new System.Drawing.Point(10, 350);
            this.btnSuporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuporte.Name = "btnSuporte";
            this.btnSuporte.Size = new System.Drawing.Size(148, 41);
            this.btnSuporte.TabIndex = 11;
            this.btnSuporte.Text = "Suporte";
            this.btnSuporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuporte.UseVisualStyleBackColor = true;
            this.btnSuporte.Click += new System.EventHandler(this.btnSuporte_Click);
            // 
            // btnEsqSenha
            // 
            this.btnEsqSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEsqSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEsqSenha.FlatAppearance.BorderSize = 0;
            this.btnEsqSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEsqSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsqSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsqSenha.Location = new System.Drawing.Point(166, 350);
            this.btnEsqSenha.Margin = new System.Windows.Forms.Padding(4);
            this.btnEsqSenha.Name = "btnEsqSenha";
            this.btnEsqSenha.Size = new System.Drawing.Size(284, 41);
            this.btnEsqSenha.TabIndex = 12;
            this.btnEsqSenha.Text = "Esqueci minha senha, e agora?";
            this.btnEsqSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEsqSenha.UseVisualStyleBackColor = true;
            this.btnEsqSenha.Click += new System.EventHandler(this.btnEsqSenha_Click);
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCriarConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarConta.FlatAppearance.BorderSize = 0;
            this.btnCriarConta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnCriarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarConta.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarConta.Location = new System.Drawing.Point(24, 52);
            this.btnCriarConta.Margin = new System.Windows.Forms.Padding(4);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(163, 28);
            this.btnCriarConta.TabIndex = 13;
            this.btnCriarConta.Text = "Criar uma nova conta";
            this.btnCriarConta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCriarConta.UseVisualStyleBackColor = true;
            this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 403);
            this.Controls.Add(this.btnCriarConta);
            this.Controls.Add(this.btnEsqSenha);
            this.Controls.Add(this.btnSuporte);
            this.Controls.Add(this.btnEfetuarLogin);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.txtNumAcc);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Efetuar Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtNumAcc;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Button btnEfetuarLogin;
        private System.Windows.Forms.Button btnSuporte;
        private System.Windows.Forms.Button btnEsqSenha;
        private System.Windows.Forms.Button btnCriarConta;
    }
}