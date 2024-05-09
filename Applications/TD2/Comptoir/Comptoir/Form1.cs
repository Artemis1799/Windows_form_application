using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Comptoir
{
    public partial class Form1 : Form
    {
        private SQLiteConnection connec;

        public Form1()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(this.connec.State.ToString());

            string requete = @"SELECT c.`Nom de catégorie`, p.`Nom du produit` 
                              FROM Catégories c JOIN Produits p ON c.`Code catégorie` = p.`Code catégorie` 
                              ORDER BY c.`Nom de catégorie`;";
            SQLiteCommand cd = new SQLiteCommand(requete, connec);
            SQLiteDataReader result = cd.ExecuteReader();
            string catPrecendente = "";
            int i = 0;
            int p = 0;
            trvProduits.ImageList = imgList;
            if (result.HasRows)
            {
                while (result.Read())
                {
                    if (catPrecendente != result.GetString(0))
                    {
                        trvProduits.Nodes.Add(result.GetString(0));
                        trvProduits.Nodes[i].ImageIndex = i;
                        catPrecendente = result.GetString(0);
                        p = 0;
                        i++;
                    }

                    trvProduits.Nodes[i - 1].Nodes.Add(result.GetString(1));
                    //trvProduits.Nodes[i].Nodes[p].ImageIndex = i;
                    p++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm2 feuille = new Frm2();
            if (feuille.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm3 feuille = new Frm3();
            if (feuille.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
