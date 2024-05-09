namespace Comptoir
{
    partial class Frm2
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
            grpCategorie = new GroupBox();
            btnRechercher = new Button();
            dgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // grpCategorie
            // 
            grpCategorie.Location = new Point(40, 27);
            grpCategorie.Name = "grpCategorie";
            grpCategorie.Size = new Size(508, 297);
            grpCategorie.TabIndex = 0;
            grpCategorie.TabStop = false;
            grpCategorie.Text = "groupBox1";
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(620, 62);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(212, 29);
            btnRechercher.TabIndex = 2;
            btnRechercher.Text = "Chercher";
            btnRechercher.UseVisualStyleBackColor = true;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(41, 335);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(508, 361);
            dgv.TabIndex = 3;
            // 
            // Frm2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 723);
            Controls.Add(dgv);
            Controls.Add(btnRechercher);
            Controls.Add(grpCategorie);
            Name = "Frm2";
            Text = "Form2";
            Load += Frm2_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpCategorie;
        private Button btnRechercher;
        private DataGridView dgv;
    }
}