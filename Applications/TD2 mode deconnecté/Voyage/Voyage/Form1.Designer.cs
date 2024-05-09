namespace Voyage
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
            btn_exo1 = new Button();
            btn_exo3 = new Button();
            btn_exo2 = new Button();
            lbl_cbo_ligne = new Label();
            lbl_cbo_liaison = new Label();
            cbo_ligne = new ComboBox();
            cbo_lisaison = new ComboBox();
            dgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // btn_exo1
            // 
            btn_exo1.Location = new Point(109, 62);
            btn_exo1.Name = "btn_exo1";
            btn_exo1.Size = new Size(174, 81);
            btn_exo1.TabIndex = 0;
            btn_exo1.Text = "Exo 1";
            btn_exo1.UseVisualStyleBackColor = true;
            btn_exo1.Click += btn_exo1_Click;
            // 
            // btn_exo3
            // 
            btn_exo3.Location = new Point(109, 286);
            btn_exo3.Name = "btn_exo3";
            btn_exo3.Size = new Size(174, 81);
            btn_exo3.TabIndex = 1;
            btn_exo3.Text = "Exo 3";
            btn_exo3.UseVisualStyleBackColor = true;
            btn_exo3.Click += btn_exo3_Click;
            // 
            // btn_exo2
            // 
            btn_exo2.Location = new Point(109, 174);
            btn_exo2.Name = "btn_exo2";
            btn_exo2.Size = new Size(174, 81);
            btn_exo2.TabIndex = 2;
            btn_exo2.Text = "Exo 2";
            btn_exo2.UseVisualStyleBackColor = true;
            btn_exo2.Click += btn_exo2_Click;
            // 
            // lbl_cbo_ligne
            // 
            lbl_cbo_ligne.AutoSize = true;
            lbl_cbo_ligne.Location = new Point(448, 74);
            lbl_cbo_ligne.Name = "lbl_cbo_ligne";
            lbl_cbo_ligne.Size = new Size(95, 20);
            lbl_cbo_ligne.TabIndex = 3;
            lbl_cbo_ligne.Text = "Combo ligne";
            // 
            // lbl_cbo_liaison
            // 
            lbl_cbo_liaison.AutoSize = true;
            lbl_cbo_liaison.Location = new Point(448, 114);
            lbl_cbo_liaison.Name = "lbl_cbo_liaison";
            lbl_cbo_liaison.Size = new Size(105, 20);
            lbl_cbo_liaison.TabIndex = 4;
            lbl_cbo_liaison.Text = "Combo liaison";
            // 
            // cbo_ligne
            // 
            cbo_ligne.FormattingEnabled = true;
            cbo_ligne.Location = new Point(596, 74);
            cbo_ligne.Name = "cbo_ligne";
            cbo_ligne.Size = new Size(143, 28);
            cbo_ligne.TabIndex = 5;
            // 
            // cbo_lisaison
            // 
            cbo_lisaison.FormattingEnabled = true;
            cbo_lisaison.Location = new Point(596, 108);
            cbo_lisaison.Name = "cbo_lisaison";
            cbo_lisaison.Size = new Size(143, 28);
            cbo_lisaison.TabIndex = 6;
            cbo_lisaison.SelectionChangeCommitted += cbo_lisaison_SelectionChangeCommitted;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(404, 209);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(555, 257);
            dgv.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 575);
            Controls.Add(dgv);
            Controls.Add(cbo_lisaison);
            Controls.Add(cbo_ligne);
            Controls.Add(lbl_cbo_liaison);
            Controls.Add(lbl_cbo_ligne);
            Controls.Add(btn_exo2);
            Controls.Add(btn_exo3);
            Controls.Add(btn_exo1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_exo1;
        private Button btn_exo3;
        private Button btn_exo2;
        private Label lbl_cbo_ligne;
        private Label lbl_cbo_liaison;
        private ComboBox cbo_ligne;
        private ComboBox cbo_lisaison;
        private DataGridView dgv;
    }
}
