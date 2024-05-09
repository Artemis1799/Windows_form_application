namespace Trombinoscope
{
    partial class frmRecap
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
            this.lblRecap = new System.Windows.Forms.Label();
            this.ckbAbsence = new System.Windows.Forms.CheckBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.pcbEtudiant = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEtudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecap
            // 
            this.lblRecap.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.lblRecap.Location = new System.Drawing.Point(315, 26);
            this.lblRecap.Name = "lblRecap";
            this.lblRecap.Size = new System.Drawing.Size(459, 49);
            this.lblRecap.TabIndex = 0;
            this.lblRecap.Text = "Recap de";
            // 
            // ckbAbsence
            // 
            this.ckbAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.ckbAbsence.Location = new System.Drawing.Point(234, 443);
            this.ckbAbsence.Name = "ckbAbsence";
            this.ckbAbsence.Size = new System.Drawing.Size(225, 52);
            this.ckbAbsence.TabIndex = 2;
            this.ckbAbsence.Text = "Absences justifiées";
            this.ckbAbsence.UseVisualStyleBackColor = true;
            this.ckbAbsence.CheckedChanged += new System.EventHandler(this.ckbAbsence_CheckedChanged);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.btnAnnuler.Location = new System.Drawing.Point(751, 443);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(120, 43);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.btnValider.Location = new System.Drawing.Point(888, 443);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(120, 43);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // pcbEtudiant
            // 
            this.pcbEtudiant.Location = new System.Drawing.Point(361, 120);
            this.pcbEtudiant.Name = "pcbEtudiant";
            this.pcbEtudiant.Size = new System.Drawing.Size(231, 290);
            this.pcbEtudiant.TabIndex = 5;
            this.pcbEtudiant.TabStop = false;
            // 
            // frmRecap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 560);
            this.Controls.Add(this.pcbEtudiant);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.ckbAbsence);
            this.Controls.Add(this.lblRecap);
            this.Name = "frmRecap";
            this.Text = "Recap";
            ((System.ComponentModel.ISupportInitialize)(this.pcbEtudiant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRecap;
        private System.Windows.Forms.CheckBox ckbAbsence;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.PictureBox pcbEtudiant;
    }
}