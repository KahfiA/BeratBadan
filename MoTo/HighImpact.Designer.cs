namespace MoTo
{
    partial class HighImpact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighImpact));
            this.lblHighImpact = new System.Windows.Forms.Label();
            this.btKapanHigh = new System.Windows.Forms.Button();
            this.btVideoHighImpact = new System.Windows.Forms.Button();
            this.btKembaliHigh = new System.Windows.Forms.Button();
            this.pbHighImpact = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbHighImpact)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHighImpact
            // 
            this.lblHighImpact.AutoSize = true;
            this.lblHighImpact.BackColor = System.Drawing.Color.White;
            this.lblHighImpact.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighImpact.Location = new System.Drawing.Point(88, 226);
            this.lblHighImpact.Name = "lblHighImpact";
            this.lblHighImpact.Size = new System.Drawing.Size(949, 60);
            this.lblHighImpact.TabIndex = 1;
            this.lblHighImpact.Text = resources.GetString("lblHighImpact.Text");
            // 
            // btKapanHigh
            // 
            this.btKapanHigh.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btKapanHigh.FlatAppearance.BorderSize = 0;
            this.btKapanHigh.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKapanHigh.Location = new System.Drawing.Point(92, 344);
            this.btKapanHigh.Name = "btKapanHigh";
            this.btKapanHigh.Size = new System.Drawing.Size(372, 50);
            this.btKapanHigh.TabIndex = 2;
            this.btKapanHigh.Text = "Kapan High Impact dilakukan ?";
            this.btKapanHigh.UseVisualStyleBackColor = false;
            this.btKapanHigh.Click += new System.EventHandler(this.btKapanHigh_Click);
            // 
            // btVideoHighImpact
            // 
            this.btVideoHighImpact.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btVideoHighImpact.FlatAppearance.BorderSize = 0;
            this.btVideoHighImpact.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVideoHighImpact.Location = new System.Drawing.Point(92, 404);
            this.btVideoHighImpact.Name = "btVideoHighImpact";
            this.btVideoHighImpact.Size = new System.Drawing.Size(372, 50);
            this.btVideoHighImpact.TabIndex = 3;
            this.btVideoHighImpact.Text = "Olahraga High Impact";
            this.btVideoHighImpact.UseVisualStyleBackColor = false;
            this.btVideoHighImpact.Click += new System.EventHandler(this.btVideoHighImpact_Click);
            // 
            // btKembaliHigh
            // 
            this.btKembaliHigh.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btKembaliHigh.FlatAppearance.BorderSize = 0;
            this.btKembaliHigh.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKembaliHigh.Location = new System.Drawing.Point(918, 537);
            this.btKembaliHigh.Name = "btKembaliHigh";
            this.btKembaliHigh.Size = new System.Drawing.Size(147, 42);
            this.btKembaliHigh.TabIndex = 4;
            this.btKembaliHigh.Text = "Kembali";
            this.btKembaliHigh.UseVisualStyleBackColor = false;
            this.btKembaliHigh.Click += new System.EventHandler(this.btKembaliHigh_Click);
            // 
            // pbHighImpact
            // 
            this.pbHighImpact.Image = ((System.Drawing.Image)(resources.GetObject("pbHighImpact.Image")));
            this.pbHighImpact.Location = new System.Drawing.Point(6, 6);
            this.pbHighImpact.Name = "pbHighImpact";
            this.pbHighImpact.Size = new System.Drawing.Size(1152, 700);
            this.pbHighImpact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHighImpact.TabIndex = 0;
            this.pbHighImpact.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 700);
            this.panel1.TabIndex = 5;
            // 
            // HighImpact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 708);
            this.Controls.Add(this.btKembaliHigh);
            this.Controls.Add(this.btVideoHighImpact);
            this.Controls.Add(this.btKapanHigh);
            this.Controls.Add(this.lblHighImpact);
            this.Controls.Add(this.pbHighImpact);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HighImpact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "High Impact Workout";
            ((System.ComponentModel.ISupportInitialize)(this.pbHighImpact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHighImpact;
        private System.Windows.Forms.Label lblHighImpact;
        private System.Windows.Forms.Button btKapanHigh;
        private System.Windows.Forms.Button btVideoHighImpact;
        private System.Windows.Forms.Button btKembaliHigh;
        private System.Windows.Forms.Panel panel1;
    }
}