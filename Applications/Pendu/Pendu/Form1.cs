using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using Image = System.Drawing.Image;
using System.Security.Cryptography;
using System.Media;


namespace Pendu
{
    public partial class frmMain : Form
    {
        public int nbErreurs = 0;
        public int nbLettresATrouver;

        public int nbVictoire = 0;
        public int nbDefaite = 0;
        private int indiceImg = 0;

        public List<Image> img = new List<Image>() {
            Properties.Resources._1,
            Properties.Resources._2,
            Properties.Resources._3,
            Properties.Resources._4,
            Properties.Resources._5,
            Properties.Resources._6,
            Properties.Resources._7,
            Properties.Resources._8,
            Properties.Resources._9,
            Properties.Resources._10,
            Properties.Resources._11
        };

        SoundPlayer good = new SoundPlayer();
        SoundPlayer bad = new SoundPlayer();
        SoundPlayer lose = new SoundPlayer();

        public frmMain()
        {
            good.SoundLocation = "C:\\Users\\EnoBe\\Documents\\University\\BUT A1\\S2\\A21\\Applications\\Pendu\\Pendu\\sons\\Old victory sound roblox.wav";
            bad.SoundLocation = "C:\\Users\\EnoBe\\Documents\\University\\BUT A1\\S2\\A21\\Applications\\Pendu\\Pendu\\sons\\Vine Boom sound effect meme.wav";
            lose.SoundLocation = "C:\\Users\\EnoBe\\Documents\\University\\BUT A1\\S2\\A21\\Applications\\Pendu\\Pendu\\sons\\Vine Boom Spam..wav";
            InitializeComponent();
        }

        List<string> tabMots = new List<string>()
        {
            "physique", "chimie", "biologie", "mathematiques", "philosophie", "astronomie", "archeologie", "psychologie", "sociologie", "politique",
            "economie", "geographie", "historique", "literature", "bibliotheque", "catalogue", "ingenierie", "architecture", "journalisme", "meteorologie",
            "microbiologie", "neurologie", "oncologie", "paleontologie", "parapsychologie", "parasitologie", "pathologie", "pediatrie", "pharmacologie", "radiologie",
            "respiratoire", "rhumatologie", "urologie", "virologie", "zoologie", "botanique", "mycologie", "ornithologie", "entomologie", "cryptographie",
            "esoterisme", "spiritualite", "folklorique", "mythologie", "cosmologie", "astrologie", "numerologie", "paranormal", "surnaturel", "scoliose",
            "polytechnique", "connaissance", "extraordinaire", "incomprehensible", "inexplique", "inimitable", "inintelligible", "indispensable", "inconcevable", "interessant",
            "impressionnant", "inaccessible", "irrationnel", "inoubliable", "catastrophique", "catastrophe", "incontestable", "cristallin", "cristallographie", "crepusculaire",
            "dramatique", "eclatant", "encore", "enigmatique", "epoustouflant", "equivoque", "incontournable", "inaccessible", "magistral", "magnanime",
            "majestueux", "miraculeux", "nuageux", "numerique", "fantastique", "fabuleux", "mythique", "fabuleux", "excentrique", "extraordinaire",
            "exotique", "phenomenal", "imperceptible", "intangible", "invisible", "incomprehensible", "ephemere", "inestimable", "peremptoire", "determinant"
        };
        string motMystere;

        private int generePlace()
        {
            Random rnd = new Random();
            int pos = rnd.Next(0, tabMots.Count());
            return pos;
        }


        private void reset()
        {
            indiceImg = 0;
            grpMot.Controls.Clear();
            nbErreurs = 0;
            lblFautesNb.Text = nbErreurs.ToString() + "/11";
            initMot();

        }

        private void initMot()
        {
            motMystere = tabMots[generePlace()];
            nbLettresATrouver = motMystere.Length;
            int bordGauche = 30;
            int bordHaut = 30;
            for (int i = 0; i < motMystere.Length; i++)
            {
                // instanciation d'un label
                Label l = new Label();
                l.Left = bordGauche;
                l.Top = bordHaut;
                l.Width = 30;
                l.Height = 30;
                l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                l.Tag = motMystere[i].ToString();
                l.BorderStyle = BorderStyle.FixedSingle;
                if (i == 0 || i == motMystere.Length - 1 || !char.IsLetter(motMystere[i]))
                {
                    l.Text =motMystere[i].ToString();
                    nbLettresATrouver--;
                }
                // ajout du composant à la collection Controls du container
                grpMot.Controls.Add(l);
                bordGauche += 35;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            initMot();
        }

        private void poubelle()
        {
            /*
            this.lblX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblX.Location = new System.Drawing.Point(25, 41);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(56, 48);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "x";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            */
        }

        private void txtProposition_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (txtProposition.Text.Length == 0 && Char.IsLetter(e.KeyChar) && Char.IsLetterOrDigit(e.KeyChar) && !Char.IsDigit(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) || e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                if (e.KeyChar == (char)Keys.Enter)
                {
                    bool trouve = false;
                    foreach (Label l in grpMot.Controls)
                    {
                        if (l.Tag.ToString() == txtProposition.Text && (l.Text==string.Empty))
                        {
                            l.Text = txtProposition.Text;
                            trouve = true;
                            nbLettresATrouver--;
                        }
                    }
                    txtProposition.Text = string.Empty;
                    if (!trouve)
                    {
                        grbPendu.Controls.Clear();
                        nbErreurs += 1;
                        lblFautesNb.Text = nbErreurs.ToString() + "/11";

                        PictureBox image = new PictureBox();
                        image.BorderStyle = BorderStyle.FixedSingle;
                        image.Left = 0;
                        image.Top = 0;
                        image.Size = grbPendu.Size;
                        image.SizeMode = PictureBoxSizeMode.StretchImage;
                        image.Name = "test";
                        image.Tag = 1;
                        image.Image = img[indiceImg];
                        indiceImg++;
                        grbPendu.Controls.Add(image);
                        bad.Play();

                    }
                    // perdu
                    if (nbErreurs == 11)
                    {
                        lose.Play();
                        MessageBox.Show("perdu\nResultat : " + motMystere);
                        reset();
                        nbDefaite++;
                        lblDefaiteNb.Text = nbDefaite.ToString();
                        grbPendu.Controls.Clear();
                    }
                    // gagné
                    if(nbLettresATrouver == 0)
                    {
                        good.Play();
                        MessageBox.Show("bg");
                        reset();
                        nbVictoire++;
                        lblVictoireNb.Text = nbVictoire.ToString();
                        grbPendu.Controls.Clear();
                    }
                }
            }    
        }

        private void btnRecommencer_Click(object sender, EventArgs e)
        {
            reset();
            grbPendu.Controls.Clear();
        }
    }
}
