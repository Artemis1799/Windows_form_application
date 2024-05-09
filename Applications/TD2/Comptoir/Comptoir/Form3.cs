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
    public partial class Frm3 : Form
    {
        private SQLiteConnection connec;
        public Frm3()
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

        private void Frm3_Load(object sender, EventArgs e)
        {
            string requeteClient = @"select `Code client`, société from Clients ORDER BY société;";
            SQLiteDataAdapter da1 = new SQLiteDataAdapter(requeteClient, connec);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            cboClient.DataSource = dt1;
            cboClient.DisplayMember = "société";
            cboClient.ValueMember = "Code client";

            string requeteEmploye = @"select Nom||' '||Prénom as np, `N° employé` from Employés;";
            SQLiteDataAdapter da2 = new SQLiteDataAdapter(requeteEmploye, connec);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            cboEmploye.DataSource = dt2;
            cboEmploye.DisplayMember = "np";
            cboEmploye.ValueMember = "N° employé";

            string requeteCommande = @"select max([N° commande]) from Commandes;";
            SQLiteCommand cd = new SQLiteCommand(requeteCommande, connec);
            int result = Convert.ToInt16(cd.ExecuteScalar()) + 1;
            txtNumCommande.Text = result.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int numCommande = int.Parse(txtNumCommande.Text);
            string client = "\'" + cboClient.SelectedValue.ToString() + "\'";
            int employe = int.Parse(cboEmploye.SelectedValue.ToString());
            string date = mthCalendar.SelectionRange.Start.ToShortDateString();
            DateTime originalDateDebut = DateTime.ParseExact(date, "dd/MM/yyyy", null);
            string newDateDebut = "\'" + originalDateDebut.ToString("yyyy-MM-dd") + "\'";
            string requeteClient = "";
            if (txtDestinataire.Text != "")
            {
                string dest = "\'" + txtDestinataire.Text + "\'";
                requeteClient = @"INSERT INTO Commandes (`N° commande`, `Code client`, `N° employé`, `Date commande`, Destinataire) VALUES (" + numCommande.ToString() + ", " + client + " , " + employe.ToString() + ", " + newDateDebut + ", " + dest + ");";
            }
            else
            {
                requeteClient = @"INSERT INTO Commandes (`N° commande`, `Code client`, `N° employé`, `Date commande`) VALUES (" + numCommande.ToString() + ", " + client + " , " + employe.ToString() + ", " + newDateDebut + ");";
            }


            
            MessageBox.Show(requeteClient);
            SQLiteCommand cd = new SQLiteCommand(requeteClient, connec);
            cd.ExecuteNonQuery();
        }
    }
}
