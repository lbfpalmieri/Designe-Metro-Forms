using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using LDV_DESIGNE_BZ.Class;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace LDV_DESIGNE_BZ.Forms
{
    public partial class frmConfigAccount : MetroFramework.Forms.MetroForm
    {
        public frmConfigAccount()
        {
            InitializeComponent();
        }

        private void frmConfigAccount_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lDV_PEDREIRADataSet.LDVBANKACCOUNT'. Você pode movê-la ou removê-la conforme necessário.
            this.lDVBANKACCOUNTTableAdapter.Fill(this.lDV_PEDREIRADataSet.LDVBANKACCOUNT);

        }

        #region Limpar();
        private void Limpar(Control controles)
        {
            foreach (Control ctr in controles.Controls)
            {
                if (ctr is TextBox)
                {
                    (ctr as TextBox).Clear();
                }
                if (ctr is ComboBox)
                {
                    (ctr as ComboBox).SelectedIndex = -1;
                }
                if (ctr is MaskedTextBox)
                {
                    (ctr as MaskedTextBox).Clear();
                }
                if (ctr is RadioButton)
                {
                    (ctr as RadioButton).Checked = false;

                }

                if (ctr.HasChildren)
                {
                    Limpar(ctr);
                }
            }
        }
        #endregion

        #region Inserindo uma nova conta bancaria no sistema
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (txtNumAcc.Text == string.Empty || txtCpfHolder.Text == string.Empty)
            {
                DialogResult resultado3 = MessageBox.Show("Preencha todos os campos ! ", "Erro !", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (resultado3 == DialogResult.OK)
                {
                    Limpar(this);
                }
            }
            else
            {
                //Atribuindo as informações para a o banco
                Bank b = new Bank(txtNumAcc.Text, txtCpfHolder.Text);
                BankDAO bkDao = new BankDAO();

                //Atribuindo o objeto ao BankStatement
                bkDao.DepositBankStatement(b);
                MessageBox.Show("Cadastrado !");
                Limpar(this);
            }
        }
        #endregion
    }
}
