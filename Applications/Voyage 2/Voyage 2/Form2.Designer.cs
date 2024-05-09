namespace Voyage_2
{
    partial class Form2
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
            lblThematique = new Label();
            lblPrixMax = new Label();
            cboTheme = new ComboBox();
            txtPrixMax = new TextBox();
            groupBox1 = new GroupBox();
            dgvPatients = new DataGridView();
            btnAddRows = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            SuspendLayout();
            // 
            // lblThematique
            // 
            lblThematique.AutoSize = true;
            lblThematique.Location = new Point(35, 28);
            lblThematique.Name = "lblThematique";
            lblThematique.Size = new Size(88, 20);
            lblThematique.TabIndex = 0;
            lblThematique.Text = "Thématique";
            // 
            // lblPrixMax
            // 
            lblPrixMax.AutoSize = true;
            lblPrixMax.Location = new Point(35, 88);
            lblPrixMax.Name = "lblPrixMax";
            lblPrixMax.Size = new Size(103, 20);
            lblPrixMax.TabIndex = 1;
            lblPrixMax.Text = "Prix maximum";
            // 
            // cboTheme
            // 
            cboTheme.FormattingEnabled = true;
            cboTheme.Location = new Point(176, 25);
            cboTheme.Name = "cboTheme";
            cboTheme.Size = new Size(181, 28);
            cboTheme.TabIndex = 2;
            cboTheme.SelectionChangeCommitted += cboTheme_SelectionChangeCommitted;
            // 
            // txtPrixMax
            // 
            txtPrixMax.Location = new Point(176, 85);
            txtPrixMax.Name = "txtPrixMax";
            txtPrixMax.Size = new Size(120, 27);
            txtPrixMax.TabIndex = 3;
            txtPrixMax.TextChanged += txtPrixMax_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvPatients);
            groupBox1.Location = new Point(15, 141);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 299);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Autres recherches";
            // 
            // dgvPatients
            // 
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Location = new Point(16, 29);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.Size = new Size(746, 258);
            dgvPatients.TabIndex = 0;
            // 
            // btnAddRows
            // 
            btnAddRows.Location = new Point(585, 63);
            btnAddRows.Name = "btnAddRows";
            btnAddRows.Size = new Size(87, 39);
            btnAddRows.TabIndex = 5;
            btnAddRows.Text = "add";
            btnAddRows.UseVisualStyleBackColor = true;
            btnAddRows.Click += btnAddRows_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddRows);
            Controls.Add(groupBox1);
            Controls.Add(txtPrixMax);
            Controls.Add(cboTheme);
            Controls.Add(lblPrixMax);
            Controls.Add(lblThematique);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblThematique;
        private Label lblPrixMax;
        private ComboBox cboTheme;
        private TextBox txtPrixMax;
        private GroupBox groupBox1;
        private DataGridView dgvPatients;
        private Button btnAddRows;
    }
}