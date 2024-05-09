namespace Trombinoscope
{
    partial class frmMain
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
            this.lblChoix = new System.Windows.Forms.Label();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnSuite = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.rdbListe = new System.Windows.Forms.RadioButton();
            this.rdbTrombino = new System.Windows.Forms.RadioButton();
            this.grpEtudiant = new System.Windows.Forms.GroupBox();
            this.chkAucunTout = new System.Windows.Forms.CheckBox();
            this.cboChoix = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblChoix
            // 
            this.lblChoix.AutoSize = true;
            this.lblChoix.Location = new System.Drawing.Point(49, 24);
            this.lblChoix.Name = "lblChoix";
            this.lblChoix.Size = new System.Drawing.Size(139, 16);
            this.lblChoix.TabIndex = 0;
            this.lblChoix.Text = "Choix de la promotion:";
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(929, 42);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(171, 29);
            this.btnRechercher.TabIndex = 1;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnSuite
            // 
            this.btnSuite.Location = new System.Drawing.Point(929, 92);
            this.btnSuite.Name = "btnSuite";
            this.btnSuite.Size = new System.Drawing.Size(171, 29);
            this.btnSuite.TabIndex = 2;
            this.btnSuite.Text = "Suite";
            this.btnSuite.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(55, 138);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(114, 16);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type d\'affichage :";
            // 
            // rdbListe
            // 
            this.rdbListe.AutoSize = true;
            this.rdbListe.Location = new System.Drawing.Point(235, 138);
            this.rdbListe.Name = "rdbListe";
            this.rdbListe.Size = new System.Drawing.Size(56, 20);
            this.rdbListe.TabIndex = 4;
            this.rdbListe.TabStop = true;
            this.rdbListe.Text = "Liste";
            this.rdbListe.UseVisualStyleBackColor = true;
            this.rdbListe.CheckedChanged += new System.EventHandler(this.rdbListe_CheckedChanged);
            // 
            // rdbTrombino
            // 
            this.rdbTrombino.AutoSize = true;
            this.rdbTrombino.Location = new System.Drawing.Point(382, 138);
            this.rdbTrombino.Name = "rdbTrombino";
            this.rdbTrombino.Size = new System.Drawing.Size(86, 20);
            this.rdbTrombino.TabIndex = 5;
            this.rdbTrombino.TabStop = true;
            this.rdbTrombino.Text = "Trombino";
            this.rdbTrombino.UseVisualStyleBackColor = true;
            this.rdbTrombino.CheckedChanged += new System.EventHandler(this.rdbTrombino_CheckedChanged);
            // 
            // grpEtudiant
            // 
            this.grpEtudiant.AutoSize = true;
            this.grpEtudiant.Location = new System.Drawing.Point(57, 237);
            this.grpEtudiant.Name = "grpEtudiant";
            this.grpEtudiant.Size = new System.Drawing.Size(1050, 300);
            this.grpEtudiant.TabIndex = 6;
            this.grpEtudiant.TabStop = false;
            this.grpEtudiant.Text = "Etudiants inscrits";
            // 
            // chkAucunTout
            // 
            this.chkAucunTout.AutoSize = true;
            this.chkAucunTout.Location = new System.Drawing.Point(931, 148);
            this.chkAucunTout.Name = "chkAucunTout";
            this.chkAucunTout.Size = new System.Drawing.Size(97, 20);
            this.chkAucunTout.TabIndex = 7;
            this.chkAucunTout.Text = "Aucun/Tout";
            this.chkAucunTout.UseVisualStyleBackColor = true;
            this.chkAucunTout.CheckedChanged += new System.EventHandler(this.chkAucunTout_CheckedChanged);
            // 
            // cboChoix
            // 
            this.cboChoix.FormattingEnabled = true;
            this.cboChoix.Location = new System.Drawing.Point(249, 25);
            this.cboChoix.Name = "cboChoix";
            this.cboChoix.Size = new System.Drawing.Size(368, 24);
            this.cboChoix.TabIndex = 8;
            this.cboChoix.Text = "Choisir une promotion dans la liste";
            this.cboChoix.SelectedIndexChanged += new System.EventHandler(this.cboChoix_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 651);
            this.Controls.Add(this.cboChoix);
            this.Controls.Add(this.chkAucunTout);
            this.Controls.Add(this.grpEtudiant);
            this.Controls.Add(this.rdbTrombino);
            this.Controls.Add(this.rdbListe);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnSuite);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.lblChoix);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suivi des étudiants";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoix;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnSuite;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.RadioButton rdbListe;
        private System.Windows.Forms.RadioButton rdbTrombino;
        private System.Windows.Forms.GroupBox grpEtudiant;
        private System.Windows.Forms.CheckBox chkAucunTout;
        private System.Windows.Forms.ComboBox cboChoix;
    }
}

