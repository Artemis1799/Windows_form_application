namespace Comptoir
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            trvProduits = new TreeView();
            imgList = new ImageList(components);
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // trvProduits
            // 
            trvProduits.ImageIndex = 0;
            trvProduits.ImageList = imgList;
            trvProduits.Location = new Point(69, 32);
            trvProduits.Name = "trvProduits";
            trvProduits.SelectedImageIndex = 0;
            trvProduits.Size = new Size(739, 394);
            trvProduits.TabIndex = 0;
            // 
            // imgList
            // 
            imgList.ColorDepth = ColorDepth.Depth32Bit;
            imgList.ImageStream = (ImageListStreamer)resources.GetObject("imgList.ImageStream");
            imgList.TransparentColor = Color.Transparent;
            imgList.Images.SetKeyName(0, "0.jpg");
            imgList.Images.SetKeyName(1, "1.jpg");
            imgList.Images.SetKeyName(2, "2.jpg");
            imgList.Images.SetKeyName(3, "3.jpg");
            imgList.Images.SetKeyName(4, "4.jpg");
            imgList.Images.SetKeyName(5, "5.jpg");
            imgList.Images.SetKeyName(6, "6.jpg");
            imgList.Images.SetKeyName(7, "7.jpg");
            imgList.Images.SetKeyName(8, "8.jpg");
            // 
            // button1
            // 
            button1.Location = new Point(671, 436);
            button1.Name = "button1";
            button1.Size = new Size(118, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(505, 441);
            button2.Name = "button2";
            button2.Size = new Size(124, 24);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 472);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(trvProduits);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private TreeView trvProduits;
        private ImageList imgList;
        private Button button1;
        private Button button2;
    }
}
