namespace Pendu
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
            this.lblProposition = new System.Windows.Forms.Label();
            this.btnRecommencer = new System.Windows.Forms.Button();
            this.grpMot = new System.Windows.Forms.GroupBox();
            this.txtProposition = new System.Windows.Forms.TextBox();
            this.lblFautes = new System.Windows.Forms.Label();
            this.lblFautesNb = new System.Windows.Forms.Label();
            this.lblVictoire = new System.Windows.Forms.Label();
            this.lblDefaite = new System.Windows.Forms.Label();
            this.lblVictoireNb = new System.Windows.Forms.Label();
            this.lblDefaiteNb = new System.Windows.Forms.Label();
            this.grbPendu = new System.Windows.Forms.GroupBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProposition
            // 
            this.lblProposition.AutoSize = true;
            this.lblProposition.Location = new System.Drawing.Point(515, 29);
            this.lblProposition.Name = "lblProposition";
            this.lblProposition.Size = new System.Drawing.Size(112, 16);
            this.lblProposition.TabIndex = 1;
            this.lblProposition.Text = "Votre proposition:";
            // 
            // btnRecommencer
            // 
            this.btnRecommencer.Location = new System.Drawing.Point(761, 466);
            this.btnRecommencer.Name = "btnRecommencer";
            this.btnRecommencer.Size = new System.Drawing.Size(229, 28);
            this.btnRecommencer.TabIndex = 2;
            this.btnRecommencer.Text = "Recommencer";
            this.btnRecommencer.UseVisualStyleBackColor = true;
            this.btnRecommencer.Click += new System.EventHandler(this.btnRecommencer_Click);
            // 
            // grpMot
            // 
            this.grpMot.Location = new System.Drawing.Point(34, 95);
            this.grpMot.Name = "grpMot";
            this.grpMot.Size = new System.Drawing.Size(691, 149);
            this.grpMot.TabIndex = 3;
            this.grpMot.TabStop = false;
            this.grpMot.Text = "Mot à trouver";
            // 
            // txtProposition
            // 
            this.txtProposition.Location = new System.Drawing.Point(652, 26);
            this.txtProposition.Name = "txtProposition";
            this.txtProposition.Size = new System.Drawing.Size(91, 22);
            this.txtProposition.TabIndex = 4;
            this.txtProposition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProposition_KeyPress);
            // 
            // lblFautes
            // 
            this.lblFautes.AutoSize = true;
            this.lblFautes.Location = new System.Drawing.Point(31, 298);
            this.lblFautes.Name = "lblFautes";
            this.lblFautes.Size = new System.Drawing.Size(51, 16);
            this.lblFautes.TabIndex = 5;
            this.lblFautes.Text = "Fautes:";
            // 
            // lblFautesNb
            // 
            this.lblFautesNb.AutoSize = true;
            this.lblFautesNb.Location = new System.Drawing.Point(93, 298);
            this.lblFautesNb.Name = "lblFautesNb";
            this.lblFautesNb.Size = new System.Drawing.Size(32, 16);
            this.lblFautesNb.TabIndex = 6;
            this.lblFautesNb.Text = "0/11";
            // 
            // lblVictoire
            // 
            this.lblVictoire.AutoSize = true;
            this.lblVictoire.Location = new System.Drawing.Point(31, 359);
            this.lblVictoire.Name = "lblVictoire";
            this.lblVictoire.Size = new System.Drawing.Size(127, 16);
            this.lblVictoire.TabIndex = 7;
            this.lblVictoire.Text = "Nombre de victoire: ";
            // 
            // lblDefaite
            // 
            this.lblDefaite.AutoSize = true;
            this.lblDefaite.Location = new System.Drawing.Point(31, 385);
            this.lblDefaite.Name = "lblDefaite";
            this.lblDefaite.Size = new System.Drawing.Size(125, 16);
            this.lblDefaite.TabIndex = 8;
            this.lblDefaite.Text = "Nombre de défaite: ";
            // 
            // lblVictoireNb
            // 
            this.lblVictoireNb.AutoSize = true;
            this.lblVictoireNb.Location = new System.Drawing.Point(164, 359);
            this.lblVictoireNb.Name = "lblVictoireNb";
            this.lblVictoireNb.Size = new System.Drawing.Size(14, 16);
            this.lblVictoireNb.TabIndex = 9;
            this.lblVictoireNb.Text = "0";
            // 
            // lblDefaiteNb
            // 
            this.lblDefaiteNb.AutoSize = true;
            this.lblDefaiteNb.Location = new System.Drawing.Point(162, 385);
            this.lblDefaiteNb.Name = "lblDefaiteNb";
            this.lblDefaiteNb.Size = new System.Drawing.Size(14, 16);
            this.lblDefaiteNb.TabIndex = 10;
            this.lblDefaiteNb.Text = "0";
            // 
            // grbPendu
            // 
            this.grbPendu.Location = new System.Drawing.Point(252, 250);
            this.grbPendu.Name = "grbPendu";
            this.grbPendu.Size = new System.Drawing.Size(288, 388);
            this.grbPendu.TabIndex = 11;
            this.grbPendu.TabStop = false;
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(33, 426);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(0, 16);
            this.lblResultat.TabIndex = 12;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 647);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.grbPendu);
            this.Controls.Add(this.lblDefaiteNb);
            this.Controls.Add(this.lblVictoireNb);
            this.Controls.Add(this.lblDefaite);
            this.Controls.Add(this.lblVictoire);
            this.Controls.Add(this.lblFautesNb);
            this.Controls.Add(this.lblFautes);
            this.Controls.Add(this.txtProposition);
            this.Controls.Add(this.grpMot);
            this.Controls.Add(this.btnRecommencer);
            this.Controls.Add(this.lblProposition);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pendu";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProposition;
        private System.Windows.Forms.Button btnRecommencer;
        private System.Windows.Forms.GroupBox grpMot;
        private System.Windows.Forms.TextBox txtProposition;
        private System.Windows.Forms.Label lblFautes;
        private System.Windows.Forms.Label lblFautesNb;
        private System.Windows.Forms.Label lblVictoire;
        private System.Windows.Forms.Label lblDefaite;
        private System.Windows.Forms.Label lblVictoireNb;
        private System.Windows.Forms.Label lblDefaiteNb;
        private System.Windows.Forms.GroupBox grbPendu;
        private System.Windows.Forms.Label lblResultat;
    }
}

