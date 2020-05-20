namespace MoTo
{
    partial class Olahraga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Olahraga));
            this.pbOr = new System.Windows.Forms.PictureBox();
            this.btOH = new System.Windows.Forms.Button();
            this.btOL = new System.Windows.Forms.Button();
            this.btKembaliOr = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbOr)).BeginInit();
            this.SuspendLayout();
            // 
            // pbOr
            // 
            this.pbOr.Image = ((System.Drawing.Image)(resources.GetObject("pbOr.Image")));
            this.pbOr.Location = new System.Drawing.Point(6, 2);
            this.pbOr.Name = "pbOr";
            this.pbOr.Size = new System.Drawing.Size(1152, 700);
            this.pbOr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOr.TabIndex = 0;
            this.pbOr.TabStop = false;
            // 
            // btOH
            // 
            this.btOH.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btOH.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOH.Location = new System.Drawing.Point(91, 229);
            this.btOH.Name = "btOH";
            this.btOH.Size = new System.Drawing.Size(310, 55);
            this.btOH.TabIndex = 1;
            this.btOH.Text = "Olahraga High Impact";
            this.btOH.UseVisualStyleBackColor = false;
            this.btOH.Click += new System.EventHandler(this.btOH_Click);
            // 
            // btOL
            // 
            this.btOL.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btOL.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOL.Location = new System.Drawing.Point(91, 299);
            this.btOL.Name = "btOL";
            this.btOL.Size = new System.Drawing.Size(310, 55);
            this.btOL.TabIndex = 3;
            this.btOL.Text = "Olahraga Low Impact";
            this.btOL.UseVisualStyleBackColor = false;
            this.btOL.Click += new System.EventHandler(this.btOL_Click);
            // 
            // btKembaliOr
            // 
            this.btKembaliOr.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btKembaliOr.FlatAppearance.BorderSize = 0;
            this.btKembaliOr.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKembaliOr.Location = new System.Drawing.Point(884, 510);
            this.btKembaliOr.Name = "btKembaliOr";
            this.btKembaliOr.Size = new System.Drawing.Size(184, 52);
            this.btKembaliOr.TabIndex = 16;
            this.btKembaliOr.Text = "Kembali";
            this.btKembaliOr.UseVisualStyleBackColor = false;
            this.btKembaliOr.Click += new System.EventHandler(this.btKembaliOr_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 700);
            this.panel1.TabIndex = 17;
            // 
            // Olahraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 708);
            this.Controls.Add(this.btKembaliOr);
            this.Controls.Add(this.btOL);
            this.Controls.Add(this.btOH);
            this.Controls.Add(this.pbOr);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Olahraga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olahraga di rumah";
            ((System.ComponentModel.ISupportInitialize)(this.pbOr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOr;
        private System.Windows.Forms.Button btOH;
        private System.Windows.Forms.Button btOL;
        private System.Windows.Forms.Button btKembaliOr;
        private System.Windows.Forms.Panel panel1;
    }
}