using MetroFramework.Forms;
using LDV_DESIGNE_BZ.Forms;
using System.Windows.Forms;
using LDV_DESIGNE_BZ.Class;
using System;

namespace LDV_DESIGNE_BZ
{
    public partial class frmMenu : MetroForm
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        BankStatementDAO statement = new BankStatementDAO();

        private void frmMenu_Load(object sender, System.EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lDV_PEDREIRADataSet.LDVBANKACCOUNT'. Você pode movê-la ou removê-la conforme necessário.
            this.lDVBANKACCOUNTTableAdapter.Fill(this.lDV_PEDREIRADataSet.LDVBANKACCOUNT);
            //lblTesteSaldo.Text = Convert.ToString(statement.ObterDadosConta("x"));
        }

        private void btnDebit_Click(object sender, System.EventArgs e)
        {
            using (frmDebit debit = new frmDebit())
            {
                debit.ShowDialog();
            }
        }

        private void btnDeposit_Click(object sender, System.EventArgs e)
        {
            using (frmDeposit deposit = new frmDeposit())
            {
                deposit.ShowDialog();
            }
        }

        private void btnUnicAccount_Click(object sender, System.EventArgs e)
        {
            using (frmConfigAccount config = new frmConfigAccount())
            {
                config.ShowDialog();
            }  
        }

        private void btnAllAccounts_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Em construção", "ALERTA !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            lblSaldoTotal.Text = Convert.ToString(statement.SaldoTotalConta(lblNumConta.Text));
            lblValorNegativo.Text = Convert.ToString(statement.TotalDebito(lblNumConta.Text));
            lblValorDeposito.Text = Convert.ToString(statement.TotalDeposito(lblNumConta.Text));
        }

        private void cbNumConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNumConta.Text = cbNumConta.Text;
            lblNumContaNegativo.Text = cbNumConta.Text;
            lblNumContaPositivo.Text = cbNumConta.Text;
        }

        private void cbNumConta_MouseEnter(object sender, EventArgs e)
        {
            this.lDVBANKACCOUNTTableAdapter.Fill(this.lDV_PEDREIRADataSet.LDVBANKACCOUNT);
        }
    }
}
