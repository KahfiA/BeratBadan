namespace MoTo
{
    partial class Kapan_HighImpact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kapan_HighImpact));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btKembaliKapanHigh = new System.Windows.Forms.Button();
            this.lblKapanHigh = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-34, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btKembaliKapanHigh);
            this.panel1.Controls.Add(this.lblKapanHigh);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 700);
            this.panel1.TabIndex = 1;
            // 
            // btKembaliKapanHigh
            // 
            this.btKembaliKapanHigh.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btKembaliKapanHigh.FlatAppearance.BorderSize = 0;
            this.btKembaliKapanHigh.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKembaliKapanHigh.Location = new System.Drawing.Point(87, 404);
            this.btKembaliKapanHigh.Name = "btKembaliKapanHigh";
            this.btKembaliKapanHigh.Size = new System.Drawing.Size(187, 51);
            this.btKembaliKapanHigh.TabIndex = 2;
            this.btKembaliKapanHigh.Text = "Kembali";
            this.btKembaliKapanHigh.UseVisualStyleBackColor = false;
            this.btKembaliKapanHigh.Click += new System.EventHandler(this.btKembaliKapanHigh_Click);
            // 
            // lblKapanHigh
            // 
            this.lblKapanHigh.AutoSize = true;
            this.lblKapanHigh.BackColor = System.Drawing.Color.White;
            this.lblKapanHigh.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKapanHigh.Location = new System.Drawing.Point(83, 230);
            this.lblKapanHigh.Name = "lblKapanHigh";
            this.lblKapanHigh.Size = new System.Drawing.Size(404, 120);
            this.lblKapanHigh.TabIndex = 1;
            this.lblKapanHigh.Text = "1. Menurunkan berat badan dengan cepat\r\n2. Ingin tantangan yang lebih berat\r\n3. B" +
    "erlatih untuk kompertisi\r\n4. Ingin meningkatkan kepadatan tulang\r\n5. Ingin eresi" +
    "ko rendah untuk cedera";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-36, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1188, 746);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(10, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1152, 700);
            this.panel2.TabIndex = 3;
            // 
            // Kapan_HighImpact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 708);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kapan_HighImpact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Waktu High Impact";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btKembaliKapanHigh;
        private System.Windows.Forms.Label lblKapanHigh;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
    }
}