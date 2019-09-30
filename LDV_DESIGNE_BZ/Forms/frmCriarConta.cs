using System;
using LDV_DESIGNE_BZ.Class;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace LDV_DESIGNE_BZ.Forms
{
    public partial class frmCriarConta : MetroForm
    {
        public frmCriarConta()
        {
            InitializeComponent();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            //Atribuindo as informações para a o banco
            User user = new User(txtCpf.Text, txtNomeUsuario.Text, txtSenha.Text, txtEmail.Text, txtTelefone.Text, txtNome.Text, txtSobrenome.Text);
            UserDAO userDao = new UserDAO();

            //Atribuindo o objeto ao BankStatement
            userDao.AddUser(user);
            MessageBox.Show("Cadastrado !");
        }

        private void txtCodConta_TextChanged(object sender, EventArgs e)
        {
            if (txtCodConta.Text == "1234")
            {
                txtCpf.Visible = true;
                txtEmail.Visible = true;
                txtNome.Visible = true;
                txtNomeUsuario.Visible = true;
                txtSenha.Visible = true;
                txtSobrenome.Visible = true;
                txtTelefone.Visible = true;

                lblCPF.Visible = true;
                lblEmail.Visible = true;
                lblNome.Visible = true;
                lblNomeUser.Visible = true;
                lblSenha.Visible = true;
                lblSobrenome.Visible = true;
                lblTel.Visible = true;

                btnCriarConta.Visible = true;
            }
            else
            {
                txtCpf.Visible = false;
                txtEmail.Visible = false;
                txtNome.Visible = false;
                txtNomeUsuario.Visible = false;
                txtSenha.Visible = false;
                txtSobrenome.Visible = false;
                txtTelefone.Visible = false;

                lblCPF.Visible = false;
                lblEmail.Visible = false;
                lblNome.Visible = false;
                lblNomeUser.Visible = false;
                lblSenha.Visible = false;
                lblSobrenome.Visible = false;
                lblTel.Visible = false;

                btnCriarConta.Visible = false;
            }
        }
    }
}
