namespace Traducteur
{
    partial class frmTraducteur
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboVerbes = new System.Windows.Forms.ComboBox();
            this.rdbAnglais = new System.Windows.Forms.RadioButton();
            this.rdbAllemand = new System.Windows.Forms.RadioButton();
            this.rdbEspagnol = new System.Windows.Forms.RadioButton();
            this.rdbItalien = new System.Windows.Forms.RadioButton();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.lblResultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboVerbes
            // 
            this.cboVerbes.FormattingEnabled = true;
            this.cboVerbes.Location = new System.Drawing.Point(206, 28);
            this.cboVerbes.Name = "cboVerbes";
            this.cboVerbes.Size = new System.Drawing.Size(306, 24);
            this.cboVerbes.TabIndex = 0;
            // 
            // rdbAnglais
            // 
            this.rdbAnglais.AutoSize = true;
            this.rdbAnglais.Location = new System.Drawing.Point(70, 116);
            this.rdbAnglais.Name = "rdbAnglais";
            this.rdbAnglais.Size = new System.Drawing.Size(73, 20);
            this.rdbAnglais.TabIndex = 1;
            this.rdbAnglais.TabStop = true;
            this.rdbAnglais.Tag = "1";
            this.rdbAnglais.Text = "Anglais";
            this.rdbAnglais.UseVisualStyleBackColor = true;
            this.rdbAnglais.CheckedChanged += new System.EventHandler(this.rdbAnglais_CheckedChanged);
            this.rdbAnglais.Click += new System.EventHandler(this.rdbAnglais_Click);
            // 
            // rdbAllemand
            // 
            this.rdbAllemand.AutoSize = true;
            this.rdbAllemand.Location = new System.Drawing.Point(70, 155);
            this.rdbAllemand.Name = "rdbAllemand";
            this.rdbAllemand.Size = new System.Drawing.Size(85, 20);
            this.rdbAllemand.TabIndex = 2;
            this.rdbAllemand.TabStop = true;
            this.rdbAllemand.Tag = "2";
            this.rdbAllemand.Text = "Allemand";
            this.rdbAllemand.UseVisualStyleBackColor = true;
            this.rdbAllemand.Click += new System.EventHandler(this.rdbAnglais_Click);
            // 
            // rdbEspagnol
            // 
            this.rdbEspagnol.AutoSize = true;
            this.rdbEspagnol.Location = new System.Drawing.Point(70, 197);
            this.rdbEspagnol.Name = "rdbEspagnol";
            this.rdbEspagnol.Size = new System.Drawing.Size(86, 20);
            this.rdbEspagnol.TabIndex = 3;
            this.rdbEspagnol.TabStop = true;
            this.rdbEspagnol.Tag = "3";
            this.rdbEspagnol.Text = "Espagnol";
            this.rdbEspagnol.UseVisualStyleBackColor = true;
            this.rdbEspagnol.Click += new System.EventHandler(this.rdbAnglais_Click);
            // 
            // rdbItalien
            // 
            this.rdbItalien.AutoSize = true;
            this.rdbItalien.Location = new System.Drawing.Point(70, 242);
            this.rdbItalien.Name = "rdbItalien";
            this.rdbItalien.Size = new System.Drawing.Size(63, 20);
            this.rdbItalien.TabIndex = 4;
            this.rdbItalien.TabStop = true;
            this.rdbItalien.Tag = "4";
            this.rdbItalien.Text = "Italien";
            this.rdbItalien.UseVisualStyleBackColor = true;
            this.rdbItalien.Click += new System.EventHandler(this.rdbAnglais_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(594, 28);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(168, 23);
            this.btnNouveau.TabIndex = 5;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.Location = new System.Drawing.Point(101, 348);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(429, 33);
            this.lblResultat.TabIndex = 6;
            // 
            // frmTraducteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.rdbItalien);
            this.Controls.Add(this.rdbEspagnol);
            this.Controls.Add(this.rdbAllemand);
            this.Controls.Add(this.rdbAnglais);
            this.Controls.Add(this.cboVerbes);
            this.Name = "frmTraducteur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traducteur";
            this.Load += new System.EventHandler(this.frmTraducteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboVerbes;
        private System.Windows.Forms.RadioButton rdbAnglais;
        private System.Windows.Forms.RadioButton rdbAllemand;
        private System.Windows.Forms.RadioButton rdbEspagnol;
        private System.Windows.Forms.RadioButton rdbItalien;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Label lblResultat;
    }
}

