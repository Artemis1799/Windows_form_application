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

namespace sante
{
    public partial class Form1 : Form
    {
        private SQLiteConnection connec;
        private string newDateDebut = "";
        private string newDateFin = "";

        public Form1()
        {
            InitializeComponent();

            string chaine = "Data Source=Sante2023.sqlite";

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

            string requeteCentre = @"select num_centre, lib_centre from Centre;";
            SQLiteDataAdapter da1 = new SQLiteDataAdapter(requeteCentre, connec);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            cboCentre.DataSource = dt1;
            cboCentre.DisplayMember = "lib_centre";
            cboCentre.ValueMember = "num_centre";

            string requeteInf = @"select code_inf, nom_inf from Infirmière;";
            SQLiteDataAdapter da2 = new SQLiteDataAdapter(requeteInf, connec);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            cboInf.DataSource = dt2;
            cboInf.DisplayMember = "nom_inf";
            cboInf.ValueMember = "code_inf";
        }

        private void rdbRechercheCentre_CheckedChanged(object sender, EventArgs e)
        {
            cboInfCentre.DataSource = null;
            if (rdbRechercheCentre.Checked == true)
            {
                cboCentre.Visible = true;
                cboInfCentre.Visible = true;
            }
            else
            {
                cboCentre.Visible = false;
                cboInfCentre.Visible = false;
                
            }
        }

        private void rdbRechercheInfermiere_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rdbRechercheInfermiere.Checked == true)
            {
                cboInf.Visible = true;
            }
            else
            {
                cboInf.Visible = false;
            }
        }

        private void cboCentre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCentre.Visible)
            {
                if (cboCentre.SelectedIndex != -1)
                {
                    string centre = cboCentre.SelectedValue.ToString();

                    string requeteInfCentre = @"select code_inf, nom_inf||' '||prenom_inf as Infi from Infirmière where num_centre =( 
                                            select num_centre from Centre where num_centre =" + centre + ");";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(requeteInfCentre, connec);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboInfCentre.DataSource = dt;
                    cboInfCentre.DisplayMember = "Infi";
                    cboInfCentre.ValueMember = "code_inf";
                }
            }
        }

        private void mthCal_DateSelected(object sender, DateRangeEventArgs e)
        {
            string dateDebut = mthCal.SelectionRange.Start.ToShortDateString();
            DateTime originalDateDebut = DateTime.ParseExact(dateDebut, "dd/MM/yyyy", null);
            newDateDebut = "\"" + originalDateDebut.ToString("yyyy-MM-dd") + "\"";

            string dateFin = mthCal.SelectionRange.End.ToShortDateString();
            DateTime originalDateFin = DateTime.ParseExact(dateFin, "dd/MM/yyyy", null);
            newDateFin = "\"" + originalDateFin.ToString("yyyy-MM-dd") + "\"";

        }

        private void btnConnecte_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(newDateDebut);
            //MessageBox.Show(newDateFin);
            string requete = "";
            string codeInf = "";
            string codeCentre = "";
            //string centre = cboCentre.SelectedValue.ToString();


            if (rdbRechercheInfermiere.Checked)
            {
                codeInf = "\"" + cboInf.SelectedValue.ToString() + "\"";
                requete = @"select v.date_visite, p.nom_patient, v.heure_arr, v.heure_dep, v.observ from 
                            Visite v join Patient p on v.code_patient = p.num_patient 
                            where v.date_visite BETWEEN " + newDateDebut + " and " + newDateFin + " and v.code_inf = " + codeInf + ";";
            }

            if (rdbRechercheCentre.Checked)
            {
                codeCentre = cboCentre.SelectedValue.ToString();
                codeInf = "\"" + cboInfCentre.SelectedValue.ToString() +"\"";
                requete = @"select v.date_visite, p.nom_patient, v.heure_arr, v.heure_dep, v.observ from 
                            Visite v join Patient p on v.code_patient = p.num_patient 
                            where v.date_visite BETWEEN " + newDateDebut + " and " + newDateFin + " and v.code_inf =" +
                            "(select code_inf from Infirmière where code_inf = "+ codeInf +" and num_centre = "+ codeCentre + ");";
            }
            //MessageBox.Show(requete);
            SQLiteCommand cd = new SQLiteCommand(requete, connec);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cd);
            da.SelectCommand = cd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }
    }
}
