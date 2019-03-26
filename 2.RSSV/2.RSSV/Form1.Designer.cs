namespace _2.RSSV
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
            this.lbl_vrijeme = new System.Windows.Forms.Label();
            this.btn_start_stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_vrijeme
            // 
            this.lbl_vrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vrijeme.Location = new System.Drawing.Point(12, 20);
            this.lbl_vrijeme.Name = "lbl_vrijeme";
            this.lbl_vrijeme.Size = new System.Drawing.Size(293, 82);
            this.lbl_vrijeme.TabIndex = 0;
            this.lbl_vrijeme.Text = "Vrijeme";
            // 
            // btn_start_stop
            // 
            this.btn_start_stop.Location = new System.Drawing.Point(261, 156);
            this.btn_start_stop.Name = "btn_start_stop";
            this.btn_start_stop.Size = new System.Drawing.Size(83, 34);
            this.btn_start_stop.TabIndex = 1;
            this.btn_start_stop.Text = "Pokreni";
            this.btn_start_stop.UseVisualStyleBackColor = true;
            this.btn_start_stop.Click += new System.EventHandler(this.btn_start_stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 199);
            this.Controls.Add(this.btn_start_stop);
            this.Controls.Add(this.lbl_vrijeme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_vrijeme;
        private System.Windows.Forms.Button btn_start_stop;
    }
}

