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
    public partial class frmLogin : MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEfetuarLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                using (frmMenu menu = new frmMenu())
                {
                    menu.ShowDialog();
                }
            }
            catch
            {
            }
            finally
            {
            }
        }

        private void btnSuporte_Click(object sender, EventArgs e)
        {
            using (frmSuporte sup = new frmSuporte())
            {
                sup.ShowDialog();
            }
        }

        private void btnEsqSenha_Click(object sender, EventArgs e)
        {
            using (frmEsqueceuSenha es = new frmEsqueceuSenha())
            {
                es.ShowDialog();
            }
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            using (frmCriarConta cc = new frmCriarConta())
            {
                cc.ShowDialog();
            }
        }
    }
}
