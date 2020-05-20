namespace MoTo
{
    partial class NaikBerat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NaikBerat));
            this.lblNaik = new System.Windows.Forms.Label();
            this.btKembaliNaik = new System.Windows.Forms.Button();
            this.pbNaik = new System.Windows.Forms.PictureBox();
            this.lanjutNaik = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbNaik)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaik
            // 
            this.lblNaik.AutoSize = true;
            this.lblNaik.BackColor = System.Drawing.Color.White;
            this.lblNaik.Font = new System.Drawing.Font("Futura Md BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaik.Location = new System.Drawing.Point(82, 196);
            this.lblNaik.Name = "lblNaik";
            this.lblNaik.Size = new System.Drawing.Size(573, 336);
            this.lblNaik.TabIndex = 1;
            this.lblNaik.Text = resources.GetString("lblNaik.Text");
            // 
            // btKembaliNaik
            // 
            this.btKembaliNaik.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btKembaliNaik.FlatAppearance.BorderSize = 0;
            this.btKembaliNaik.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKembaliNaik.Location = new System.Drawing.Point(85, 566);
            this.btKembaliNaik.Name = "btKembaliNaik";
            this.btKembaliNaik.Size = new System.Drawing.Size(184, 52);
            this.btKembaliNaik.TabIndex = 11;
            this.btKembaliNaik.Text = "Kembali";
            this.btKembaliNaik.UseVisualStyleBackColor = false;
            this.btKembaliNaik.Click += new System.EventHandler(this.btKembaliNaik_Click);
            // 
            // pbNaik
            // 
            this.pbNaik.Image = ((System.Drawing.Image)(resources.GetObject("pbNaik.Image")));
            this.pbNaik.Location = new System.Drawing.Point(6, 7);
            this.pbNaik.Name = "pbNaik";
            this.pbNaik.Size = new System.Drawing.Size(1152, 700);
            this.pbNaik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNaik.TabIndex = 0;
            this.pbNaik.TabStop = false;
            // 
            // lanjutNaik
            // 
            this.lanjutNaik.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lanjutNaik.FlatAppearance.BorderSize = 0;
            this.lanjutNaik.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lanjutNaik.Location = new System.Drawing.Point(285, 566);
            this.lanjutNaik.Name = "lanjutNaik";
            this.lanjutNaik.Size = new System.Drawing.Size(184, 52);
            this.lanjutNaik.TabIndex = 12;
            this.lanjutNaik.Text = "Lanjut";
            this.lanjutNaik.UseVisualStyleBackColor = false;
            this.lanjutNaik.Click += new System.EventHandler(this.lanjutNaik_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 700);
            this.panel1.TabIndex = 13;
            // 
            // NaikBerat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 708);
            this.Controls.Add(this.lanjutNaik);
            this.Controls.Add(this.btKembaliNaik);
            this.Controls.Add(this.lblNaik);
            this.Controls.Add(this.pbNaik);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NaikBerat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menaikkan Berat Badan";
            ((System.ComponentModel.ISupportInitialize)(this.pbNaik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNaik;
        private System.Windows.Forms.Label lblNaik;
        private System.Windows.Forms.Button btKembaliNaik;
        private System.Windows.Forms.Button lanjutNaik;
        private System.Windows.Forms.Panel panel1;
    }
}