namespace cotisation
{
    partial class frmCotisation
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
            this.labelNbEnfant = new System.Windows.Forms.Label();
            this.labelMembreBureau = new System.Windows.Forms.Label();
            this.labelActivité = new System.Windows.Forms.Label();
            this.txtEnfant = new System.Windows.Forms.TextBox();
            this.cbBureau = new System.Windows.Forms.CheckBox();
            this.cbActivite = new System.Windows.Forms.CheckBox();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.btnQuitte = new System.Windows.Forms.Button();
            this.labelPrixBase = new System.Windows.Forms.Label();
            this.labelPrixCalcul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNbEnfant
            // 
            this.labelNbEnfant.AutoSize = true;
            this.labelNbEnfant.Location = new System.Drawing.Point(78, 120);
            this.labelNbEnfant.Name = "labelNbEnfant";
            this.labelNbEnfant.Size = new System.Drawing.Size(219, 16);
            this.labelNbEnfant.TabIndex = 0;
            this.labelNbEnfant.Text = "Entrez le nombre d\'enfant à charge :";
            // 
            // labelMembreBureau
            // 
            this.labelMembreBureau.AutoSize = true;
            this.labelMembreBureau.Location = new System.Drawing.Point(78, 213);
            this.labelMembreBureau.Name = "labelMembreBureau";
            this.labelMembreBureau.Size = new System.Drawing.Size(182, 16);
            this.labelMembreBureau.TabIndex = 1;
            this.labelMembreBureau.Text = "Vous etez membre du bureau";
            // 
            // labelActivité
            // 
            this.labelActivité.AutoSize = true;
            this.labelActivité.Location = new System.Drawing.Point(78, 238);
            this.labelActivité.Name = "labelActivité";
            this.labelActivité.Size = new System.Drawing.Size(154, 16);
            this.labelActivité.TabIndex = 2;
            this.labelActivité.Text = "Vous animez une activité";
            // 
            // txtEnfant
            // 
            this.txtEnfant.Location = new System.Drawing.Point(328, 117);
            this.txtEnfant.Name = "txtEnfant";
            this.txtEnfant.Size = new System.Drawing.Size(108, 22);
            this.txtEnfant.TabIndex = 3;
            this.txtEnfant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // cbBureau
            // 
            this.cbBureau.AutoSize = true;
            this.cbBureau.Location = new System.Drawing.Point(303, 209);
            this.cbBureau.Name = "cbBureau";
            this.cbBureau.Size = new System.Drawing.Size(18, 17);
            this.cbBureau.TabIndex = 4;
            this.cbBureau.UseVisualStyleBackColor = true;
            this.cbBureau.CheckedChanged += new System.EventHandler(this.cbBureau_CheckedChanged);
            // 
            // cbActivite
            // 
            this.cbActivite.AutoSize = true;
            this.cbActivite.Location = new System.Drawing.Point(303, 238);
            this.cbActivite.Name = "cbActivite";
            this.cbActivite.Size = new System.Drawing.Size(18, 17);
            this.cbActivite.TabIndex = 5;
            this.cbActivite.UseVisualStyleBackColor = true;
            this.cbActivite.CheckedChanged += new System.EventHandler(this.cbActivite_CheckedChanged);
            // 
            // btnCalcul
            // 
            this.btnCalcul.Location = new System.Drawing.Point(802, 413);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(156, 42);
            this.btnCalcul.TabIndex = 6;
            this.btnCalcul.Text = "Calculer";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // btnQuitte
            // 
            this.btnQuitte.Location = new System.Drawing.Point(802, 473);
            this.btnQuitte.Name = "btnQuitte";
            this.btnQuitte.Size = new System.Drawing.Size(155, 30);
            this.btnQuitte.TabIndex = 7;
            this.btnQuitte.Text = "Quitter";
            this.btnQuitte.UseVisualStyleBackColor = true;
            this.btnQuitte.Click += new System.EventHandler(this.btnQuitte_Click);
            // 
            // labelPrixBase
            // 
            this.labelPrixBase.AutoSize = true;
            this.labelPrixBase.Location = new System.Drawing.Point(248, 355);
            this.labelPrixBase.Name = "labelPrixBase";
            this.labelPrixBase.Size = new System.Drawing.Size(0, 16);
            this.labelPrixBase.TabIndex = 8;
            // 
            // labelPrixCalcul
            // 
            this.labelPrixCalcul.AutoSize = true;
            this.labelPrixCalcul.Location = new System.Drawing.Point(243, 397);
            this.labelPrixCalcul.Name = "labelPrixCalcul";
            this.labelPrixCalcul.Size = new System.Drawing.Size(0, 16);
            this.labelPrixCalcul.TabIndex = 9;
            // 
            // frmCotisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 524);
            this.Controls.Add(this.labelPrixCalcul);
            this.Controls.Add(this.labelPrixBase);
            this.Controls.Add(this.btnQuitte);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.cbActivite);
            this.Controls.Add(this.cbBureau);
            this.Controls.Add(this.txtEnfant);
            this.Controls.Add(this.labelActivité);
            this.Controls.Add(this.labelMembreBureau);
            this.Controls.Add(this.labelNbEnfant);
            this.Name = "frmCotisation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulaire d\'inscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNbEnfant;
        private System.Windows.Forms.Label labelMembreBureau;
        private System.Windows.Forms.Label labelActivité;
        private System.Windows.Forms.TextBox txtEnfant;
        private System.Windows.Forms.CheckBox cbBureau;
        private System.Windows.Forms.CheckBox cbActivite;
        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.Button btnQuitte;
        private System.Windows.Forms.Label labelPrixBase;
        private System.Windows.Forms.Label labelPrixCalcul;
    }
}

