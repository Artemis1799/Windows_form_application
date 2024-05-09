using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appliTransfoListe
{
    public partial class frmTranso : Form
    {
        public bool inclue = false;
        public frmTranso()
        {
            InitializeComponent();
        }

        private void btnToutGaucheVersDroite_Click(object sender, EventArgs e)
        {
            // en une fois
            lstDroite.Items.AddRange(lstGauche.Items);
            lstGauche.Items.Clear();

            // avec une boucle
            /*
            foreach(string elt in lstGauche.Items)
            {
                lstDroite.Items.Add(elt);
            }
            lstGauche.Items.Clear();
            */
        }

        private void btnGaucheVersDroite_Click(object sender, EventArgs e)
        {
            foreach (string elt in lstGauche.SelectedItems)
            {
                lstDroite.Items.Add(elt);
            }

            for (int i = lstGauche.SelectedItems.Count - 1; i>=0; i--)
            {
                lstGauche.Items.Remove(lstGauche.SelectedItems[i]);
            }
        }
        private void btnToutDroiteVersGauche_Click(object sender, EventArgs e)
        {
            lstGauche.Items.AddRange(lstDroite.Items);
            lstDroite.Items.Clear();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            pnlNouveau.Visible = true;
            txtNouveau.Focus();
        }

        private void txtNouveau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNouveau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string elt = txtNouveau.Text;
                foreach (string elt2 in lstGauche.Items)
                {
                    if (elt2.ToLower() == elt.ToLower().Trim())
                        inclue = true;
                }
                if (!inclue)
                {
                    foreach (string elt2 in lstDroite.Items)
                    {
                        if (elt2.ToLower() == elt.ToLower().Trim())
                            inclue = true;
                    }
                }
                if (!inclue)
                {
                    lstGauche.Items.Add(elt);
                    errorProvider1.SetError(txtNouveau, ""); 
                }
                else
                {
                    errorProvider1.SetError(txtNouveau, "error");
                    inclue = false;
                }

            }
        }
    }
}
