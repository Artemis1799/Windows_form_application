using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace applicationConversion
{
    public partial class FrmConversion : Form
    {
        
        public FrmConversion()
        {
            InitializeComponent();
        }

        private void FrmConversion_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("HELLO WORLD");
        }

        private void FrmConversion_Activated(object sender, EventArgs e)
        {
            //MessageBox.Show("EZ");
        }

        private void txtCelsius_KeyPress(object sender, KeyPressEventArgs e)
        {
            EP1.SetError(txtCelsius, string.Empty);
            txtCelsius.ShortcutsEnabled = true;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Enter && e.KeyChar != (char)Keys.Back && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != '-')
            {
                EP1.SetError(txtCelsius,"Seul les chiffres, - ou , sont acceptés");
                e.Handled = true;
            }
            else if (e.KeyChar == ',')
            {
                if(txtCelsius.Text.Contains(',') != false)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar == '.')
            {
                if (txtCelsius.Text.Contains(',') != false)
                {
                    e.Handled = true;
                }
                e.KeyChar = ',';
            }
            else if (e.KeyChar == '-')
            {
                if (txtCelsius.SelectionStart != 0 || txtCelsius.Text.Length !=0 && txtCelsius.Text.Contains('-'))
                {
                    e.Handled = true;
                }
            }


            if (e.KeyChar == (char)Keys.Enter && txtCelsius.Text != string.Empty)
            {

                double cel = double.Parse(txtCelsius.Text);

                double f = 32 + (9.0 / 5.0) * cel;

                txtFahrenheit.Text = Math.Round(f, 2).ToString();

                rdbCversF.Checked = true;
            }
        }

        private void labelCelsius_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void btnRAZ_Click(object sender, EventArgs e)
        {
            txtCelsius.Text = string.Empty;
            txtFahrenheit.Text = string.Empty;
            rdbCversF.Checked = false;
            rdbFversC.Checked = false;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double cel = double.Parse(txtCelsius.Text);

            double f = 32 + (9.0 / 5.0) * cel;

            txtFahrenheit.Text = Math.Round(f, 2).ToString();
        }

        private void grpSens_Enter(object sender, EventArgs e)
        {

        }

        private void rdbCversF_CheckedChanged(object sender, EventArgs e)
        {
            EP1.SetError(rdbCversF, string.Empty);
            if (rdbCversF.Checked)
            {
                if (txtCelsius.Text != string.Empty)
                {
                    double cel = double.Parse(txtCelsius.Text);

                    double f = 32 + (9.0 / 5.0) * cel;

                    txtFahrenheit.Text = Math.Round(f, 2).ToString();
                }

                else
                {
                    EP1.SetError(rdbCversF, "Tu veux convertir du vide?");
                }
            }
        }

        private void rdbFversC_CheckedChanged(object sender, EventArgs e)
        {
            EP1.SetError(rdbFversC, string.Empty);
            if (rdbFversC.Checked)
            {
                if (txtFahrenheit.Text != string.Empty)
                {
                    double fah = double.Parse(txtFahrenheit.Text);

                    double c = ((fah - 32) * (5.0 / 9.0));

                    txtCelsius.Text = Math.Round(c, 2).ToString();
                }

                else
                {
                    EP1.SetError(rdbFversC, "Tu veux convertir du vide?");
                }
            }
        }

        private void txtCelsius_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtFahrenheit_KeyPress(object sender, KeyPressEventArgs e)
        {
            EP1.SetError(txtFahrenheit, string.Empty);
            txtFahrenheit.ShortcutsEnabled = true;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Enter && e.KeyChar != (char)Keys.Back && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                EP1.SetError(txtFahrenheit, "On peut pas j'ai dit");
                e.Handled = true;
            }
            else if (e.KeyChar == ',')
            {
                if (txtFahrenheit.Text.Contains(',') != false)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar == '.')
            {
                if (txtFahrenheit.Text.Contains(',') != false)
                {
                    e.Handled = true;
                }
                e.KeyChar = ',';
            }
            else if (e.KeyChar == '-')
            {
                if (txtFahrenheit.SelectionStart != 0 || txtFahrenheit.Text.Length != 0 && txtFahrenheit.Text.Contains('-'))
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == (char)Keys.Enter && txtFahrenheit.Text != string.Empty)
            {
                double fah = double.Parse(txtFahrenheit.Text);

                double c = (((fah - 32) * (5.0 / 9.0)) + 273);

                txtCelsius.Text = Math.Round(c, 2).ToString();

                rdbFversC.Checked = true;

            }
            
        }

        private void txtFahrenheit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
