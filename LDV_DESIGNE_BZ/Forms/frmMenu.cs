using MetroFramework.Forms;
using LDV_DESIGNE_BZ.Forms;
using System.Windows.Forms;

namespace LDV_DESIGNE_BZ
{
    public partial class frmMenu : MetroFramework.Forms.MetroForm
    {
        public frmMenu()
        {
            InitializeComponent();
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
            MessageBox.Show("Em construção", "ALERTA !", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void btnAllAccounts_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Em construção", "ALERTA !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
