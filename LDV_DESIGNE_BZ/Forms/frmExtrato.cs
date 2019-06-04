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
    public partial class frmExtrato : MetroForm
    {
        public string NumConta { get; set; }

        public frmExtrato()
        {
            InitializeComponent();
        }

        public frmExtrato(string numConta)
        {
            InitializeComponent();
            NumConta = numConta;
        }

        private void frmExtrato_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lDV_PEDREIRADataSet.LDVBANKSTATEMENT'. Você pode movê-la ou removê-la conforme necessário.
            this.lDVBANKSTATEMENTTableAdapter.Fill(this.lDV_PEDREIRADataSet.LDVBANKSTATEMENT);
            this.lDVBANKSTATEMENTTableAdapter.FillByFiltroConta(this.lDV_PEDREIRADataSet.LDVBANKSTATEMENT, NumConta);
            this.reportViewer1.RefreshReport();

        }

        private void btnFiltroC_Click(object sender, EventArgs e)
        {
            try
            {
                this.lDVBANKSTATEMENTTableAdapter.FillByDate(this.lDV_PEDREIRADataSet.LDVBANKSTATEMENT, cbData.Text, NumConta);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnRetiraF_Click(object sender, EventArgs e)
        {
            try
            {
                this.lDVBANKSTATEMENTTableAdapter.FillByNumconta(this.lDV_PEDREIRADataSet.LDVBANKSTATEMENT, NumConta);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
