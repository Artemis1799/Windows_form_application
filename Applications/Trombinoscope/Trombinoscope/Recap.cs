using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trombinoscope
{
    public partial class frmRecap : Form
    {
        public bool absence = false;
        public frmRecap()
        {
            InitializeComponent();
        }

        public frmRecap(string nomEtudiant)
        {
            InitializeComponent();
            this.Text = "Ficher de " + nomEtudiant;
            lblRecap.Text = "Recap de " + nomEtudiant;
        }
        public frmRecap( string nomEtudiant, string cheminPhoto)
        {
            InitializeComponent();
            this.Text = "Ficher de " + nomEtudiant;
            lblRecap.Text = "Recap de " + nomEtudiant;
            pcbEtudiant.Image = (Image)Properties.Resources.ResourceManager.GetObject(cheminPhoto);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ckbAbsence_CheckedChanged(object sender, EventArgs e)
        {
            absence = !absence;
        }
    }
}
