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
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            // btnAddAccount
            // 
            this.btnAddAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAccount.FlatAppearance.BorderSize = 0;
            this.btnAddAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.Location = new System.Drawing.Point(95, 251);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(244, 41);
            this.btnAddAccount.TabIndex = 10;
            this.btnAddAccount.Text = "Efetuar login";
            this.btnAddAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 350);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Suporte";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(166, 350);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(284, 41);
            this.button2.TabIndex = 12;
            this.button2.Text = "Esqueci minha senha, e agora?";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 403);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddAccount);
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
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}