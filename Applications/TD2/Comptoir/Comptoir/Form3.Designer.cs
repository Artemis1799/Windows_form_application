namespace Comptoir
{
    partial class Frm3
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
            lblNumCommande = new Label();
            txtNumCommande = new TextBox();
            lblClientConcerne = new Label();
            lblEmployeResponsable = new Label();
            lblDateCommande = new Label();
            lblDestinataire = new Label();
            cboClient = new ComboBox();
            cboEmploye = new ComboBox();
            mthCalendar = new MonthCalendar();
            txtDestinataire = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // lblNumCommande
            // 
            lblNumCommande.Location = new Point(39, 24);
            lblNumCommande.Name = "lblNumCommande";
            lblNumCommande.Size = new Size(303, 23);
            lblNumCommande.TabIndex = 0;
            lblNumCommande.Text = "Numero de commande :";
            // 
            // txtNumCommande
            // 
            txtNumCommande.Location = new Point(362, 23);
            txtNumCommande.Name = "txtNumCommande";
            txtNumCommande.Size = new Size(213, 27);
            txtNumCommande.TabIndex = 1;
            // 
            // lblClientConcerne
            // 
            lblClientConcerne.Location = new Point(39, 70);
            lblClientConcerne.Name = "lblClientConcerne";
            lblClientConcerne.Size = new Size(170, 22);
            lblClientConcerne.TabIndex = 2;
            lblClientConcerne.Text = "Client concerné :";
            // 
            // lblEmployeResponsable
            // 
            lblEmployeResponsable.Location = new Point(39, 113);
            lblEmployeResponsable.Name = "lblEmployeResponsable";
            lblEmployeResponsable.Size = new Size(165, 24);
            lblEmployeResponsable.TabIndex = 3;
            lblEmployeResponsable.Text = "Employé responsable :";
            // 
            // lblDateCommande
            // 
            lblDateCommande.Location = new Point(39, 170);
            lblDateCommande.Name = "lblDateCommande";
            lblDateCommande.Size = new Size(205, 32);
            lblDateCommande.TabIndex = 4;
            lblDateCommande.Text = "Date commande :";
            // 
            // lblDestinataire
            // 
            lblDestinataire.Location = new Point(39, 428);
            lblDestinataire.Name = "lblDestinataire";
            lblDestinataire.Size = new Size(178, 29);
            lblDestinataire.TabIndex = 5;
            lblDestinataire.Text = "Destinataire :";
            // 
            // cboClient
            // 
            cboClient.FormattingEnabled = true;
            cboClient.Location = new Point(362, 64);
            cboClient.Name = "cboClient";
            cboClient.Size = new Size(213, 28);
            cboClient.TabIndex = 6;
            // 
            // cboEmploye
            // 
            cboEmploye.FormattingEnabled = true;
            cboEmploye.Location = new Point(362, 113);
            cboEmploye.Name = "cboEmploye";
            cboEmploye.Size = new Size(213, 28);
            cboEmploye.TabIndex = 7;
            // 
            // mthCalendar
            // 
            mthCalendar.Location = new Point(339, 170);
            mthCalendar.Name = "mthCalendar";
            mthCalendar.TabIndex = 8;
            // 
            // txtDestinataire
            // 
            txtDestinataire.Location = new Point(362, 425);
            txtDestinataire.Name = "txtDestinataire";
            txtDestinataire.Size = new Size(213, 27);
            txtDestinataire.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(658, 446);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 27);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Ajouter";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Frm3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 505);
            Controls.Add(btnAdd);
            Controls.Add(txtDestinataire);
            Controls.Add(mthCalendar);
            Controls.Add(cboEmploye);
            Controls.Add(cboClient);
            Controls.Add(lblDestinataire);
            Controls.Add(lblDateCommande);
            Controls.Add(lblEmployeResponsable);
            Controls.Add(lblClientConcerne);
            Controls.Add(txtNumCommande);
            Controls.Add(lblNumCommande);
            Name = "Frm3";
            Text = "Form3";
            Load += Frm3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumCommande;
        private TextBox txtNumCommande;
        private Label lblClientConcerne;
        private Label lblEmployeResponsable;
        private Label lblDateCommande;
        private Label lblDestinataire;
        private ComboBox cboClient;
        private ComboBox cboEmploye;
        private MonthCalendar mthCalendar;
        private TextBox txtDestinataire;
        private Button btnAdd;
    }
}