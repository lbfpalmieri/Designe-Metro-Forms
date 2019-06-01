using System;
using System.Linq;
using System.Windows.Forms;
using LDV_DESIGNE_BZ.Class;
using MetroFramework.Forms;

namespace LDV_DESIGNE_BZ.Forms
{
    public partial class frmDebit : MetroForm
    {
        BankStatementDAO bkDao = new BankStatementDAO();
        BankStatement b = new BankStatement();

        public frmDebit()
        {
            InitializeComponent();
        }      

        #region Load()
        private void frmDebit_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lDV_PEDREIRADataSet.LDVBANKACCOUNT'. Você pode movê-la ou removê-la conforme necessário.
            this.lDVBANKACCOUNTTableAdapter.Fill(this.lDV_PEDREIRADataSet.LDVBANKACCOUNT);
            txtNumAccount.SelectedIndex = -1;
        }
        #endregion

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

        #region KeyPress() txtValue
        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
             (e.KeyChar != ',' && e.KeyChar != '.' &&
              e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtValue.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        #endregion

        #region Enter() txtValue
        private void txtValue_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= txtValue.Text.Length - 1; i++)
            {
                if ((txtValue.Text[i] >= '0' &&
                    txtValue.Text[i] <= '9') ||
                    txtValue.Text[i] == ',')
                {
                    x += txtValue.Text[i];
                }
            }
            txtValue.Text = x;
            txtValue.SelectAll();
        }

        #endregion

        #region Realizando um débito na conta
        private void btnDebit_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text == string.Empty || txtValue.Text == string.Empty || txtData.Text == string.Empty)
            {
                DialogResult resultado3 = MessageBox.Show("Preencha todos os campos ! ", "Erro !", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (resultado3 == DialogResult.OK)
                {
                    Limpar(this);
                }
            }
            else
            {
                //Transformando o valor positivo em negativo
                txtSetValue.Text = lblNegative.Text + txtValue.Text;

                //Atribuindo as informações para a o banco
                BankStatement b = new BankStatement(Convert.ToDecimal(txtSetValue.Text), Convert.ToDateTime(txtData.Text), txtDesc.Text, txtNumAccount.Text);

                //Atribuindo o objeto ao BankStatement
                bkDao.DepositBankStatement(b);
                MessageBox.Show("Cadastrado !");
                Limpar(this);
                lblNegative.Text = "-";
            }
        }
        #endregion
    }
}
