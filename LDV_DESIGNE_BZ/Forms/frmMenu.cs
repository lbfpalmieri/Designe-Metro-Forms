using MetroFramework.Forms;
using LDV_DESIGNE_BZ.Forms;

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
    }
}
