namespace MoTo
{
    partial class Pendahuluan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pendahuluan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btLanjut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPendahuluan2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btLanjut);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblPendahuluan2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 700);
            this.panel1.TabIndex = 5;
            // 
            // btLanjut
            // 
            this.btLanjut.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btLanjut.FlatAppearance.BorderSize = 0;
            this.btLanjut.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLanjut.Location = new System.Drawing.Point(839, 527);
            this.btLanjut.Name = "btLanjut";
            this.btLanjut.Size = new System.Drawing.Size(172, 41);
            this.btLanjut.TabIndex = 8;
            this.btLanjut.Text = "Lanjut";
            this.btLanjut.UseVisualStyleBackColor = false;
            this.btLanjut.Click += new System.EventHandler(this.btLanjut_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "MoTo (Move Together)";
            // 
            // lblPendahuluan2
            // 
            this.lblPendahuluan2.AutoSize = true;
            this.lblPendahuluan2.BackColor = System.Drawing.Color.White;
            this.lblPendahuluan2.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendahuluan2.Location = new System.Drawing.Point(102, 299);
            this.lblPendahuluan2.Name = "lblPendahuluan2";
            this.lblPendahuluan2.Size = new System.Drawing.Size(933, 100);
            this.lblPendahuluan2.TabIndex = 6;
            this.lblPendahuluan2.Text = resources.GetString("lblPendahuluan2.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1152, 700);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Pendahuluan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 708);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pendahuluan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pendahuluan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btLanjut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPendahuluan2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}