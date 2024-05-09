using QuizzGeographique.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace QuizzGeographique
{
    public partial class frmQuizz : Form
    {
        public frmQuizz()
        {
            InitializeComponent();
            good.SoundLocation = "C:\\Users\\EnoBe\\Documents\\University\\BUT A1\\S2\\A21\\Applications\\QuizzGeographique\\QuizzGeographique\\sounds\\OuoooooOuoooo.wav";
            bad.SoundLocation = "C:\\Users\\EnoBe\\Documents\\University\\BUT A1\\S2\\A21\\Applications\\QuizzGeographique\\QuizzGeographique\\sounds\\AaaahhhhAaaaahhhh.wav";
        }

        SoundPlayer good = new SoundPlayer();
        SoundPlayer bad = new SoundPlayer();

        public int nbQst = 0;
        public int nbRep = 0;
        public int indexCap = 0;
        public int indexPays = 0;

        public bool valide = false;
        public bool choisi = false;

        List<string> pays = new List<string>()
        {
            "Afghanistan", "Albanie", "Algérie", "Allemagne", "Andorre", "Angola", "Antigua-et-Barbuda", "Arabie Saoudite",
            "Argentine", "Arménie", "Australie", "Autriche", "Azerbaïdjan", "Bahamas", "Bahreïn", "Bangladesh", "Barbade",
            "Bélarus", "Belgique", "Belize", "Bénin", "Bhoutan", "Bolivie", "Bosnie-Herzégovine", "Botswana", "Brésil",
            "Brunéi Darussalam", "Bulgarie", "Burkina Faso", "Burundi", "Cambodge", "Cameroun", "Canada", "Cap-Vert", "République centrafricaine",
            "Tchad", "Chili", "Chine", "Chypre", "Colombie", "Comores", "Congo", "République démocratique du Congo", "Corée du Nord",
            "Corée du Sud", "Costa Rica", "Côte d'Ivoire", "Croatie", "Cuba", "Danemark", "Djibouti", "Dominique", "Égypte",
            "Salvador", "Émirats arabes unis", "Équateur", "Érythrée", "Espagne", "Estonie", "États-Unis", "Éthiopie", "Fidji"
        };

        // Liste des capitales correspondantes
        List<string> capitales = new List<string>()
        {
            "Kaboul", "Tirana", "Alger", "Berlin", "Andorre-la-Vieille", "Luanda", "Saint John's", "Riyad",
            "Buenos Aires", "Erevan", "Canberra", "Vienne", "Bakou", "Nassau", "Manama", "Dacca", "Bridgetown",
            "Minsk", "Bruxelles", "Belmopan", "Porto-Novo", "Thimphou", "La Paz", "Sarajevo", "Gaborone", "Brasilia",
            "Bandar Seri Begawan", "Sofia", "Ouagadougou", "Bujumbura", "Phnom Penh", "Yaoundé", "Ottawa", "Praia", "Bangui",
            "N'Djamena", "Santiago", "Pékin", "Nicosie", "Bogota", "Moroni", "Brazzaville", "Kinshasa", "Pyongyang",
            "Séoul", "San José", "Yamoussoukro", "Zagreb", "La Havane", "Copenhague", "Djibouti", "Roseau", "Le Caire",
            "San Salvador", "Abou Dabi", "Quito", "Asmara", "Madrid", "Tallinn", "Washington, D.C.", "Addis-Abeba", "Suva"
        };

        private void frmQuizz_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, pays.Count);
            int[] tab = new int[4];
            NouvelleQuestion(randomNumber, tab);

        }

        public static void MelangeTableau(int[] array)
        {
            Random random = new Random();
            int arrayLength = array.Length;

            for (int i = arrayLength - 1; i > 1; --i)
            {
                int randomIndex = random.Next(i);
                int temp = array[i];
                array[i] = array[randomIndex];
                array[randomIndex] = temp;
            }
        }

        private void NouvelleQuestion(int numPays, int[] tabprop)
        {
            valide = false;
            foreach (RadioButton r in grpCap.Controls)
            {
                r.Checked = false;
            }
            Random random = new Random();
            nbQst++;
            tabprop[0] = numPays;
            int i = 1;
            while (i < 4)
            {
                int randomNumber = random.Next(0, pays.Count);
                if (!tabprop.Contains(randomNumber))
                {
                    tabprop[i] = randomNumber;
                    i++;
                }
            }
            MelangeTableau(tabprop);

            txtPays.Text = pays[numPays];

            rdbCap1.Text = capitales[tabprop[0]];
            rdbCap2.Text = capitales[tabprop[1]];
            rdbCap3.Text = capitales[tabprop[2]];
            rdbCap4.Text = capitales[tabprop[3]];
            
        }

        private void btnAutreQst_Click(object sender, EventArgs e)
        {
            choisi = false;
            if (valide)
            {
                Random random = new Random();
                txtCorrection.Text = "";
                int randomNumber = random.Next(0, pays.Count);
                int[] tab = new int[4];
                NouvelleQuestion(randomNumber, tab);
                foreach (RadioButton r in grpCap.Controls)
                {
                    r.Enabled = true;
                }
            }
        }

        private void rdbCap1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbCap1_Click(object sender, EventArgs e)
        {
            choisi = true;
            RadioButton r = (RadioButton)sender;

            string cap = r.Text;
            string pay = txtPays.Text;
            indexCap = capitales.IndexOf(cap);
            indexPays = pays.IndexOf(pay);

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (choisi && !valide)
            {
                valide = true;
                if (indexCap == indexPays)
                {
                    good.Play();
                    nbRep++;
                }
                else
                {
                    bad.Play();
                }
                txtCorrection.Text = capitales[indexPays];
                var pourcentage = ((double)nbRep / nbQst) * 100;
                txtPourcentage.Text = pourcentage.ToString() + "%";

                foreach (RadioButton r in grpCap.Controls)
                {
                    r.Enabled = false;
                }
            }
        }

        private void txtPays_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPays_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            
        }
    }
}
