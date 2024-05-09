using System.Data;
using System.Data.SQLite;
using System.Xml;

namespace Voyage_2
{
    public partial class Form1 : Form
    {
        private SQLiteConnection connec;
        private DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
            string chaine = "Data Source=Voyage2023.sqlite";

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
            try
            {

                DataTable schemaTable = connec.GetSchema("Tables");
                string liste = "";
                SQLiteDataAdapter da2;
                for (int i = 0; i < schemaTable.Rows.Count; i++)
                {
                    string nomTable = schemaTable.Rows[i][2].ToString();
                    string req = "SELECT * FROM " + nomTable;
                    da2 = new SQLiteDataAdapter(req, this.connec);
                    da2.Fill(ds, nomTable);
                    liste += nomTable + "\n";
                }
                //MessageBox.Show(liste + "\n" + ds.Tables.Count.ToString() + " tables");

                string sql = @"select res.CodeVoyage, clt.NumClient, clt.NomClient || ' ' || clt.Prenom As leClient,
                            res.NombrePersonnes, res.DateReservation 
                            FROM tblReservations res
                            JOIN tblClients clt ON res.NumClient = clt.NumClient";

                SQLiteCommand cmd = new SQLiteCommand(sql, connec);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(ds, "ResaClient");

                dgv.DataSource = ds.Tables["ResaClient"];
            }
            catch (SQLiteException er)
            {
                MessageBox.Show(er.Message);
            }

            cboDestination.DataSource = ds.Tables["tblVoyages"];
            cboDestination.DisplayMember = "Destination";
            cboDestination.ValueMember = "CodeVoyage";

            Object maDate = ds.Tables["tblReservations"].Compute("Max(DateReservation)", null);
            dtpDate.MaxDate = Convert.ToDateTime(maDate);


        }

        private void chkDestination_CheckedChanged(object sender, EventArgs e)
        {
            cboDestination.Visible = !(cboDestination.Visible);
        }

        private void chkDateDepart_CheckedChanged(object sender, EventArgs e)
        {
            dtpDate.Visible = !(dtpDate.Visible);
        }

        private void chkClient_CheckedChanged(object sender, EventArgs e)
        {
            txtClient.Visible = !(txtClient.Visible);
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            string filtre = " 1=1";
            if (cboDestination.Visible || dtpDate.Visible || txtClient.Visible)
            {

                if (cboDestination.Visible && cboDestination.SelectedIndex != -1)
                {
                    filtre += " and CodeVoyage= '" + cboDestination.SelectedValue.ToString() + "'";
                    //MessageBox.Show(filtre);
                }

                if (dtpDate.Visible)
                {
                    filtre += " and dateReservation= '" + dtpDate.Value.ToString("yyyy-MM-dd") + "'";
                    //MessageBox.Show(filtre);
                }

                if (txtClient.Visible && txtClient.Text.Length > 0)
                {
                    filtre += " and leClient LIKE '" + txtClient.Text.ToString().ToUpper() + "%'";
                }
                MessageBox.Show(filtre);
                dgv.DataSource = ds.Tables["ResaClient"].Select(filtre).CopyToDataTable();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ds.Tables["ResaClient"];
            chkClient.Checked = false;
            chkDateDepart.Checked = false;
            chkDestination.Checked = false;
        }

        private void btnFrm2_Click(object sender, EventArgs e)
        {
            Form2 feuille = new Form2();
            if (feuille.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnAddRows_Click(object sender, EventArgs e)
        {
            try
            {
                // Ajout d'une ligne à tblvoyages
                DataRow newRowVoyage = ds.Tables["tblvoyages"].NewRow();
                newRowVoyage["CodeVoyage"] = "AUS";

                ds.Tables["tblvoyages"].Rows.Add(newRowVoyage);

                // Ajout d'une ligne à tblreservations
                DataRow newRowReservation = ds.Tables["tblreservations"].NewRow();
                newRowReservation["CodeVoyage"] = "ASSIL";

                ds.Tables["tblreservations"].Rows.Add(newRowReservation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de l'ajout des lignes : " + ex.Message);
            }
        }
    }
}
