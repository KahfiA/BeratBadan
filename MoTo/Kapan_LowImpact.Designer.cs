namespace MoTo
{
    partial class Kapan_LowImpact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kapan_LowImpact));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKapanLow = new System.Windows.Forms.Label();
            this.btKembaliKapanLow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1152, 700);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblKapanLow
            // 
            this.lblKapanLow.AutoSize = true;
            this.lblKapanLow.BackColor = System.Drawing.Color.White;
            this.lblKapanLow.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKapanLow.Location = new System.Drawing.Point(87, 233);
            this.lblKapanLow.Name = "lblKapanLow";
            this.lblKapanLow.Size = new System.Drawing.Size(453, 96);
            this.lblKapanLow.TabIndex = 2;
            this.lblKapanLow.Text = "1. Saat cedera dan pemulihan\r\n2. Ingin Olahraga dengan mudah\r\n3. Meningkatkan kes" +
    "elarasan dan keseimbnagn\r\n4. Istirahat dari cardio";
            // 
            // btKembaliKapanLow
            // 
            this.btKembaliKapanLow.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btKembaliKapanLow.FlatAppearance.BorderSize = 0;
            this.btKembaliKapanLow.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKembaliKapanLow.Location = new System.Drawing.Point(91, 387);
            this.btKembaliKapanLow.Name = "btKembaliKapanLow";
            this.btKembaliKapanLow.Size = new System.Drawing.Size(187, 51);
            this.btKembaliKapanLow.TabIndex = 3;
            this.btKembaliKapanLow.Text = "Kembali";
            this.btKembaliKapanLow.UseVisualStyleBackColor = false;
            this.btKembaliKapanLow.Click += new System.EventHandler(this.btKembaliKapanLow_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(7, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 700);
            this.panel1.TabIndex = 4;
            // 
            // Kapan_LowImpact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 708);
            this.Controls.Add(this.btKembaliKapanLow);
            this.Controls.Add(this.lblKapanLow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kapan_LowImpact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Waktu Low Impact";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblKapanLow;
        private System.Windows.Forms.Button btKembaliKapanLow;
        private System.Windows.Forms.Panel panel1;
    }
}