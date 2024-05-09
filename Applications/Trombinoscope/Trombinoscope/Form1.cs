using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Trombinoscope
{
    public partial class frmMain : Form
    {
        string[][] tabEtud = { new string[] { "DUT Info G1","Berger", "Diebold", "Gerard", "Munier", "Niefer", "Salmon" },
                                new string[] { "DUT Info G2", "Baumann", "Charlier", "Freund", "Huber", "Klein", "Laluet", "Thuillier", "Tourneur","Walter", "Wendling", "Wurth", "Zorn" } ,
                                new string[] {"LP CDED G1", "Aufrere", "Billod", "Duval", "Eckert", "Fahrner" },};
        
        List<string> saveList = new List<string>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < tabEtud.GetLength(0); i++)
            {
                cboChoix.Items.Add(tabEtud[i][0]);
            }
        }

        private void cboChoix_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpEtudiant.Text = "Etudiants inscrits en " + cboChoix.Text;
            rdbListe.Checked = false;
            rdbTrombino.Checked = false;
            grpEtudiant.Controls.Clear();
        }

        private void rdbListe_CheckedChanged(object sender, EventArgs e)
        {
            Save();
            if (rdbListe.Checked && cboChoix.SelectedIndex != -1)
            {
                grpEtudiant.Controls.Clear();
                CheckedListBox c = new CheckedListBox();
                // parametrage du composant
                c.Left = 20;
                c.Top = 20;
                c.CheckOnClick = true;
                c.Width = grpEtudiant.Width - 40;
                c.Height = grpEtudiant.Height - 40;
                int numPromo = cboChoix.SelectedIndex;
                for (int i = 1; i < tabEtud[numPromo].Length; i++)
                {
                    c.Items.Add(tabEtud[numPromo][i]);
                }
                // ajout à la collection des controles
                grpEtudiant.Controls.Add(c);
            }

            if (chkAucunTout.Checked)
            {
                foreach (Control ctrl in grpEtudiant.Controls)
                {
                    if (ctrl is CheckedListBox)
                    {
                        bool cocherTout = chkAucunTout.Checked;
                        CheckedListBox checkedListBox = (CheckedListBox)ctrl;
                        for (int i = 0; i < checkedListBox.Items.Count; i++)
                        {
                            checkedListBox.SetItemChecked(i, cocherTout);
                        }
                    }
                }
            }
            if (saveList.Count > 0)
                load();
        }

        private void rdbTrombino_CheckedChanged(object sender, EventArgs e)
        {
            Save();
            grpEtudiant.Controls.Clear();

            int bordGauche = 30;
            int bordHaut = 30;

            // Ajouter un nouveau panneau pour contenir les images
            Panel pnlTrombiContent = new Panel();
            pnlTrombiContent.AutoScroll = true; // Activer le défilement automatique
            pnlTrombiContent.Size = grpEtudiant.Size; // Ajuster la taille du panneau à celle de la groupe
            pnlTrombiContent.Top = 20;
            pnlTrombiContent.Left = 20;
            grpEtudiant.Controls.Add(pnlTrombiContent);

            int numPromo = cboChoix.SelectedIndex;
            for (int i = 1; i < tabEtud[numPromo].Length; i++)
            {
                // instanciation d'une pictureBox
                PictureBox image = new PictureBox();
                image.BorderStyle = BorderStyle.FixedSingle;
                image.Left = bordGauche;
                image.Top = bordHaut;
                image.Size = new System.Drawing.Size(71, 85);
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.Name = tabEtud[numPromo][i].ToString();
                image.Tag = i;
                image.Image = Properties.Resources.Thuillier;

                // instanciation d'une chekedBox
                System.Windows.Forms.CheckBox c = new System.Windows.Forms.CheckBox();
                c.Left = bordGauche;
                c.Top = bordHaut + 80;
                c.Name = tabEtud[numPromo][i].ToString();
                c.Tag = i;
                c.Text = tabEtud[numPromo][i].ToString();
                c.Click += new System.EventHandler(Trombi_Click);

                pnlTrombiContent.Controls.Add(image);
                pnlTrombiContent.Controls.Add(c);
                bordGauche += 160;

                if (bordGauche > 700)
                {
                    bordGauche = 30;
                    bordHaut += 150;
                }

                if (chkAucunTout.Checked)
                {
                    foreach (Control ctrl in grpEtudiant.Controls)
                    {
                        if (ctrl is Panel)
                        {
                            bool cocherTout = chkAucunTout.Checked;
                            Panel panel = (Panel)ctrl;
                            foreach (Control autreCtrl in panel.Controls)
                            {
                                if (autreCtrl is System.Windows.Forms.CheckBox)
                                {
                                    System.Windows.Forms.CheckBox checkBox = (System.Windows.Forms.CheckBox)autreCtrl;
                                    checkBox.Checked = cocherTout;
                                }
                            }
                        }
                    }
                }
                if (saveList.Count > 0)
                    load();
            }
        }

        private void chkAucunTout_CheckedChanged(object sender, EventArgs e)
        {
            // premiere maniere de la faire
            if (rdbListe.Checked || rdbTrombino.Checked)
            {
                bool cocherTout = chkAucunTout.Checked;

                if (rdbListe.Checked)
                {
                    foreach (CheckedListBox c in grpEtudiant.Controls.OfType<CheckedListBox>())
                    {
                        for (int i = 0; i < c.Items.Count; i++)
                        {
                            c.SetItemChecked(i, cocherTout);
                        }
                    }
                }

                // deuxieme maniere
                else if (rdbTrombino.Checked)
                {
                    foreach (Control ctrl in grpEtudiant.Controls)
                    {
                        if (ctrl is Panel)
                        {
                            Panel panel = (Panel)ctrl;
                            foreach (Control autreCtrl in panel.Controls)
                            {
                                if (autreCtrl is System.Windows.Forms.CheckBox)
                                {
                                    System.Windows.Forms.CheckBox checkBox = (System.Windows.Forms.CheckBox)autreCtrl;
                                    checkBox.Checked = cocherTout;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            //string saveString = string.Join(", ", saveList.Select(b => b.ToString()));
            //MessageBox.Show(saveString);

            List<string> nomsCoches = new List<string>();

            // liste methode 1
            if (rdbListe.Checked)
            {
                foreach (CheckedListBox c in grpEtudiant.Controls.OfType<CheckedListBox>())
                {
                    for (int i = 0; i < c.CheckedItems.Count; i++)
                    {
                        string nom = c.CheckedItems[i].ToString();
                        nomsCoches.Add(nom);
                    }
                }
            }

            // trombi methode 2
            else if (rdbTrombino.Checked)
            {
                foreach (Control ctrl in grpEtudiant.Controls)
                {
                    if (ctrl is Panel)
                    {
                        Panel panel = (Panel)ctrl;
                        foreach (Control autreCtrl in panel.Controls)
                        {
                            if (autreCtrl is System.Windows.Forms.CheckBox)
                            {
                                System.Windows.Forms.CheckBox checkBox = (System.Windows.Forms.CheckBox)autreCtrl;
                                if (checkBox.Checked)
                                {
                                    string nom = checkBox.Text;
                                    nomsCoches.Add(nom);
                                }
                            }
                        }
                    }
                }
            }

            string nomsIn = "IN (";
            string requete = "";
            foreach (string nom in nomsCoches)
            {
                nomsIn += "'" + nom.ToUpper() + "',";
            }
            nomsIn = nomsIn.TrimEnd(',');
            nomsIn += ")";

            if(nomsIn.Length > 6)
                requete = "SELECT * FROM etudiant WHERE UCASE(nom) " + nomsIn;
            else
                requete = "SELECT * FROM etudiant WHERE UCASE(nom) ";


            MessageBox.Show(requete);
        }



        private void Trombi_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox c = (System.Windows.Forms.CheckBox)sender;
            if (c.Checked)
            {
                frmRecap feuille = new frmRecap(c.Text, "Thuillier");
                if (feuille.ShowDialog() == DialogResult.OK)
                {
                    if (feuille.absence)
                    {
                        MessageBox.Show("Absence justifiée");
                    }
                }
            }
        }

        public void Save()
        {
            saveList.Clear();
            if (rdbListe.Checked || rdbTrombino.Checked)
            {

                if (rdbListe.Checked)
                {
                    foreach (CheckedListBox c in grpEtudiant.Controls.OfType<CheckedListBox>())
                    {
                        foreach (System.Windows.Forms.CheckBox chb in c.Controls)
                        {
                            if (chb is System.Windows.Forms.CheckBox)
                            {
                                saveList.Add(chb.Text);
                            }
                        }
                    }
                }

                else if (rdbTrombino.Checked)
                {
                    foreach (Control ctrl in grpEtudiant.Controls)
                    {
                        if (ctrl is Panel)
                        {
                            Panel panel = (Panel)ctrl;
                            foreach (Control autreCtrl in panel.Controls)
                            {
                                if (autreCtrl is System.Windows.Forms.CheckBox)
                                {
                                    System.Windows.Forms.CheckBox checkBox = (System.Windows.Forms.CheckBox)autreCtrl;
                                    saveList.Add(checkBox.Text);
                                }
                            }
                        }
                    }
                }
            }
        }

        public void load()
        {
            if (rdbListe.Checked || rdbTrombino.Checked)
            {
                if (rdbListe.Checked)
                {
                    foreach (CheckedListBox c in grpEtudiant.Controls.OfType<CheckedListBox>())
                    {
                        for (int i = 0; i < c.Items.Count; i++)
                        {
                            string itemText = c.Items[i].ToString();
                            c.SetItemChecked(i, saveList.Contains(itemText));
                        }
                    }
                }

                else if (rdbTrombino.Checked)
                {
                    foreach (Control ctrl in grpEtudiant.Controls)
                    {
                        if (ctrl is Panel)
                        {
                            Panel panel = (Panel)ctrl;
                            foreach (Control autreCtrl in panel.Controls)
                            {
                                if (autreCtrl is System.Windows.Forms.CheckBox)
                                {
                                    System.Windows.Forms.CheckBox checkBox = (System.Windows.Forms.CheckBox)autreCtrl;
                                    checkBox.Checked = saveList.Contains(checkBox.Text);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
