namespace appliTransfoListe
{
    partial class frmTranso
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
            this.components = new System.ComponentModel.Container();
            this.lstGauche = new System.Windows.Forms.ListBox();
            this.lstDroite = new System.Windows.Forms.ListBox();
            this.btnGaucheVersDroite = new System.Windows.Forms.Button();
            this.btnToutGaucheVersDroite = new System.Windows.Forms.Button();
            this.btnDroiteVersGauche = new System.Windows.Forms.Button();
            this.btnToutDroiteVersGauche = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.pnlNouveau = new System.Windows.Forms.Panel();
            this.txtNouveau = new System.Windows.Forms.TextBox();
            this.lblNouveau = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlNouveau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstGauche
            // 
            this.lstGauche.FormattingEnabled = true;
            this.lstGauche.ItemHeight = 16;
            this.lstGauche.Items.AddRange(new object[] {
            "Nom",
            "Prenom",
            "Adresse rue",
            "Adresse ville",
            "Code postal"});
            this.lstGauche.Location = new System.Drawing.Point(99, 58);
            this.lstGauche.Name = "lstGauche";
            this.lstGauche.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstGauche.Size = new System.Drawing.Size(229, 276);
            this.lstGauche.TabIndex = 0;
            // 
            // lstDroite
            // 
            this.lstDroite.FormattingEnabled = true;
            this.lstDroite.ItemHeight = 16;
            this.lstDroite.Location = new System.Drawing.Point(608, 66);
            this.lstDroite.Name = "lstDroite";
            this.lstDroite.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDroite.Size = new System.Drawing.Size(238, 260);
            this.lstDroite.TabIndex = 1;
            // 
            // btnGaucheVersDroite
            // 
            this.btnGaucheVersDroite.Location = new System.Drawing.Point(434, 96);
            this.btnGaucheVersDroite.Name = "btnGaucheVersDroite";
            this.btnGaucheVersDroite.Size = new System.Drawing.Size(68, 66);
            this.btnGaucheVersDroite.TabIndex = 2;
            this.btnGaucheVersDroite.Text = ">";
            this.btnGaucheVersDroite.UseVisualStyleBackColor = true;
            this.btnGaucheVersDroite.Click += new System.EventHandler(this.btnGaucheVersDroite_Click);
            // 
            // btnToutGaucheVersDroite
            // 
            this.btnToutGaucheVersDroite.Location = new System.Drawing.Point(434, 168);
            this.btnToutGaucheVersDroite.Name = "btnToutGaucheVersDroite";
            this.btnToutGaucheVersDroite.Size = new System.Drawing.Size(68, 66);
            this.btnToutGaucheVersDroite.TabIndex = 3;
            this.btnToutGaucheVersDroite.Text = ">>";
            this.btnToutGaucheVersDroite.UseVisualStyleBackColor = true;
            this.btnToutGaucheVersDroite.Click += new System.EventHandler(this.btnToutGaucheVersDroite_Click);
            // 
            // btnDroiteVersGauche
            // 
            this.btnDroiteVersGauche.Location = new System.Drawing.Point(434, 312);
            this.btnDroiteVersGauche.Name = "btnDroiteVersGauche";
            this.btnDroiteVersGauche.Size = new System.Drawing.Size(68, 66);
            this.btnDroiteVersGauche.TabIndex = 4;
            this.btnDroiteVersGauche.Text = "<";
            this.btnDroiteVersGauche.UseVisualStyleBackColor = true;
            // 
            // btnToutDroiteVersGauche
            // 
            this.btnToutDroiteVersGauche.Location = new System.Drawing.Point(434, 240);
            this.btnToutDroiteVersGauche.Name = "btnToutDroiteVersGauche";
            this.btnToutDroiteVersGauche.Size = new System.Drawing.Size(68, 66);
            this.btnToutDroiteVersGauche.TabIndex = 5;
            this.btnToutDroiteVersGauche.Text = "<<";
            this.btnToutDroiteVersGauche.UseVisualStyleBackColor = true;
            this.btnToutDroiteVersGauche.Click += new System.EventHandler(this.btnToutDroiteVersGauche_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(434, 24);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(68, 66);
            this.btnNouveau.TabIndex = 6;
            this.btnNouveau.Text = ":)";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // pnlNouveau
            // 
            this.pnlNouveau.Controls.Add(this.txtNouveau);
            this.pnlNouveau.Controls.Add(this.lblNouveau);
            this.pnlNouveau.Location = new System.Drawing.Point(103, 411);
            this.pnlNouveau.Name = "pnlNouveau";
            this.pnlNouveau.Size = new System.Drawing.Size(596, 112);
            this.pnlNouveau.TabIndex = 7;
            this.pnlNouveau.Visible = false;
            // 
            // txtNouveau
            // 
            this.txtNouveau.Location = new System.Drawing.Point(216, 29);
            this.txtNouveau.Name = "txtNouveau";
            this.txtNouveau.Size = new System.Drawing.Size(249, 22);
            this.txtNouveau.TabIndex = 1;
            this.txtNouveau.TextChanged += new System.EventHandler(this.txtNouveau_TextChanged);
            this.txtNouveau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNouveau_KeyPress);
            // 
            // lblNouveau
            // 
            this.lblNouveau.AutoSize = true;
            this.lblNouveau.Location = new System.Drawing.Point(31, 28);
            this.lblNouveau.Name = "lblNouveau";
            this.lblNouveau.Size = new System.Drawing.Size(167, 16);
            this.lblNouveau.TabIndex = 0;
            this.lblNouveau.Text = "Nouvel élément à rajouter?";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTranso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1021, 549);
            this.Controls.Add(this.pnlNouveau);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.btnToutDroiteVersGauche);
            this.Controls.Add(this.btnDroiteVersGauche);
            this.Controls.Add(this.btnToutGaucheVersDroite);
            this.Controls.Add(this.btnGaucheVersDroite);
            this.Controls.Add(this.lstDroite);
            this.Controls.Add(this.lstGauche);
            this.Name = "frmTranso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfère entre deux liste";
            this.pnlNouveau.ResumeLayout(false);
            this.pnlNouveau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstGauche;
        private System.Windows.Forms.ListBox lstDroite;
        private System.Windows.Forms.Button btnGaucheVersDroite;
        private System.Windows.Forms.Button btnToutGaucheVersDroite;
        private System.Windows.Forms.Button btnDroiteVersGauche;
        private System.Windows.Forms.Button btnToutDroiteVersGauche;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Panel pnlNouveau;
        private System.Windows.Forms.TextBox txtNouveau;
        private System.Windows.Forms.Label lblNouveau;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

