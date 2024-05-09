using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comptoir
{
    public partial class Frm2 : Form
    {
        private SQLiteConnection connec;
        public Frm2()
        {
            InitializeComponent();

            string chaine = "Data Source=Comptoir2.sqlite";

            try
            {
                this.connec = new SQLiteConnection(chaine);
                this.connec.Open();
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Frm2_Load(object sender, EventArgs e)
        {
            grpCategorie.Controls.Clear();
            CheckedListBox c = new CheckedListBox();
            // parametrage du composant
            c.Left = 20;
            c.Top = 20;
            c.CheckOnClick = true;
            c.Width = grpCategorie.Width - 40;
            c.Height = grpCategorie.Height - 40;



            string requete = @"SELECT c.`Nom de catégorie`, p.`Nom du produit` 
                              FROM Catégories c JOIN Produits p ON c.`Code catégorie` = p.`Code catégorie` 
                              ORDER BY c.`Nom de catégorie`;";
            SQLiteCommand cd = new SQLiteCommand(requete, connec);
            SQLiteDataReader result = cd.ExecuteReader();
            string catPrecendente = "";
            if (result.HasRows)
            {
                while (result.Read())
                {
                    if (catPrecendente != result.GetString(0))
                    {
                        c.Items.Add(result.GetString(0));
                        catPrecendente = result.GetString(0);
                    }
                }
            }
            grpCategorie.Controls.Add(c);
        }

        private string ConstruireRequeteProduitsCoches(CheckedListBox checkedListBox)
        {
            List<string> categories = new List<string>();
            foreach (CheckedListBox c in grpCategorie.Controls.OfType<CheckedListBox>())
            {
                if(c.CheckedItems.Count < 1)
                {
                    MessageBox.Show("T'as rien coché bro");
                    return "";
                }
                for (int i = 0; i < c.CheckedItems.Count; i++)
                {
                    string cat = c.CheckedItems[i].ToString();
                    categories.Add(cat);
                }
            }

            string catIn = "IN (";
            string requete = "";
            foreach (string cat in categories)
            {
                catIn += "'" + cat.ToUpper() + "',";
            }
            catIn = catIn.TrimEnd(',');
            catIn += ")";

            requete = @"SELECT c.`Nom de catégorie`, p.`Nom du produit`, p.`Prix unitaire`
            FROM Catégories c JOIN Produits p ON c.`Code catégorie` = p.`Code catégorie`
            WHERE UPPER(c.`Nom de catégorie`) " + catIn + " ORDER BY c.`Nom de catégorie`, p.`Nom du produit`;";

            return requete;
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string requete = "";
            foreach (Control ctrl in grpCategorie.Controls)
            {
                if (ctrl is CheckedListBox)
                {
                    CheckedListBox c = (CheckedListBox)ctrl;
                    requete = ConstruireRequeteProduitsCoches(c);
                }
            }

            SQLiteCommand cd = new SQLiteCommand(requete, connec);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }
    }
}
