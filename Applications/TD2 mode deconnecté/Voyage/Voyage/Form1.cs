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

namespace Voyage
{
    public partial class Form1 : Form
    {
        private SQLiteConnection connec;
        private DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();

            string chaine = "Data Source=Voyage2.sqlite";

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

        }

        private void btn_exo1_Click(object sender, EventArgs e)
        {
            // exo 1
            string sql = @"select * from tblVoyages;";

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, connec);
            da.Fill(ds, "mesVoyages");

            string texte = "Nombre de voyages transférés : " + ds.Tables["mesVoyages"].Rows.Count.ToString();
            MessageBox.Show(texte);
        }

        private void charger_cbo(ComboBox cb, string nomTable, string colonne)
        {
            for (int i = 0; i < ds.Tables[nomTable].Rows.Count; i++)
            {
                cbo_ligne.Items.Add(ds.Tables[nomTable].Rows[i][colonne].ToString());
            }
        }

        private void charger_cbo(ComboBox cb, string nomTable, string colonneAffiche, string colonneRetour)
        {
            cb.DataSource = ds.Tables[nomTable];
            cb.DisplayMember = colonneAffiche;
            cb.ValueMember = colonneRetour;
        }

        private void btn_exo2_Click(object sender, EventArgs e)
        {
            charger_cbo(cbo_ligne, "mesVoyages", "Destination");
            charger_cbo(cbo_lisaison, "mesVoyages", "Destination", "CodeVoyage");
        }

        private void btn_exo3_Click(object sender, EventArgs e)
        {
            DataTable schemaTable = connec.GetSchema("Tables");
            dgv.DataSource = schemaTable;
            string list = "";
            SQLiteDataAdapter da2;
            int nb = schemaTable.Rows.Count;
            for (int i = 0; i < nb; i++)
            {
                string nomTable = schemaTable.Rows[i][2].ToString();

                string req = "select * from " + nomTable;
                da2 = new SQLiteDataAdapter(req, this.connec);
                da2.Fill(ds, nomTable);
                list += nomTable + "\n";
            }
            MessageBox.Show(list + "\n" + nb);
        }

        private void cbo_lisaison_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string code = cbo_lisaison.SelectedValue.ToString();

            DataRow[] rows = ds.Tables["tblReservations"].Select($"CodeVoyage = '{code}'");
            int reservation = rows.Length;

            string result = "Il y a " + reservation + " réservations pour cette destination";
            MessageBox.Show(result);
        }
    }
}
