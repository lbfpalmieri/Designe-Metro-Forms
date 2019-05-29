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
                MessageBox.Show("Favor preencher todos os campos para evitar erros.\nCaso o erro persista entre em contato com o suporte.", "Erro, algo não está preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            /*Melhor solução encontrada para resolver a exception que estava ocorrendo ao clicar
            no esquema de filtro do DataGrid, caso aconteça mais algum bug é necessarios arrumar
            aqui.*/
            try
            {
                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];
                txtNumAcc.Text = row.Cells["NUMBERACCOUNT"].Value.ToString();
                txtCpfHolder.Text = row.Cells["CPFHOLDER"].Value.ToString();
                txtNumAccAlter.Text = row.Cells["NUMBERACCOUNT"].Value.ToString();
            }
            catch (Exception)
            {
            }
        }
        #endregion

        #region Botão para remover uma conta bancaria do sistema
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtNumAcc.Text == string.Empty || txtCpfHolder.Text == string.Empty)
            {
                MessageBox.Show("Favor preencher todos os campos para evitar erros.\nCaso o erro persista entre em contato com o suporte.", "Erro, algo não está preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Você realmente deseja excluir essa conta do sistema?\nClick em (SIM) para excluir e (NÃO) para cancelar a operação.","Excluir ?",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
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
        }
        #endregion

        #region Alterando um conta bancaria no sistema
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtNumAcc.Text == string.Empty || txtCpfHolder.Text == string.Empty)
            {
                MessageBox.Show("Favor preencher todos os campos para evitar erros.\nCaso o erro persista entre em contato com o suporte.", "Erro, algo não está preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Você realmente deseja alterar essa conta do sistema?\n" +
                    "Confirme os dados antes de continuar, se você concorda click em(SIM)\n" +
                    "caso contrario click em (NÃO) para cancelar a edição.\n\n" +
                    "Número da conta: " + txtNumAcc.Text +"\n" +
                    "CPF do titular: " + txtCpfHolder.Text, "Editar ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    //Atribuindo as informações para a o banco
                    BankAccount bAcc = new BankAccount(txtNumAcc.Text, txtCpfHolder.Text, txtNumAccAlter.Text);
                    BankAccountDAO bkAccDao = new BankAccountDAO();

                    //Atribuindo o objeto ao BankStatement
                    bkAccDao.AlterarCliente(bAcc);
                    MessageBox.Show("Alterado !");
                    Limpar(this);
                    this.lDVBANKACCOUNTTableAdapter.Fill(this.lDV_PEDREIRADataSet.LDVBANKACCOUNT);
                }
                else if (result == DialogResult.No)
                {
                    Limpar(this);
                }
            }
        }
        #endregion
    }
}
