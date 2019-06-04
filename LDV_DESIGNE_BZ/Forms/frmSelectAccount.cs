using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace LDV_DESIGNE_BZ.Forms
{
    public partial class frmSelectAccount : MetroForm
    {
        public frmSelectAccount()
        {
            InitializeComponent();
        }

        private void frmSelectAccount_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lDV_PEDREIRADataSet.LDVBANKACCOUNT'. Você pode movê-la ou removê-la conforme necessário.
            this.lDVBANKACCOUNTTableAdapter.Fill(this.lDV_PEDREIRADataSet.LDVBANKACCOUNT);

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            using (frmExtrato extrato = new frmExtrato(cbContaBancaria.Text))
            {
                extrato.ShowDialog();
            }
        }
    }
}
