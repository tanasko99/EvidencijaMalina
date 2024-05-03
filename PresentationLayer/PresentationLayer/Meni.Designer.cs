namespace PresentationLayer
{
    partial class Meni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meni));
            this.buttonMeniIzlaz = new System.Windows.Forms.Button();
            this.buttonMeniUlaz = new System.Windows.Forms.Button();
            this.labelUlaz = new System.Windows.Forms.Label();
            this.labelIzlaz = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMeniOdjava = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMeniIzlaz
            // 
            this.buttonMeniIzlaz.BackColor = System.Drawing.Color.Transparent;
            this.buttonMeniIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMeniIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("buttonMeniIzlaz.Image")));
            this.buttonMeniIzlaz.Location = new System.Drawing.Point(173, 33);
            this.buttonMeniIzlaz.Name = "buttonMeniIzlaz";
            this.buttonMeniIzlaz.Size = new System.Drawing.Size(74, 70);
            this.buttonMeniIzlaz.TabIndex = 0;
            this.buttonMeniIzlaz.UseVisualStyleBackColor = false;
            this.buttonMeniIzlaz.Click += new System.EventHandler(this.buttonMeniIzlaz_Click);
            // 
            // buttonMeniUlaz
            // 
            this.buttonMeniUlaz.BackColor = System.Drawing.Color.Transparent;
            this.buttonMeniUlaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMeniUlaz.Image = ((System.Drawing.Image)(resources.GetObject("buttonMeniUlaz.Image")));
            this.buttonMeniUlaz.Location = new System.Drawing.Point(33, 148);
            this.buttonMeniUlaz.Name = "buttonMeniUlaz";
            this.buttonMeniUlaz.Size = new System.Drawing.Size(74, 70);
            this.buttonMeniUlaz.TabIndex = 1;
            this.buttonMeniUlaz.UseVisualStyleBackColor = false;
            this.buttonMeniUlaz.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelUlaz
            // 
            this.labelUlaz.AutoSize = true;
            this.labelUlaz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelUlaz.Location = new System.Drawing.Point(51, 231);
            this.labelUlaz.Name = "labelUlaz";
            this.labelUlaz.Size = new System.Drawing.Size(37, 15);
            this.labelUlaz.TabIndex = 2;
            this.labelUlaz.Text = "ULAZ";
            // 
            // labelIzlaz
            // 
            this.labelIzlaz.AutoSize = true;
            this.labelIzlaz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelIzlaz.Location = new System.Drawing.Point(190, 114);
            this.labelIzlaz.Name = "labelIzlaz";
            this.labelIzlaz.Size = new System.Drawing.Size(39, 15);
            this.labelIzlaz.TabIndex = 3;
            this.labelIzlaz.Text = "IZLAZ";
            this.labelIzlaz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buttonMeniOdjava
            // 
            this.buttonMeniOdjava.AutoSize = true;
            this.buttonMeniOdjava.BackColor = System.Drawing.Color.Transparent;
            this.buttonMeniOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMeniOdjava.Image = ((System.Drawing.Image)(resources.GetObject("buttonMeniOdjava.Image")));
            this.buttonMeniOdjava.Location = new System.Drawing.Point(173, 148);
            this.buttonMeniOdjava.Name = "buttonMeniOdjava";
            this.buttonMeniOdjava.Size = new System.Drawing.Size(74, 70);
            this.buttonMeniOdjava.TabIndex = 5;
            this.buttonMeniOdjava.UseVisualStyleBackColor = false;
            this.buttonMeniOdjava.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(190, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "ODJAVA";
            // 
            // Meni
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(275, 264);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMeniOdjava);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelIzlaz);
            this.Controls.Add(this.labelUlaz);
            this.Controls.Add(this.buttonMeniUlaz);
            this.Controls.Add(this.buttonMeniIzlaz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Meni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meni";
            this.Load += new System.EventHandler(this.Meni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMeniIzlaz;
        private System.Windows.Forms.Button buttonMeniUlaz;
        private System.Windows.Forms.Label labelUlaz;
        private System.Windows.Forms.Label labelIzlaz;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonMeniOdjava;
        private System.Windows.Forms.Label label1;
    }
}