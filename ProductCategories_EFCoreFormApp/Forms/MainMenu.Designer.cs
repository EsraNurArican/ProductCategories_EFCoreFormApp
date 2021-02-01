
namespace ProductCategories_EFCoreFormApp.Forms
{
    partial class MainMenu
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.button1_CategoryOp = new System.Windows.Forms.Button();
            this.button2_ProductOp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1_CategoryOp
            // 
            this.button1_CategoryOp.Location = new System.Drawing.Point(106, 145);
            this.button1_CategoryOp.Name = "button1_CategoryOp";
            this.button1_CategoryOp.Size = new System.Drawing.Size(151, 23);
            this.button1_CategoryOp.TabIndex = 0;
            this.button1_CategoryOp.Text = "Kategori İşlemleri";
            this.button1_CategoryOp.UseVisualStyleBackColor = true;
            this.button1_CategoryOp.Click += new System.EventHandler(this.button1_CategoryOp_Click);
            // 
            // button2_ProductOp
            // 
            this.button2_ProductOp.Location = new System.Drawing.Point(305, 145);
            this.button2_ProductOp.Name = "button2_ProductOp";
            this.button2_ProductOp.Size = new System.Drawing.Size(144, 23);
            this.button2_ProductOp.TabIndex = 1;
            this.button2_ProductOp.Text = "Ürün İşlemleri";
            this.button2_ProductOp.UseVisualStyleBackColor = true;
            this.button2_ProductOp.Click += new System.EventHandler(this.button2_ProductOp_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(119, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "KATEGORİ ve ÜRÜN İŞLEMLERİ MENÜSÜ";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2_ProductOp);
            this.Controls.Add(this.button1_CategoryOp);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.Button button1_CategoryOp;
        private System.Windows.Forms.Button button2_ProductOp;
        private System.Windows.Forms.TextBox textBox1;
    }
}