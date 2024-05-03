namespace PresentationLayer
{
    partial class Ulaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ulaz));
            this.dateTimePickerUlaz = new System.Windows.Forms.DateTimePicker();
            this.buttonUlazNazad = new System.Windows.Forms.Button();
            this.buttonUlazPotvrdi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxProizvodjacUlaz = new System.Windows.Forms.ComboBox();
            this.ComboBoxOvlascenoliceUlaz = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxVrstaRobeUlaz = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKolicinaUlaz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxUlazBroj = new System.Windows.Forms.TextBox();
            this.labelUlazbroj = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerUlaz
            // 
            this.dateTimePickerUlaz.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerUlaz.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerUlaz.Location = new System.Drawing.Point(90, 58);
            this.dateTimePickerUlaz.Name = "dateTimePickerUlaz";
            this.dateTimePickerUlaz.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerUlaz.TabIndex = 29;
            // 
            // buttonUlazNazad
            // 
            this.buttonUlazNazad.Location = new System.Drawing.Point(25, 308);
            this.buttonUlazNazad.MaximumSize = new System.Drawing.Size(75, 23);
            this.buttonUlazNazad.MinimumSize = new System.Drawing.Size(75, 23);
            this.buttonUlazNazad.Name = "buttonUlazNazad";
            this.buttonUlazNazad.Size = new System.Drawing.Size(75, 23);
            this.buttonUlazNazad.TabIndex = 28;
            this.buttonUlazNazad.Text = "Nazad";
            this.buttonUlazNazad.UseVisualStyleBackColor = true;
            this.buttonUlazNazad.Click += new System.EventHandler(this.buttonUlazNazad_Click_1);
            // 
            // buttonUlazPotvrdi
            // 
            this.buttonUlazPotvrdi.BackColor = System.Drawing.Color.Transparent;
            this.buttonUlazPotvrdi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUlazPotvrdi.Image = ((System.Drawing.Image)(resources.GetObject("buttonUlazPotvrdi.Image")));
            this.buttonUlazPotvrdi.Location = new System.Drawing.Point(378, 298);
            this.buttonUlazPotvrdi.Name = "buttonUlazPotvrdi";
            this.buttonUlazPotvrdi.Size = new System.Drawing.Size(55, 43);
            this.buttonUlazPotvrdi.TabIndex = 27;
            this.buttonUlazPotvrdi.UseVisualStyleBackColor = false;
            this.buttonUlazPotvrdi.Click += new System.EventHandler(this.buttonUlazPotvrdi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxProizvodjacUlaz);
            this.groupBox2.Controls.Add(this.ComboBoxOvlascenoliceUlaz);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 100);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // comboBoxProizvodjacUlaz
            // 
            this.comboBoxProizvodjacUlaz.FormattingEnabled = true;
            this.comboBoxProizvodjacUlaz.Location = new System.Drawing.Point(115, 15);
            this.comboBoxProizvodjacUlaz.Name = "comboBoxProizvodjacUlaz";
            this.comboBoxProizvodjacUlaz.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProizvodjacUlaz.TabIndex = 12;
            // 
            // ComboBoxOvlascenoliceUlaz
            // 
            this.ComboBoxOvlascenoliceUlaz.FormattingEnabled = true;
            this.ComboBoxOvlascenoliceUlaz.Location = new System.Drawing.Point(115, 51);
            this.ComboBoxOvlascenoliceUlaz.Name = "ComboBoxOvlascenoliceUlaz";
            this.ComboBoxOvlascenoliceUlaz.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxOvlascenoliceUlaz.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ovlasceno lice:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Proizvodjac:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxVrstaRobeUlaz);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxKolicinaUlaz);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 109);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxVrstaRobeUlaz
            // 
            this.comboBoxVrstaRobeUlaz.FormattingEnabled = true;
            this.comboBoxVrstaRobeUlaz.Location = new System.Drawing.Point(115, 28);
            this.comboBoxVrstaRobeUlaz.Name = "comboBoxVrstaRobeUlaz";
            this.comboBoxVrstaRobeUlaz.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVrstaRobeUlaz.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kolicina:";
            // 
            // textBoxKolicinaUlaz
            // 
            this.textBoxKolicinaUlaz.Location = new System.Drawing.Point(115, 62);
            this.textBoxKolicinaUlaz.Name = "textBoxKolicinaUlaz";
            this.textBoxKolicinaUlaz.Size = new System.Drawing.Size(121, 20);
            this.textBoxKolicinaUlaz.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vrsta robe:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(406, 151);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 141);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(331, 151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(292, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxUlazBroj
            // 
            this.textBoxUlazBroj.Location = new System.Drawing.Point(163, 7);
            this.textBoxUlazBroj.Name = "textBoxUlazBroj";
            this.textBoxUlazBroj.Size = new System.Drawing.Size(100, 20);
            this.textBoxUlazBroj.TabIndex = 21;
            // 
            // labelUlazbroj
            // 
            this.labelUlazbroj.AutoSize = true;
            this.labelUlazbroj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelUlazbroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUlazbroj.Location = new System.Drawing.Point(90, 10);
            this.labelUlazbroj.Name = "labelUlazbroj";
            this.labelUlazbroj.Size = new System.Drawing.Size(67, 15);
            this.labelUlazbroj.TabIndex = 20;
            this.labelUlazbroj.Text = "Ulaz broj: ";
            // 
            // Ulaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 349);
            this.Controls.Add(this.dateTimePickerUlaz);
            this.Controls.Add(this.buttonUlazNazad);
            this.Controls.Add(this.buttonUlazPotvrdi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxUlazBroj);
            this.Controls.Add(this.labelUlazbroj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ulaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ulaz";
            this.Load += new System.EventHandler(this.Ulaz_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerUlaz;
        private System.Windows.Forms.Button buttonUlazNazad;
        private System.Windows.Forms.Button buttonUlazPotvrdi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxProizvodjacUlaz;
        private System.Windows.Forms.ComboBox ComboBoxOvlascenoliceUlaz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxVrstaRobeUlaz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKolicinaUlaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxUlazBroj;
        private System.Windows.Forms.Label labelUlazbroj;
    }
}