using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voyage_2
{
    public partial class Form2 : Form
    {
        private SQLiteConnection connec;
        private DataSet ds = new DataSet();

        public Form2()
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

        private void Form2_Load(object sender, EventArgs e)
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
                // Définir une clé primaire sur la colonne "CodeVoyage" de la table "tblvoyages"
                ds.Tables["tblVoyages"].PrimaryKey = new DataColumn[] { ds.Tables["tblVoyages"].Columns["CodeVoyage"] };

                // Définir une clé étrangère sur la colonne "CodeVoyage" de la table "tblreservations"
                ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("FK_tblreservations_tblvoyages", ds.Tables["tblVoyages"].Columns["CodeVoyage"], ds.Tables["tblReservations"].Columns["CodeVoyage"]);
                ds.Tables["tblReservations"].Constraints.Add(foreignKeyConstraint);

                // Lié le DataGridView à la table "tblreservations"
                dgvPatients.DataSource = ds.Tables["tblVoyages"];
            }
            catch (SQLiteException er)
            {
                MessageBox.Show(er.Message);
            }

            cboTheme.DataSource = ds.Tables["tblThematique"];
            cboTheme.DisplayMember = "libThem";
            cboTheme.ValueMember = "codeThem";
        }


        private void cboTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtre = " 1=1";
            if (cboTheme.SelectedIndex != -1)
            {
                filtre += " and TypeThematique= '" + cboTheme.SelectedValue.ToString() + "'";
            }
            if (txtPrixMax.Text.Length > 0)
            {
                filtre += " and Prix >= " + txtPrixMax.Text.ToString();
            }

            MessageBox.Show(filtre);
            dgvPatients.DataSource = ds.Tables["tblVoyages"].Select(filtre).CopyToDataTable();
        }

        private void txtPrixMax_TextChanged(object sender, EventArgs e)
        {
            string filtre = " 1=1";
            if (cboTheme.SelectedIndex != -1)
            {
                filtre += " and TypeThematique= '" + cboTheme.SelectedValue.ToString() + "'";
            }
            if (txtPrixMax.Text.Length > 0)
            {
                filtre += " and Prix < " + txtPrixMax.Text.ToString();
            }

            //MessageBox.Show(filtre);
            try
            {
                dgvPatients.DataSource = ds.Tables["tblVoyages"].Select(filtre).CopyToDataTable();
            }
            catch
            {
                //MessageBox.Show("porbleme");
            }
        }

        private void cboTheme_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string filtre = " 1=1";
            if (cboTheme.SelectedIndex != -1)
            {
                filtre += " and TypeThematique= '" + cboTheme.SelectedValue.ToString() + "'";
            }
            if (txtPrixMax.Text.Length > 0)
            {
                filtre += " and Prix < " + txtPrixMax.Text.ToString();
            }

            //MessageBox.Show(filtre);
            try
            {
                dgvPatients.DataSource = ds.Tables["tblVoyages"].Select(filtre).CopyToDataTable();
            }
            catch
            {
                //MessageBox.Show("porbleme");
            }
        }

        private void btnAddRows_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                // Ajout d'une ligne à tblvoyages
                DataRow newRowVoyage = ds.Tables["tblvoyages"].NewRow();
                newRowVoyage["CodeVoyage"] = "AUS";

                ds.Tables["tblvoyages"].Rows.Add(newRowVoyage);
                */
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
