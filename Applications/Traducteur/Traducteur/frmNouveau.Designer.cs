namespace Traducteur
{
    partial class frmNouveau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNouveau = new System.Windows.Forms.Label();
            this.txtNouveau = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNouveau
            // 
            this.lblNouveau.AutoSize = true;
            this.lblNouveau.Location = new System.Drawing.Point(27, 61);
            this.lblNouveau.Name = "lblNouveau";
            this.lblNouveau.Size = new System.Drawing.Size(100, 16);
            this.lblNouveau.TabIndex = 0;
            this.lblNouveau.Text = "Nouveau verbe";
            // 
            // txtNouveau
            // 
            this.txtNouveau.Location = new System.Drawing.Point(172, 58);
            this.txtNouveau.Name = "txtNouveau";
            this.txtNouveau.Size = new System.Drawing.Size(214, 22);
            this.txtNouveau.TabIndex = 1;
            this.txtNouveau.TextChanged += new System.EventHandler(this.txtNouveau_TextChanged);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(605, 228);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(128, 35);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(459, 228);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(128, 35);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmNouveau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(780, 294);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtNouveau);
            this.Controls.Add(this.lblNouveau);
            this.Name = "frmNouveau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajout d\'un nouveau verbe";
            this.Deactivate += new System.EventHandler(this.frmNouveau_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNouveau;
        private System.Windows.Forms.TextBox txtNouveau;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}