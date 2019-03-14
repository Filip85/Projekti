namespace _1._2.AplikacijaSPeriodičnimUčitavanjemPodataka
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.Pk = new System.Windows.Forms.GroupBox();
            this.tbx_UlaznaDat = new System.Windows.Forms.TextBox();
            this.btn_Pokreni = new System.Windows.Forms.Button();
            this.tb_KriticnaVrijednost = new System.Windows.Forms.TextBox();
            this.Pk.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(50, 12);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(141, 126);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
           
            // 
            // Pk
            // 
            this.Pk.Controls.Add(this.tb_KriticnaVrijednost);
            this.Pk.Controls.Add(this.tbx_UlaznaDat);
            this.Pk.Controls.Add(this.btn_Pokreni);
            this.Pk.Location = new System.Drawing.Point(50, 173);
            this.Pk.Name = "Pk";
            this.Pk.Size = new System.Drawing.Size(262, 117);
            this.Pk.TabIndex = 1;
            this.Pk.TabStop = false;
            this.Pk.Text = "Pokreni:";
            // 
            // tbx_UlaznaDat
            // 
            this.tbx_UlaznaDat.Location = new System.Drawing.Point(20, 35);
            this.tbx_UlaznaDat.Name = "tbx_UlaznaDat";
            this.tbx_UlaznaDat.Size = new System.Drawing.Size(100, 22);
            this.tbx_UlaznaDat.TabIndex = 1;
            // 
            // btn_Pokreni
            // 
            this.btn_Pokreni.Location = new System.Drawing.Point(32, 73);
            this.btn_Pokreni.Name = "btn_Pokreni";
            this.btn_Pokreni.Size = new System.Drawing.Size(75, 23);
            this.btn_Pokreni.TabIndex = 0;
            this.btn_Pokreni.Text = "Pokreni";
            this.btn_Pokreni.UseVisualStyleBackColor = true;
            this.btn_Pokreni.Click += new System.EventHandler(this.btn_Pokreni_Click);
            // 
            // tb_KriticnaVrijednost
            // 
            this.tb_KriticnaVrijednost.Location = new System.Drawing.Point(144, 35);
            this.tb_KriticnaVrijednost.Name = "tb_KriticnaVrijednost";
            this.tb_KriticnaVrijednost.Size = new System.Drawing.Size(100, 22);
            this.tb_KriticnaVrijednost.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 302);
            this.Controls.Add(this.Pk);
            this.Controls.Add(this.richTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Pk.ResumeLayout(false);
            this.Pk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.GroupBox Pk;
        private System.Windows.Forms.Button btn_Pokreni;
        private System.Windows.Forms.TextBox tbx_UlaznaDat;
        private System.Windows.Forms.TextBox tb_KriticnaVrijednost;
    }
}

