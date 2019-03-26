namespace _2._2.RSSV
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
            this.rtb_prikaz = new System.Windows.Forms.RichTextBox();
            this.btn_pokreni = new System.Windows.Forms.Button();
            this.tb_kriticna = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtb_prikaz
            // 
            this.rtb_prikaz.Location = new System.Drawing.Point(13, 13);
            this.rtb_prikaz.Name = "rtb_prikaz";
            this.rtb_prikaz.Size = new System.Drawing.Size(235, 166);
            this.rtb_prikaz.TabIndex = 0;
            this.rtb_prikaz.Text = "";
            // 
            // btn_pokreni
            // 
            this.btn_pokreni.Location = new System.Drawing.Point(310, 146);
            this.btn_pokreni.Name = "btn_pokreni";
            this.btn_pokreni.Size = new System.Drawing.Size(83, 32);
            this.btn_pokreni.TabIndex = 1;
            this.btn_pokreni.Text = "Pokreni";
            this.btn_pokreni.UseVisualStyleBackColor = true;
            this.btn_pokreni.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_kriticna
            // 
            this.tb_kriticna.Location = new System.Drawing.Point(293, 77);
            this.tb_kriticna.Name = "tb_kriticna";
            this.tb_kriticna.Size = new System.Drawing.Size(100, 22);
            this.tb_kriticna.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 194);
            this.Controls.Add(this.tb_kriticna);
            this.Controls.Add(this.btn_pokreni);
            this.Controls.Add(this.rtb_prikaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_prikaz;
        private System.Windows.Forms.Button btn_pokreni;
        private System.Windows.Forms.TextBox tb_kriticna;
    }
}

