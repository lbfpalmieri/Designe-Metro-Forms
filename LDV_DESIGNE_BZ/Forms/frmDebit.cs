using System.Windows.Forms;

namespace LDV_DESIGNE_BZ.Forms
{
    public partial class frmDebit : MetroFramework.Forms.MetroForm
    {
        public frmDebit()
        {
            InitializeComponent();
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


    }
}
