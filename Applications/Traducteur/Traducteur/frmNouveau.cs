using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traducteur
{
    public partial class frmNouveau : Form
    {
        public frmNouveau()
        {
            InitializeComponent();
        }

        public string Message 
        {
            get
            {
                return txtNouveau.Text.ToLower().Trim();
            }
        }

        private void txtNouveau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void frmNouveau_Deactivate(object sender, EventArgs e)
        {
            //DialogResult = DialogResult.Cancel;
        }
    }
}
