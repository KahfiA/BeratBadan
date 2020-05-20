namespace MoTo
{
    partial class TurunBerat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TurunBerat));
            this.pbTurunBerat = new System.Windows.Forms.PictureBox();
            this.lanjutturun = new System.Windows.Forms.Button();
            this.btKembaliyurun = new System.Windows.Forms.Button();
            this.lblNaik = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbTurunBerat)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTurunBerat
            // 
            this.pbTurunBerat.Image = ((System.Drawing.Image)(resources.GetObject("pbTurunBerat.Image")));
            this.pbTurunBerat.Location = new System.Drawing.Point(2, 2);
            this.pbTurunBerat.Name = "pbTurunBerat";
            this.pbTurunBerat.Size = new System.Drawing.Size(1152, 700);
            this.pbTurunBerat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTurunBerat.TabIndex = 0;
            this.pbTurunBerat.TabStop = false;
            // 
            // lanjutturun
            // 
            this.lanjutturun.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lanjutturun.FlatAppearance.BorderSize = 0;
            this.lanjutturun.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lanjutturun.Location = new System.Drawing.Point(276, 576);
            this.lanjutturun.Name = "lanjutturun";
            this.lanjutturun.Size = new System.Drawing.Size(184, 52);
            this.lanjutturun.TabIndex = 15;
            this.lanjutturun.Text = "Lanjut";
            this.lanjutturun.UseVisualStyleBackColor = false;
            this.lanjutturun.Click += new System.EventHandler(this.lanjutNaik_Click);
            // 
            // btKembaliyurun
            // 
            this.btKembaliyurun.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btKembaliyurun.FlatAppearance.BorderSize = 0;
            this.btKembaliyurun.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKembaliyurun.Location = new System.Drawing.Point(76, 576);
            this.btKembaliyurun.Name = "btKembaliyurun";
            this.btKembaliyurun.Size = new System.Drawing.Size(184, 52);
            this.btKembaliyurun.TabIndex = 14;
            this.btKembaliyurun.Text = "Kembali";
            this.btKembaliyurun.UseVisualStyleBackColor = false;
            this.btKembaliyurun.Click += new System.EventHandler(this.btKembaliNaik_Click);
            // 
            // lblNaik
            // 
            this.lblNaik.AutoSize = true;
            this.lblNaik.BackColor = System.Drawing.Color.White;
            this.lblNaik.Font = new System.Drawing.Font("Futura Md BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaik.Location = new System.Drawing.Point(73, 192);
            this.lblNaik.Name = "lblNaik";
            this.lblNaik.Size = new System.Drawing.Size(592, 352);
            this.lblNaik.TabIndex = 13;
            this.lblNaik.Text = resources.GetString("lblNaik.Text");
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 700);
            this.panel1.TabIndex = 16;
            // 
            // TurunBerat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 708);
            this.Controls.Add(this.lanjutturun);
            this.Controls.Add(this.btKembaliyurun);
            this.Controls.Add(this.lblNaik);
            this.Controls.Add(this.pbTurunBerat);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TurunBerat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menurunkan Berat Badan";
            ((System.ComponentModel.ISupportInitialize)(this.pbTurunBerat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTurunBerat;
        private System.Windows.Forms.Button lanjutturun;
        private System.Windows.Forms.Button btKembaliyurun;
        private System.Windows.Forms.Label lblNaik;
        private System.Windows.Forms.Panel panel1;
    }
}