namespace MoTo
{
    partial class LowImpact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LowImpact));
            this.pbLowImpact = new System.Windows.Forms.PictureBox();
            this.lblLowImpact = new System.Windows.Forms.Label();
            this.btKembaliLow = new System.Windows.Forms.Button();
            this.btVideoLowImpact = new System.Windows.Forms.Button();
            this.btKapanLow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLowImpact)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLowImpact
            // 
            this.pbLowImpact.Image = ((System.Drawing.Image)(resources.GetObject("pbLowImpact.Image")));
            this.pbLowImpact.Location = new System.Drawing.Point(3, 4);
            this.pbLowImpact.Name = "pbLowImpact";
            this.pbLowImpact.Size = new System.Drawing.Size(1152, 700);
            this.pbLowImpact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLowImpact.TabIndex = 0;
            this.pbLowImpact.TabStop = false;
            // 
            // lblLowImpact
            // 
            this.lblLowImpact.AutoSize = true;
            this.lblLowImpact.BackColor = System.Drawing.Color.White;
            this.lblLowImpact.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowImpact.Location = new System.Drawing.Point(83, 224);
            this.lblLowImpact.Name = "lblLowImpact";
            this.lblLowImpact.Size = new System.Drawing.Size(919, 60);
            this.lblLowImpact.TabIndex = 1;
            this.lblLowImpact.Text = resources.GetString("lblLowImpact.Text");
            // 
            // btKembaliLow
            // 
            this.btKembaliLow.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btKembaliLow.FlatAppearance.BorderSize = 0;
            this.btKembaliLow.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKembaliLow.Location = new System.Drawing.Point(913, 520);
            this.btKembaliLow.Name = "btKembaliLow";
            this.btKembaliLow.Size = new System.Drawing.Size(147, 42);
            this.btKembaliLow.TabIndex = 7;
            this.btKembaliLow.Text = "Kembali";
            this.btKembaliLow.UseVisualStyleBackColor = false;
            this.btKembaliLow.Click += new System.EventHandler(this.btKembaliLow_Click);
            // 
            // btVideoLowImpact
            // 
            this.btVideoLowImpact.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btVideoLowImpact.FlatAppearance.BorderSize = 0;
            this.btVideoLowImpact.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVideoLowImpact.Location = new System.Drawing.Point(87, 387);
            this.btVideoLowImpact.Name = "btVideoLowImpact";
            this.btVideoLowImpact.Size = new System.Drawing.Size(372, 50);
            this.btVideoLowImpact.TabIndex = 6;
            this.btVideoLowImpact.Text = "Olahraga Low Impact";
            this.btVideoLowImpact.UseVisualStyleBackColor = false;
            this.btVideoLowImpact.Click += new System.EventHandler(this.btVideoLowImpact_Click);
            // 
            // btKapanLow
            // 
            this.btKapanLow.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btKapanLow.FlatAppearance.BorderSize = 0;
            this.btKapanLow.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKapanLow.Location = new System.Drawing.Point(87, 327);
            this.btKapanLow.Name = "btKapanLow";
            this.btKapanLow.Size = new System.Drawing.Size(372, 50);
            this.btKapanLow.TabIndex = 5;
            this.btKapanLow.Text = "Kapan Low Impact dilakukan ?";
            this.btKapanLow.UseVisualStyleBackColor = false;
            this.btKapanLow.Click += new System.EventHandler(this.btKapanLow_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 700);
            this.panel1.TabIndex = 8;
            // 
            // LowImpact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 708);
            this.Controls.Add(this.btKembaliLow);
            this.Controls.Add(this.btVideoLowImpact);
            this.Controls.Add(this.btKapanLow);
            this.Controls.Add(this.lblLowImpact);
            this.Controls.Add(this.pbLowImpact);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LowImpact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Low Impact Workout";
            ((System.ComponentModel.ISupportInitialize)(this.pbLowImpact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLowImpact;
        private System.Windows.Forms.Label lblLowImpact;
        private System.Windows.Forms.Button btKembaliLow;
        private System.Windows.Forms.Button btVideoLowImpact;
        private System.Windows.Forms.Button btKapanLow;
        private System.Windows.Forms.Panel panel1;
    }
}