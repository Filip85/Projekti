namespace _1.RSSV
{
    partial class Form1
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
            System.Windows.Forms.Label lbl_BrojStupaca;
            this.rtbx_Matrica = new System.Windows.Forms.RichTextBox();
            this.gb_Podaci = new System.Windows.Forms.GroupBox();
            this.btn_Generiraj = new System.Windows.Forms.Button();
            this.tbx_GornjaGr = new System.Windows.Forms.TextBox();
            this.tbx_DonjaGr = new System.Windows.Forms.TextBox();
            this.tbx_BrStupaca = new System.Windows.Forms.TextBox();
            this.tbx_BrRedaka = new System.Windows.Forms.TextBox();
            this.lbl_GornjaGr = new System.Windows.Forms.Label();
            this.lbl_DonjaGr = new System.Windows.Forms.Label();
            this.lbl_BrRedaka = new System.Windows.Forms.Label();
            this.gb_UlaznaDat = new System.Windows.Forms.GroupBox();
            this.btn_UcitajDat = new System.Windows.Forms.Button();
            this.tbx_UlaznaDat = new System.Windows.Forms.TextBox();
            this.gb_IzlazneDat = new System.Windows.Forms.GroupBox();
            this.tbx_IzlaznaDat = new System.Windows.Forms.TextBox();
            this.btn_ZapisDat = new System.Windows.Forms.Button();
            this.gb_MnoziSkalarom = new System.Windows.Forms.GroupBox();
            this.btn_MnoziSkalarom = new System.Windows.Forms.Button();
            this.tbx_Skalar = new System.Windows.Forms.TextBox();
            this.gb_Transponiraj = new System.Windows.Forms.GroupBox();
            this.btn_Transponiraj = new System.Windows.Forms.Button();
            this.btn_Izlaz = new System.Windows.Forms.Button();
            lbl_BrojStupaca = new System.Windows.Forms.Label();
            this.gb_Podaci.SuspendLayout();
            this.gb_UlaznaDat.SuspendLayout();
            this.gb_IzlazneDat.SuspendLayout();
            this.gb_MnoziSkalarom.SuspendLayout();
            this.gb_Transponiraj.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_BrojStupaca
            // 
            lbl_BrojStupaca.AutoSize = true;
            lbl_BrojStupaca.Location = new System.Drawing.Point(6, 82);
            lbl_BrojStupaca.Name = "lbl_BrojStupaca";
            lbl_BrojStupaca.Size = new System.Drawing.Size(91, 17);
            lbl_BrojStupaca.TabIndex = 1;
            lbl_BrojStupaca.Text = "Broj stupaca:";
            // 
            // rtbx_Matrica
            // 
            this.rtbx_Matrica.Location = new System.Drawing.Point(336, 13);
            this.rtbx_Matrica.Name = "rtbx_Matrica";
            this.rtbx_Matrica.ReadOnly = true;
            this.rtbx_Matrica.Size = new System.Drawing.Size(660, 266);
            this.rtbx_Matrica.TabIndex = 0;
            this.rtbx_Matrica.Text = "";
            this.rtbx_Matrica.WordWrap = false;
            // 
            // gb_Podaci
            // 
            this.gb_Podaci.Controls.Add(this.btn_Generiraj);
            this.gb_Podaci.Controls.Add(this.tbx_GornjaGr);
            this.gb_Podaci.Controls.Add(this.tbx_DonjaGr);
            this.gb_Podaci.Controls.Add(this.tbx_BrStupaca);
            this.gb_Podaci.Controls.Add(this.tbx_BrRedaka);
            this.gb_Podaci.Controls.Add(this.lbl_GornjaGr);
            this.gb_Podaci.Controls.Add(this.lbl_DonjaGr);
            this.gb_Podaci.Controls.Add(lbl_BrojStupaca);
            this.gb_Podaci.Controls.Add(this.lbl_BrRedaka);
            this.gb_Podaci.Location = new System.Drawing.Point(13, 13);
            this.gb_Podaci.Name = "gb_Podaci";
            this.gb_Podaci.Size = new System.Drawing.Size(281, 266);
            this.gb_Podaci.TabIndex = 1;
            this.gb_Podaci.TabStop = false;
            this.gb_Podaci.Text = "Unesite podatke:";
            // 
            // btn_Generiraj
            // 
            this.btn_Generiraj.Location = new System.Drawing.Point(138, 221);
            this.btn_Generiraj.Name = "btn_Generiraj";
            this.btn_Generiraj.Size = new System.Drawing.Size(75, 23);
            this.btn_Generiraj.TabIndex = 8;
            this.btn_Generiraj.Text = "Generiraj";
            this.btn_Generiraj.UseVisualStyleBackColor = true;
            this.btn_Generiraj.Click += new System.EventHandler(this.btn_Generiraj_Click);
            // 
            // tbx_GornjaGr
            // 
            this.tbx_GornjaGr.Location = new System.Drawing.Point(118, 178);
            this.tbx_GornjaGr.Name = "tbx_GornjaGr";
            this.tbx_GornjaGr.Size = new System.Drawing.Size(152, 22);
            this.tbx_GornjaGr.TabIndex = 7;
            // 
            // tbx_DonjaGr
            // 
            this.tbx_DonjaGr.Location = new System.Drawing.Point(118, 137);
            this.tbx_DonjaGr.Name = "tbx_DonjaGr";
            this.tbx_DonjaGr.Size = new System.Drawing.Size(152, 22);
            this.tbx_DonjaGr.TabIndex = 6;
            // 
            // tbx_BrStupaca
            // 
            this.tbx_BrStupaca.Location = new System.Drawing.Point(101, 79);
            this.tbx_BrStupaca.Name = "tbx_BrStupaca";
            this.tbx_BrStupaca.Size = new System.Drawing.Size(152, 22);
            this.tbx_BrStupaca.TabIndex = 5;
            // 
            // tbx_BrRedaka
            // 
            this.tbx_BrRedaka.Location = new System.Drawing.Point(101, 37);
            this.tbx_BrRedaka.Name = "tbx_BrRedaka";
            this.tbx_BrRedaka.Size = new System.Drawing.Size(152, 22);
            this.tbx_BrRedaka.TabIndex = 4;
            // 
            // lbl_GornjaGr
            // 
            this.lbl_GornjaGr.AutoSize = true;
            this.lbl_GornjaGr.Location = new System.Drawing.Point(6, 183);
            this.lbl_GornjaGr.Name = "lbl_GornjaGr";
            this.lbl_GornjaGr.Size = new System.Drawing.Size(106, 17);
            this.lbl_GornjaGr.TabIndex = 3;
            this.lbl_GornjaGr.Text = "Gornja granica:";
            // 
            // lbl_DonjaGr
            // 
            this.lbl_DonjaGr.AutoSize = true;
            this.lbl_DonjaGr.Location = new System.Drawing.Point(6, 137);
            this.lbl_DonjaGr.Name = "lbl_DonjaGr";
            this.lbl_DonjaGr.Size = new System.Drawing.Size(100, 17);
            this.lbl_DonjaGr.TabIndex = 2;
            this.lbl_DonjaGr.Text = "Donja granica:";
            // 
            // lbl_BrRedaka
            // 
            this.lbl_BrRedaka.AutoSize = true;
            this.lbl_BrRedaka.Location = new System.Drawing.Point(6, 37);
            this.lbl_BrRedaka.Name = "lbl_BrRedaka";
            this.lbl_BrRedaka.Size = new System.Drawing.Size(85, 17);
            this.lbl_BrRedaka.TabIndex = 0;
            this.lbl_BrRedaka.Text = "Broj redaka:";
            // 
            // gb_UlaznaDat
            // 
            this.gb_UlaznaDat.Controls.Add(this.btn_UcitajDat);
            this.gb_UlaznaDat.Controls.Add(this.tbx_UlaznaDat);
            this.gb_UlaznaDat.Location = new System.Drawing.Point(12, 288);
            this.gb_UlaznaDat.Name = "gb_UlaznaDat";
            this.gb_UlaznaDat.Size = new System.Drawing.Size(281, 109);
            this.gb_UlaznaDat.TabIndex = 2;
            this.gb_UlaznaDat.TabStop = false;
            this.gb_UlaznaDat.Text = "Ime ulazne dat:";
            // 
            // btn_UcitajDat
            // 
            this.btn_UcitajDat.Location = new System.Drawing.Point(179, 41);
            this.btn_UcitajDat.Name = "btn_UcitajDat";
            this.btn_UcitajDat.Size = new System.Drawing.Size(75, 23);
            this.btn_UcitajDat.TabIndex = 9;
            this.btn_UcitajDat.Text = "Učitaj";
            this.btn_UcitajDat.UseVisualStyleBackColor = true;
            this.btn_UcitajDat.Click += new System.EventHandler(this.btn_UcitajDat_Click);
            // 
            // tbx_UlaznaDat
            // 
            this.tbx_UlaznaDat.Location = new System.Drawing.Point(10, 42);
            this.tbx_UlaznaDat.Name = "tbx_UlaznaDat";
            this.tbx_UlaznaDat.Size = new System.Drawing.Size(152, 22);
            this.tbx_UlaznaDat.TabIndex = 9;
            // 
            // gb_IzlazneDat
            // 
            this.gb_IzlazneDat.Controls.Add(this.tbx_IzlaznaDat);
            this.gb_IzlazneDat.Controls.Add(this.btn_ZapisDat);
            this.gb_IzlazneDat.Location = new System.Drawing.Point(12, 414);
            this.gb_IzlazneDat.Name = "gb_IzlazneDat";
            this.gb_IzlazneDat.Size = new System.Drawing.Size(281, 109);
            this.gb_IzlazneDat.TabIndex = 3;
            this.gb_IzlazneDat.TabStop = false;
            this.gb_IzlazneDat.Text = "Ime izlazne dat:";
            // 
            // tbx_IzlaznaDat
            // 
            this.tbx_IzlaznaDat.Location = new System.Drawing.Point(10, 48);
            this.tbx_IzlaznaDat.Name = "tbx_IzlaznaDat";
            this.tbx_IzlaznaDat.Size = new System.Drawing.Size(152, 22);
            this.tbx_IzlaznaDat.TabIndex = 10;
            // 
            // btn_ZapisDat
            // 
            this.btn_ZapisDat.Location = new System.Drawing.Point(179, 47);
            this.btn_ZapisDat.Name = "btn_ZapisDat";
            this.btn_ZapisDat.Size = new System.Drawing.Size(75, 23);
            this.btn_ZapisDat.TabIndex = 10;
            this.btn_ZapisDat.Text = "Zapiši";
            this.btn_ZapisDat.UseVisualStyleBackColor = true;
            this.btn_ZapisDat.Click += new System.EventHandler(this.btn_ZapisDat_Click);
            // 
            // gb_MnoziSkalarom
            // 
            this.gb_MnoziSkalarom.Controls.Add(this.btn_MnoziSkalarom);
            this.gb_MnoziSkalarom.Controls.Add(this.tbx_Skalar);
            this.gb_MnoziSkalarom.Location = new System.Drawing.Point(336, 300);
            this.gb_MnoziSkalarom.Name = "gb_MnoziSkalarom";
            this.gb_MnoziSkalarom.Size = new System.Drawing.Size(281, 109);
            this.gb_MnoziSkalarom.TabIndex = 10;
            this.gb_MnoziSkalarom.TabStop = false;
            this.gb_MnoziSkalarom.Text = "Množenje skalarom:";
            // 
            // btn_MnoziSkalarom
            // 
            this.btn_MnoziSkalarom.Location = new System.Drawing.Point(179, 41);
            this.btn_MnoziSkalarom.Name = "btn_MnoziSkalarom";
            this.btn_MnoziSkalarom.Size = new System.Drawing.Size(75, 23);
            this.btn_MnoziSkalarom.TabIndex = 9;
            this.btn_MnoziSkalarom.Text = "Množi";
            this.btn_MnoziSkalarom.UseVisualStyleBackColor = true;
            this.btn_MnoziSkalarom.Click += new System.EventHandler(this.btn_MnoziSkalarom_Click);
            // 
            // tbx_Skalar
            // 
            this.tbx_Skalar.Location = new System.Drawing.Point(10, 42);
            this.tbx_Skalar.Name = "tbx_Skalar";
            this.tbx_Skalar.Size = new System.Drawing.Size(152, 22);
            this.tbx_Skalar.TabIndex = 9;
            // 
            // gb_Transponiraj
            // 
            this.gb_Transponiraj.Controls.Add(this.btn_Transponiraj);
            this.gb_Transponiraj.Location = new System.Drawing.Point(639, 300);
            this.gb_Transponiraj.Name = "gb_Transponiraj";
            this.gb_Transponiraj.Size = new System.Drawing.Size(270, 109);
            this.gb_Transponiraj.TabIndex = 11;
            this.gb_Transponiraj.TabStop = false;
            this.gb_Transponiraj.Text = "Transponiraj:";
            // 
            // btn_Transponiraj
            // 
            this.btn_Transponiraj.Location = new System.Drawing.Point(102, 42);
            this.btn_Transponiraj.Name = "btn_Transponiraj";
            this.btn_Transponiraj.Size = new System.Drawing.Size(105, 38);
            this.btn_Transponiraj.TabIndex = 9;
            this.btn_Transponiraj.Text = "Transponiraj";
            this.btn_Transponiraj.UseVisualStyleBackColor = true;
            this.btn_Transponiraj.Click += new System.EventHandler(this.btn_Transponiraj_Click);
            // 
            // btn_Izlaz
            // 
            this.btn_Izlaz.Location = new System.Drawing.Point(889, 462);
            this.btn_Izlaz.Name = "btn_Izlaz";
            this.btn_Izlaz.Size = new System.Drawing.Size(75, 23);
            this.btn_Izlaz.TabIndex = 10;
            this.btn_Izlaz.Text = "Izlaz";
            this.btn_Izlaz.UseVisualStyleBackColor = true;
            this.btn_Izlaz.Click += new System.EventHandler(this.btn_Izlaz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 546);
            this.Controls.Add(this.btn_Izlaz);
            this.Controls.Add(this.gb_Transponiraj);
            this.Controls.Add(this.gb_MnoziSkalarom);
            this.Controls.Add(this.gb_IzlazneDat);
            this.Controls.Add(this.gb_UlaznaDat);
            this.Controls.Add(this.gb_Podaci);
            this.Controls.Add(this.rtbx_Matrica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_Podaci.ResumeLayout(false);
            this.gb_Podaci.PerformLayout();
            this.gb_UlaznaDat.ResumeLayout(false);
            this.gb_UlaznaDat.PerformLayout();
            this.gb_IzlazneDat.ResumeLayout(false);
            this.gb_IzlazneDat.PerformLayout();
            this.gb_MnoziSkalarom.ResumeLayout(false);
            this.gb_MnoziSkalarom.PerformLayout();
            this.gb_Transponiraj.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbx_Matrica;
        private System.Windows.Forms.GroupBox gb_Podaci;
        private System.Windows.Forms.Button btn_Generiraj;
        private System.Windows.Forms.TextBox tbx_GornjaGr;
        private System.Windows.Forms.TextBox tbx_DonjaGr;
        private System.Windows.Forms.TextBox tbx_BrStupaca;
        private System.Windows.Forms.TextBox tbx_BrRedaka;
        private System.Windows.Forms.Label lbl_GornjaGr;
        private System.Windows.Forms.Label lbl_DonjaGr;
        private System.Windows.Forms.Label lbl_BrRedaka;
        private System.Windows.Forms.GroupBox gb_UlaznaDat;
        private System.Windows.Forms.Button btn_UcitajDat;
        private System.Windows.Forms.TextBox tbx_UlaznaDat;
        private System.Windows.Forms.GroupBox gb_IzlazneDat;
        private System.Windows.Forms.TextBox tbx_IzlaznaDat;
        private System.Windows.Forms.Button btn_ZapisDat;
        private System.Windows.Forms.GroupBox gb_MnoziSkalarom;
        private System.Windows.Forms.Button btn_MnoziSkalarom;
        private System.Windows.Forms.TextBox tbx_Skalar;
        private System.Windows.Forms.GroupBox gb_Transponiraj;
        private System.Windows.Forms.Button btn_Transponiraj;
        private System.Windows.Forms.Button btn_Izlaz;
    }
}

