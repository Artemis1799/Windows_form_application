namespace QuizzGeographique
{
    partial class frmQuizz
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
            this.lblPays = new System.Windows.Forms.Label();
            this.txtPays = new System.Windows.Forms.TextBox();
            this.btnInformation = new System.Windows.Forms.Button();
            this.rdbCap1 = new System.Windows.Forms.RadioButton();
            this.rdbCap4 = new System.Windows.Forms.RadioButton();
            this.rdbCap3 = new System.Windows.Forms.RadioButton();
            this.rdbCap2 = new System.Windows.Forms.RadioButton();
            this.lblCorrection = new System.Windows.Forms.Label();
            this.lblPourcentage = new System.Windows.Forms.Label();
            this.txtCorrection = new System.Windows.Forms.TextBox();
            this.txtPourcentage = new System.Windows.Forms.TextBox();
            this.btnAutreQst = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.grpCap = new System.Windows.Forms.GroupBox();
            this.grpCap.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.Location = new System.Drawing.Point(47, 27);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(41, 16);
            this.lblPays.TabIndex = 0;
            this.lblPays.Text = "Pays:";
            // 
            // txtPays
            // 
            this.txtPays.Location = new System.Drawing.Point(123, 26);
            this.txtPays.Name = "txtPays";
            this.txtPays.Size = new System.Drawing.Size(228, 22);
            this.txtPays.TabIndex = 1;
            this.txtPays.TextChanged += new System.EventHandler(this.txtPays_TextChanged);
            this.txtPays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPays_KeyPress);
            // 
            // btnInformation
            // 
            this.btnInformation.Location = new System.Drawing.Point(662, 37);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(205, 39);
            this.btnInformation.TabIndex = 2;
            this.btnInformation.Text = "Information";
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // rdbCap1
            // 
            this.rdbCap1.AutoSize = true;
            this.rdbCap1.Location = new System.Drawing.Point(13, 43);
            this.rdbCap1.Name = "rdbCap1";
            this.rdbCap1.Size = new System.Drawing.Size(103, 20);
            this.rdbCap1.TabIndex = 4;
            this.rdbCap1.Text = "radioButton1";
            this.rdbCap1.UseVisualStyleBackColor = true;
            this.rdbCap1.CheckedChanged += new System.EventHandler(this.rdbCap1_CheckedChanged);
            this.rdbCap1.Click += new System.EventHandler(this.rdbCap1_Click);
            // 
            // rdbCap4
            // 
            this.rdbCap4.AutoSize = true;
            this.rdbCap4.Location = new System.Drawing.Point(13, 121);
            this.rdbCap4.Name = "rdbCap4";
            this.rdbCap4.Size = new System.Drawing.Size(103, 20);
            this.rdbCap4.TabIndex = 5;
            this.rdbCap4.Text = "radioButton1";
            this.rdbCap4.UseVisualStyleBackColor = true;
            this.rdbCap4.Click += new System.EventHandler(this.rdbCap1_Click);
            // 
            // rdbCap3
            // 
            this.rdbCap3.AutoSize = true;
            this.rdbCap3.Location = new System.Drawing.Point(13, 95);
            this.rdbCap3.Name = "rdbCap3";
            this.rdbCap3.Size = new System.Drawing.Size(103, 20);
            this.rdbCap3.TabIndex = 6;
            this.rdbCap3.Text = "radioButton1";
            this.rdbCap3.UseVisualStyleBackColor = true;
            this.rdbCap3.Click += new System.EventHandler(this.rdbCap1_Click);
            // 
            // rdbCap2
            // 
            this.rdbCap2.AutoSize = true;
            this.rdbCap2.Location = new System.Drawing.Point(13, 69);
            this.rdbCap2.Name = "rdbCap2";
            this.rdbCap2.Size = new System.Drawing.Size(103, 20);
            this.rdbCap2.TabIndex = 7;
            this.rdbCap2.Text = "radioButton1";
            this.rdbCap2.UseVisualStyleBackColor = true;
            this.rdbCap2.Click += new System.EventHandler(this.rdbCap1_Click);
            // 
            // lblCorrection
            // 
            this.lblCorrection.AutoSize = true;
            this.lblCorrection.Location = new System.Drawing.Point(43, 384);
            this.lblCorrection.Name = "lblCorrection";
            this.lblCorrection.Size = new System.Drawing.Size(149, 16);
            this.lblCorrection.TabIndex = 8;
            this.lblCorrection.Text = "La capitale correcte est:";
            // 
            // lblPourcentage
            // 
            this.lblPourcentage.AutoSize = true;
            this.lblPourcentage.Location = new System.Drawing.Point(43, 423);
            this.lblPourcentage.Name = "lblPourcentage";
            this.lblPourcentage.Size = new System.Drawing.Size(214, 16);
            this.lblPourcentage.TabIndex = 9;
            this.lblPourcentage.Text = "Pourcentage de bonnes réponses:";
            // 
            // txtCorrection
            // 
            this.txtCorrection.Location = new System.Drawing.Point(352, 381);
            this.txtCorrection.Name = "txtCorrection";
            this.txtCorrection.Size = new System.Drawing.Size(198, 22);
            this.txtCorrection.TabIndex = 10;
            this.txtCorrection.TextChanged += new System.EventHandler(this.txtPays_TextChanged);
            this.txtCorrection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPays_KeyPress);
            // 
            // txtPourcentage
            // 
            this.txtPourcentage.Location = new System.Drawing.Point(350, 430);
            this.txtPourcentage.Name = "txtPourcentage";
            this.txtPourcentage.Size = new System.Drawing.Size(218, 22);
            this.txtPourcentage.TabIndex = 11;
            this.txtPourcentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPays_KeyPress);
            // 
            // btnAutreQst
            // 
            this.btnAutreQst.Location = new System.Drawing.Point(415, 503);
            this.btnAutreQst.Name = "btnAutreQst";
            this.btnAutreQst.Size = new System.Drawing.Size(152, 24);
            this.btnAutreQst.TabIndex = 12;
            this.btnAutreQst.Text = "Autre question";
            this.btnAutreQst.UseVisualStyleBackColor = true;
            this.btnAutreQst.Click += new System.EventHandler(this.btnAutreQst_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(619, 503);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(152, 24);
            this.btnQuitter.TabIndex = 13;
            this.btnQuitter.Text = "Fin du jeu";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(392, 197);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(205, 49);
            this.btnValider.TabIndex = 14;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // grpCap
            // 
            this.grpCap.Controls.Add(this.rdbCap2);
            this.grpCap.Controls.Add(this.rdbCap3);
            this.grpCap.Controls.Add(this.rdbCap4);
            this.grpCap.Controls.Add(this.rdbCap1);
            this.grpCap.Location = new System.Drawing.Point(29, 156);
            this.grpCap.Name = "grpCap";
            this.grpCap.Size = new System.Drawing.Size(258, 159);
            this.grpCap.TabIndex = 15;
            this.grpCap.TabStop = false;
            this.grpCap.Text = "Les capitales:";
            // 
            // frmQuizz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(893, 553);
            this.Controls.Add(this.grpCap);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnAutreQst);
            this.Controls.Add(this.txtPourcentage);
            this.Controls.Add(this.txtCorrection);
            this.Controls.Add(this.lblPourcentage);
            this.Controls.Add(this.lblCorrection);
            this.Controls.Add(this.btnInformation);
            this.Controls.Add(this.txtPays);
            this.Controls.Add(this.lblPays);
            this.Name = "frmQuizz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quizz Géographique";
            this.Load += new System.EventHandler(this.frmQuizz_Load);
            this.grpCap.ResumeLayout(false);
            this.grpCap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.TextBox txtPays;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.RadioButton rdbCap1;
        private System.Windows.Forms.RadioButton rdbCap4;
        private System.Windows.Forms.RadioButton rdbCap3;
        private System.Windows.Forms.RadioButton rdbCap2;
        private System.Windows.Forms.Label lblCorrection;
        private System.Windows.Forms.Label lblPourcentage;
        private System.Windows.Forms.TextBox txtCorrection;
        private System.Windows.Forms.TextBox txtPourcentage;
        private System.Windows.Forms.Button btnAutreQst;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.GroupBox grpCap;
    }
}

