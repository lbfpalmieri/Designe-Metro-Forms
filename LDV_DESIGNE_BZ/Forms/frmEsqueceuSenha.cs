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
    public partial class frmEsqueceuSenha : MetroForm
    {
        public frmEsqueceuSenha()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCodSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtCodSenha.Text == "1234")
            {
                txtNovaSenha.Visible = true;
                txtRepitaSenha.Visible = true;
                lblNovaSenha.Visible = true;
                lblRepitaSenha.Visible = true;
                btnEfetuarLogin.Visible = true;
            }else{
                txtNovaSenha.Visible = false;
                txtRepitaSenha.Visible = false;
                lblNovaSenha.Visible = false;
                lblRepitaSenha.Visible = false;
                btnEfetuarLogin.Visible = false;
            }
        }
    }
}
