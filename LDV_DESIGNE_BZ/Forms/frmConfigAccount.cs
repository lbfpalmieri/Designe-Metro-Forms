using System;
using LDV_DESIGNE_BZ.Class;
using System.Windows.Forms;

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
                BankAccount bAcc = new BankAccount(txtNumAcc.Text, txtCpfHolder.Text);
                BankAccountDAO bkAccDao = new BankAccountDAO();

                //Atribuindo o objeto ao BankStatement
                bkAccDao.InsertAccount(bAcc);
                MessageBox.Show("Cadastrado !");
                Limpar(this);
                this.lDVBANKACCOUNTTableAdapter.Fill(this.lDV_PEDREIRADataSet.LDVBANKACCOUNT);
            }
        }

        #endregion

        #region Evento para enviar dados do Grid para o TextBox
        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];

            txtNumAcc.Text = row.Cells["NUMBERACCOUNT"].Value.ToString();
            txtCpfHolder.Text = row.Cells["CPFHOLDER"].Value.ToString();
        }
        #endregion

        #region Botão para remover uma conta bancaria do sistema
        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Se deseja excluir clique em (Sim) caso contrario click em (Não)", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Atribuindo as informações para a o banco
                BankAccount bAcc = new BankAccount(txtNumAcc.Text, txtCpfHolder.Text);
                BankAccountDAO bkAccDao = new BankAccountDAO();

                //Atribuindo o objeto ao BankStatement
                bkAccDao.DeleteAccount(bAcc);
                MessageBox.Show("Removido !");
                Limpar(this);
                this.lDVBANKACCOUNTTableAdapter.Fill(this.lDV_PEDREIRADataSet.LDVBANKACCOUNT);
            }
            else if (result == DialogResult.No)
            {
                Limpar(this);
            }
        }
        #endregion
    }
}
