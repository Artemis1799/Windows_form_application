namespace Voyage_2
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
            chkDestination = new CheckBox();
            chkDateDepart = new CheckBox();
            chkClient = new CheckBox();
            btnRecherche = new Button();
            dtpDate = new DateTimePicker();
            cboDestination = new ComboBox();
            groupBox1 = new GroupBox();
            dgv = new DataGridView();
            txtClient = new TextBox();
            btnReset = new Button();
            btnFrm2 = new Button();
            btnAddRows = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // chkDestination
            // 
            chkDestination.AutoSize = true;
            chkDestination.Location = new Point(26, 32);
            chkDestination.Name = "chkDestination";
            chkDestination.Size = new Size(129, 24);
            chkDestination.TabIndex = 0;
            chkDestination.Text = "Par destination";
            chkDestination.UseVisualStyleBackColor = true;
            chkDestination.CheckedChanged += chkDestination_CheckedChanged;
            // 
            // chkDateDepart
            // 
            chkDateDepart.AutoSize = true;
            chkDateDepart.Location = new Point(26, 81);
            chkDateDepart.Name = "chkDateDepart";
            chkDateDepart.Size = new Size(154, 24);
            chkDateDepart.TabIndex = 1;
            chkDateDepart.Text = "Par date de départ";
            chkDateDepart.UseVisualStyleBackColor = true;
            chkDateDepart.CheckedChanged += chkDateDepart_CheckedChanged;
            // 
            // chkClient
            // 
            chkClient.AutoSize = true;
            chkClient.Location = new Point(26, 129);
            chkClient.Name = "chkClient";
            chkClient.Size = new Size(91, 24);
            chkClient.TabIndex = 2;
            chkClient.Text = "Par client";
            chkClient.UseVisualStyleBackColor = true;
            chkClient.CheckedChanged += chkClient_CheckedChanged;
            // 
            // btnRecherche
            // 
            btnRecherche.Location = new Point(587, 129);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(190, 56);
            btnRecherche.TabIndex = 3;
            btnRecherche.Text = "Lancer la recherche";
            btnRecherche.UseVisualStyleBackColor = true;
            btnRecherche.Click += btnRecherche_Click;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(241, 81);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 27);
            dtpDate.TabIndex = 4;
            dtpDate.Visible = false;
            // 
            // cboDestination
            // 
            cboDestination.FormattingEnabled = true;
            cboDestination.Location = new Point(241, 28);
            cboDestination.Name = "cboDestination";
            cboDestination.Size = new Size(251, 28);
            cboDestination.TabIndex = 5;
            cboDestination.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv);
            groupBox1.Location = new Point(13, 202);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(772, 240);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recapitulatif des reservations";
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(6, 26);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(758, 208);
            dgv.TabIndex = 0;
            // 
            // txtClient
            // 
            txtClient.Location = new Point(241, 127);
            txtClient.Name = "txtClient";
            txtClient.Size = new Size(251, 27);
            txtClient.TabIndex = 8;
            txtClient.Visible = false;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(587, 49);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(190, 56);
            btnReset.TabIndex = 9;
            btnReset.Text = "Nouveau voyage";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnFrm2
            // 
            btnFrm2.Location = new Point(544, 9);
            btnFrm2.Name = "btnFrm2";
            btnFrm2.Size = new Size(47, 35);
            btnFrm2.TabIndex = 10;
            btnFrm2.Text = "2";
            btnFrm2.UseVisualStyleBackColor = true;
            btnFrm2.Click += btnFrm2_Click;
            // 
            // btnAddRows
            // 
            btnAddRows.Location = new Point(509, 170);
            btnAddRows.Name = "btnAddRows";
            btnAddRows.Size = new Size(50, 33);
            btnAddRows.TabIndex = 11;
            btnAddRows.Text = "add";
            btnAddRows.UseVisualStyleBackColor = true;
            btnAddRows.Click += btnAddRows_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddRows);
            Controls.Add(btnFrm2);
            Controls.Add(btnReset);
            Controls.Add(txtClient);
            Controls.Add(groupBox1);
            Controls.Add(cboDestination);
            Controls.Add(dtpDate);
            Controls.Add(btnRecherche);
            Controls.Add(chkClient);
            Controls.Add(chkDateDepart);
            Controls.Add(chkDestination);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkDestination;
        private CheckBox chkDateDepart;
        private CheckBox chkClient;
        private Button btnRecherche;
        private DateTimePicker dtpDate;
        private ComboBox cboDestination;
        private GroupBox groupBox1;
        private DataGridView dgv;
        private TextBox txtClient;
        private Button btnReset;
        private Button btnFrm2;
        private Button btnAddRows;
    }
}
