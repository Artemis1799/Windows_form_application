namespace sante
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpMain = new GroupBox();
            cboInf = new ComboBox();
            cboInfCentre = new ComboBox();
            cboCentre = new ComboBox();
            btnDeconnecte = new Button();
            btnConnecte = new Button();
            mthCal = new MonthCalendar();
            lblDate = new Label();
            rdbRechercheInfermiere = new RadioButton();
            rdbRechercheCentre = new RadioButton();
            dgv = new DataGridView();
            grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // grpMain
            // 
            grpMain.Controls.Add(cboInf);
            grpMain.Controls.Add(cboInfCentre);
            grpMain.Controls.Add(cboCentre);
            grpMain.Controls.Add(btnDeconnecte);
            grpMain.Controls.Add(btnConnecte);
            grpMain.Controls.Add(mthCal);
            grpMain.Controls.Add(lblDate);
            grpMain.Controls.Add(rdbRechercheInfermiere);
            grpMain.Controls.Add(rdbRechercheCentre);
            grpMain.Location = new Point(36, 34);
            grpMain.Name = "grpMain";
            grpMain.Size = new Size(886, 485);
            grpMain.TabIndex = 0;
            grpMain.TabStop = false;
            grpMain.Text = "Parametre de recherche";
            // 
            // cboInf
            // 
            cboInf.FormattingEnabled = true;
            cboInf.Location = new Point(313, 107);
            cboInf.Name = "cboInf";
            cboInf.Size = new Size(165, 28);
            cboInf.TabIndex = 8;
            cboInf.Visible = false;
            // 
            // cboInfCentre
            // 
            cboInfCentre.FormattingEnabled = true;
            cboInfCentre.Location = new Point(504, 45);
            cboInfCentre.Name = "cboInfCentre";
            cboInfCentre.Size = new Size(165, 28);
            cboInfCentre.TabIndex = 7;
            cboInfCentre.Visible = false;
            // 
            // cboCentre
            // 
            cboCentre.FormattingEnabled = true;
            cboCentre.Location = new Point(313, 45);
            cboCentre.Name = "cboCentre";
            cboCentre.Size = new Size(165, 28);
            cboCentre.TabIndex = 6;
            cboCentre.Visible = false;
            cboCentre.SelectedIndexChanged += cboCentre_SelectedIndexChanged;
            // 
            // btnDeconnecte
            // 
            btnDeconnecte.Location = new Point(579, 352);
            btnDeconnecte.Name = "btnDeconnecte";
            btnDeconnecte.Size = new Size(255, 79);
            btnDeconnecte.TabIndex = 5;
            btnDeconnecte.Text = "Recherche en mode déconnecté";
            btnDeconnecte.UseVisualStyleBackColor = true;
            // 
            // btnConnecte
            // 
            btnConnecte.Location = new Point(579, 250);
            btnConnecte.Name = "btnConnecte";
            btnConnecte.Size = new Size(255, 79);
            btnConnecte.TabIndex = 4;
            btnConnecte.Text = "Recherche en mode connecté";
            btnConnecte.UseVisualStyleBackColor = true;
            btnConnecte.Click += btnConnecte_Click;
            // 
            // mthCal
            // 
            mthCal.Location = new Point(110, 244);
            mthCal.MaxSelectionCount = 100;
            mthCal.Name = "mthCal";
            mthCal.TabIndex = 3;
            mthCal.DateSelected += mthCal_DateSelected;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(30, 237);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(52, 20);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date : ";
            // 
            // rdbRechercheInfermiere
            // 
            rdbRechercheInfermiere.AutoSize = true;
            rdbRechercheInfermiere.Location = new Point(22, 107);
            rdbRechercheInfermiere.Name = "rdbRechercheInfermiere";
            rdbRechercheInfermiere.Size = new Size(196, 24);
            rdbRechercheInfermiere.TabIndex = 1;
            rdbRechercheInfermiere.TabStop = true;
            rdbRechercheInfermiere.Text = "Recherche par infermiere";
            rdbRechercheInfermiere.UseVisualStyleBackColor = true;
            rdbRechercheInfermiere.CheckedChanged += rdbRechercheInfermiere_CheckedChanged;
            // 
            // rdbRechercheCentre
            // 
            rdbRechercheCentre.AutoSize = true;
            rdbRechercheCentre.Location = new Point(22, 45);
            rdbRechercheCentre.Name = "rdbRechercheCentre";
            rdbRechercheCentre.Size = new Size(227, 24);
            rdbRechercheCentre.TabIndex = 0;
            rdbRechercheCentre.TabStop = true;
            rdbRechercheCentre.Text = "Recherche par centre de soins";
            rdbRechercheCentre.UseVisualStyleBackColor = true;
            rdbRechercheCentre.CheckedChanged += rdbRechercheCentre_CheckedChanged;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(54, 551);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(850, 169);
            dgv.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 752);
            Controls.Add(dgv);
            Controls.Add(grpMain);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpMain.ResumeLayout(false);
            grpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMain;
        private Button btnConnecte;
        private MonthCalendar mthCal;
        private Label lblDate;
        private RadioButton rdbRechercheInfermiere;
        private RadioButton rdbRechercheCentre;
        private ComboBox cboInf;
        private ComboBox cboInfCentre;
        private ComboBox cboCentre;
        private Button btnDeconnecte;
        private DataGridView dgv;
    }
}
