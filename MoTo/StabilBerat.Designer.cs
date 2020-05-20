namespace MoTo
{
    partial class StabilBerat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StabilBerat));
            this.pbStabil = new System.Windows.Forms.PictureBox();
            this.btKembaliStabil = new System.Windows.Forms.Button();
            this.lblStabil = new System.Windows.Forms.Label();
            this.lanjutStabil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbStabil)).BeginInit();
            this.SuspendLayout();
            // 
            // pbStabil
            // 
            this.pbStabil.Image = ((System.Drawing.Image)(resources.GetObject("pbStabil.Image")));
            this.pbStabil.Location = new System.Drawing.Point(7, 4);
            this.pbStabil.Name = "pbStabil";
            this.pbStabil.Size = new System.Drawing.Size(1152, 700);
            this.pbStabil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStabil.TabIndex = 0;
            this.pbStabil.TabStop = false;
            // 
            // btKembaliStabil
            // 
            this.btKembaliStabil.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btKembaliStabil.FlatAppearance.BorderSize = 0;
            this.btKembaliStabil.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKembaliStabil.Location = new System.Drawing.Point(90, 596);
            this.btKembaliStabil.Name = "btKembaliStabil";
            this.btKembaliStabil.Size = new System.Drawing.Size(184, 52);
            this.btKembaliStabil.TabIndex = 15;
            this.btKembaliStabil.Text = "Kembali";
            this.btKembaliStabil.UseVisualStyleBackColor = false;
            this.btKembaliStabil.Click += new System.EventHandler(this.btKembaliStabil_Click);
            // 
            // lblStabil
            // 
            this.lblStabil.AutoSize = true;
            this.lblStabil.BackColor = System.Drawing.Color.White;
            this.lblStabil.Font = new System.Drawing.Font("Futura Md BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStabil.Location = new System.Drawing.Point(87, 201);
            this.lblStabil.Name = "lblStabil";
            this.lblStabil.Size = new System.Drawing.Size(753, 240);
            this.lblStabil.TabIndex = 14;
            this.lblStabil.Text = resources.GetString("lblStabil.Text");
            // 
            // lanjutStabil
            // 
            this.lanjutStabil.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lanjutStabil.FlatAppearance.BorderSize = 0;
            this.lanjutStabil.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lanjutStabil.Location = new System.Drawing.Point(292, 596);
            this.lanjutStabil.Name = "lanjutStabil";
            this.lanjutStabil.Size = new System.Drawing.Size(184, 52);
            this.lanjutStabil.TabIndex = 16;
            this.lanjutStabil.Text = "Lanjut";
            this.lanjutStabil.UseVisualStyleBackColor = false;
            this.lanjutStabil.Click += new System.EventHandler(this.lanjutStabil_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(7, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 700);
            this.panel1.TabIndex = 17;
            // 
            // StabilBerat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 708);
            this.Controls.Add(this.lanjutStabil);
            this.Controls.Add(this.btKembaliStabil);
            this.Controls.Add(this.lblStabil);
            this.Controls.Add(this.pbStabil);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StabilBerat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menstabilkan Berat Badan";
            ((System.ComponentModel.ISupportInitialize)(this.pbStabil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbStabil;
        private System.Windows.Forms.Button btKembaliStabil;
        private System.Windows.Forms.Label lblStabil;
        private System.Windows.Forms.Button lanjutStabil;
        private System.Windows.Forms.Panel panel1;
    }
}