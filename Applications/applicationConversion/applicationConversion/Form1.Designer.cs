namespace applicationConversion
{
    partial class FrmConversion
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
            this.labelCelsius = new System.Windows.Forms.Label();
            this.labelFahrenheit = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnRAZ = new System.Windows.Forms.Button();
            this.grpSens = new System.Windows.Forms.GroupBox();
            this.rdbFversC = new System.Windows.Forms.RadioButton();
            this.rdbCversF = new System.Windows.Forms.RadioButton();
            this.EP1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpSens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EP1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCelsius
            // 
            this.labelCelsius.AutoSize = true;
            this.labelCelsius.Location = new System.Drawing.Point(74, 73);
            this.labelCelsius.Name = "labelCelsius";
            this.labelCelsius.Size = new System.Drawing.Size(163, 22);
            this.labelCelsius.TabIndex = 0;
            this.labelCelsius.Text = "Température en Celsius";
            this.labelCelsius.Click += new System.EventHandler(this.labelCelsius_Click);
            // 
            // labelFahrenheit
            // 
            this.labelFahrenheit.AutoSize = true;
            this.labelFahrenheit.Location = new System.Drawing.Point(74, 174);
            this.labelFahrenheit.Name = "labelFahrenheit";
            this.labelFahrenheit.Size = new System.Drawing.Size(185, 22);
            this.labelFahrenheit.TabIndex = 1;
            this.labelFahrenheit.Text = "Température en Fahrenheit";
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(285, 67);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.ShortcutsEnabled = false;
            this.txtCelsius.Size = new System.Drawing.Size(128, 27);
            this.txtCelsius.TabIndex = 2;
            this.txtCelsius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelsius_KeyPress);
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(285, 174);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(128, 27);
            this.txtFahrenheit.TabIndex = 3;
            this.txtFahrenheit.TextChanged += new System.EventHandler(this.txtFahrenheit_TextChanged);
            this.txtFahrenheit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFahrenheit_KeyPress);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(686, 428);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(194, 66);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnRAZ
            // 
            this.btnRAZ.Location = new System.Drawing.Point(486, 428);
            this.btnRAZ.Name = "btnRAZ";
            this.btnRAZ.Size = new System.Drawing.Size(194, 66);
            this.btnRAZ.TabIndex = 5;
            this.btnRAZ.Text = "RAZ";
            this.btnRAZ.UseVisualStyleBackColor = true;
            this.btnRAZ.Click += new System.EventHandler(this.btnRAZ_Click);
            // 
            // grpSens
            // 
            this.grpSens.Controls.Add(this.rdbFversC);
            this.grpSens.Controls.Add(this.rdbCversF);
            this.grpSens.Location = new System.Drawing.Point(78, 270);
            this.grpSens.Name = "grpSens";
            this.grpSens.Size = new System.Drawing.Size(415, 100);
            this.grpSens.TabIndex = 7;
            this.grpSens.TabStop = false;
            this.grpSens.Text = "Choix du sens de conversion";
            this.grpSens.Enter += new System.EventHandler(this.grpSens_Enter);
            // 
            // rdbFversC
            // 
            this.rdbFversC.AutoSize = true;
            this.rdbFversC.Location = new System.Drawing.Point(49, 56);
            this.rdbFversC.Name = "rdbFversC";
            this.rdbFversC.Size = new System.Drawing.Size(242, 26);
            this.rdbFversC.TabIndex = 1;
            this.rdbFversC.TabStop = true;
            this.rdbFversC.Text = "Conversion Fahrenheit -> Celsius";
            this.rdbFversC.UseVisualStyleBackColor = true;
            this.rdbFversC.CheckedChanged += new System.EventHandler(this.rdbFversC_CheckedChanged);
            // 
            // rdbCversF
            // 
            this.rdbCversF.AutoSize = true;
            this.rdbCversF.Location = new System.Drawing.Point(49, 29);
            this.rdbCversF.Name = "rdbCversF";
            this.rdbCversF.Size = new System.Drawing.Size(242, 26);
            this.rdbCversF.TabIndex = 0;
            this.rdbCversF.TabStop = true;
            this.rdbCversF.Text = "Conversion Celsius -> Fahrenheit";
            this.rdbCversF.UseVisualStyleBackColor = true;
            this.rdbCversF.CheckedChanged += new System.EventHandler(this.rdbCversF_CheckedChanged);
            // 
            // EP1
            // 
            this.EP1.ContainerControl = this;
            // 
            // FrmConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 540);
            this.Controls.Add(this.grpSens);
            this.Controls.Add(this.btnRAZ);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.labelFahrenheit);
            this.Controls.Add(this.labelCelsius);
            this.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmConversion";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversion Celsius Fahrenheit";
            this.Activated += new System.EventHandler(this.FrmConversion_Activated);
            this.Load += new System.EventHandler(this.FrmConversion_Load);
            this.grpSens.ResumeLayout(false);
            this.grpSens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCelsius;
        private System.Windows.Forms.Label labelFahrenheit;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnRAZ;
        private System.Windows.Forms.GroupBox grpSens;
        private System.Windows.Forms.RadioButton rdbFversC;
        private System.Windows.Forms.RadioButton rdbCversF;
        private System.Windows.Forms.ErrorProvider EP1;
    }
}

