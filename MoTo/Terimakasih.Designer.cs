namespace MoTo
{
    partial class Terimakasih
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Terimakasih));
            this.pbTerimakasih = new System.Windows.Forms.PictureBox();
            this.btBeranda = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbTerimakasih)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTerimakasih
            // 
            this.pbTerimakasih.Image = ((System.Drawing.Image)(resources.GetObject("pbTerimakasih.Image")));
            this.pbTerimakasih.Location = new System.Drawing.Point(5, 4);
            this.pbTerimakasih.Name = "pbTerimakasih";
            this.pbTerimakasih.Size = new System.Drawing.Size(1152, 700);
            this.pbTerimakasih.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTerimakasih.TabIndex = 0;
            this.pbTerimakasih.TabStop = false;
            // 
            // btBeranda
            // 
            this.btBeranda.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btBeranda.FlatAppearance.BorderSize = 0;
            this.btBeranda.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBeranda.Location = new System.Drawing.Point(904, 558);
            this.btBeranda.Name = "btBeranda";
            this.btBeranda.Size = new System.Drawing.Size(183, 57);
            this.btBeranda.TabIndex = 1;
            this.btBeranda.Text = "Beranda";
            this.btBeranda.UseVisualStyleBackColor = false;
            this.btBeranda.Click += new System.EventHandler(this.btBeranda_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 700);
            this.panel1.TabIndex = 2;
            // 
            // Terimakasih
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 708);
            this.Controls.Add(this.btBeranda);
            this.Controls.Add(this.pbTerimakasih);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Terimakasih";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terimakasih";
            ((System.ComponentModel.ISupportInitialize)(this.pbTerimakasih)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTerimakasih;
        private System.Windows.Forms.Button btBeranda;
        private System.Windows.Forms.Panel panel1;
    }
}