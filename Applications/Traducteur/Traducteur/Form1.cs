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
    public partial class frmTraducteur : Form
    {
        public frmTraducteur()
        {
            InitializeComponent();
        }

        string[,] tabVerbes = {
            { "aller", "to go", "gehen", "ir", "andare" },
            { "boire ", "to drink", "trinken", "beber", "bere" },
            { "chanter", "to sing", "singen", "cantar", "cantare" },
            { "danser", "to dance", "tanzen", "bailar", "ballare" },
            { "fermer", "to close", "schliessen", "cerrar", "chiudere" },
            { "manger", "to eat", "essen", "comer", "mangiare" },
            { "travailler", "to work", "arbeiten", "trabajar", "lavorare" }
        };

        private void frmTraducteur_Load(object sender, EventArgs e)
        {
            for (int i = 0; i< tabVerbes.GetLength(0); i++)
            {
                string elt = tabVerbes[i, 0];
                cboVerbes.Items.Add(elt);
            }
        }

        private void rdbAnglais_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbAnglais_Click(object sender, EventArgs e)
        {
            if (cboVerbes.SelectedIndex != -1)
            {
                //cast du sender
                RadioButton r = (RadioButton)sender;
                
                string langue = r.Text;
                string verbeFr = cboVerbes.Text;
                int numLigne = cboVerbes.SelectedIndex;
                int numColonne = Convert.ToInt16(r.Tag.ToString());
                string verbeLg = tabVerbes[numLigne, numColonne];
                string resultat = "Traduction de " + verbeFr + " en " + langue.ToLower() + " est : " + verbeLg;
                lblResultat.Text = resultat;
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            frmNouveau feuille = new frmNouveau();
            if(feuille.ShowDialog()==DialogResult.OK)
            {
                MessageBox.Show(feuille.Message);
                if(!cboVerbes.Items.Contains(feuille.Message))
                {
                    cboVerbes.Items.Add(feuille.Message);
                    cboVerbes.SelectedIndex = cboVerbes.Items.Count - 1;
                }
            }
        }
    }
}
