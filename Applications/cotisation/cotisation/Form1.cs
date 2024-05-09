using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cotisation
{
    public partial class frmCotisation : Form
    {
        private double somme = 0;
        private bool cbBureauBool = false;
        private bool cbActiviteBool = false;
        public frmCotisation()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbBureau_CheckedChanged(object sender, EventArgs e)
        {
            if(cbBureau.Checked)
            {
                cbBureauBool = true;
            }
            else
            {
                cbBureauBool = false;
            }
        }

        private void cbActivite_CheckedChanged(object sender, EventArgs e)
        {
            if (cbActivite.Checked)
            {
                cbActiviteBool = true;
            }
            else
            {
                cbActiviteBool = false;
            }
        }

        private void btnQuitte_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {

            for(int i = int.Parse(txtEnfant.Text); i > 0; i--)
            {
                if(i == 1)
                {
                    somme += 100;
                }
                else if (i == 2)
                {
                    somme += 85;
                }
                else
                {
                    somme += 60;
                }
            }

            string sommeStr = somme.ToString();
            labelPrixBase.Text = sommeStr;

            if (cbActivite.Checked)
            {
                somme *= 0.7;
            }

            if (cbBureau.Checked)
            {
                somme *= 0.8;
            }

            string sommeFinalStr = somme.ToString();
            labelPrixCalcul.Text = sommeFinalStr;
        }
    }
}
