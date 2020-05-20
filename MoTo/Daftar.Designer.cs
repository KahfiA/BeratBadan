namespace MoTo
{
    partial class Daftar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Daftar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNoHp = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btdaftar = new System.Windows.Forms.Button();
            this.btKembaliDaftar = new System.Windows.Forms.Button();
            this.rbPria = new System.Windows.Forms.RadioButton();
            this.rbWanita = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1147, 694);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "No Hp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nama Lengkap";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(257, 155);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(241, 28);
            this.tbUsername.TabIndex = 7;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(257, 358);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(241, 28);
            this.tbEmail.TabIndex = 8;
            // 
            // tbNoHp
            // 
            this.tbNoHp.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoHp.Location = new System.Drawing.Point(257, 307);
            this.tbNoHp.Name = "tbNoHp";
            this.tbNoHp.Size = new System.Drawing.Size(241, 28);
            this.tbNoHp.TabIndex = 9;
            // 
            // tbNama
            // 
            this.tbNama.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.Location = new System.Drawing.Point(257, 255);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(241, 28);
            this.tbNama.TabIndex = 10;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(257, 202);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(241, 28);
            this.tbPassword.TabIndex = 11;
            // 
            // btdaftar
            // 
            this.btdaftar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btdaftar.FlatAppearance.BorderSize = 0;
            this.btdaftar.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdaftar.Location = new System.Drawing.Point(314, 519);
            this.btdaftar.Name = "btdaftar";
            this.btdaftar.Size = new System.Drawing.Size(184, 52);
            this.btdaftar.TabIndex = 23;
            this.btdaftar.Text = "Daftar";
            this.btdaftar.UseVisualStyleBackColor = false;
            this.btdaftar.Click += new System.EventHandler(this.btdaftar_Click);
            // 
            // btKembaliDaftar
            // 
            this.btKembaliDaftar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btKembaliDaftar.FlatAppearance.BorderSize = 0;
            this.btKembaliDaftar.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKembaliDaftar.Location = new System.Drawing.Point(81, 519);
            this.btKembaliDaftar.Name = "btKembaliDaftar";
            this.btKembaliDaftar.Size = new System.Drawing.Size(184, 52);
            this.btKembaliDaftar.TabIndex = 22;
            this.btKembaliDaftar.Text = "Kembali";
            this.btKembaliDaftar.UseVisualStyleBackColor = false;
            this.btKembaliDaftar.Click += new System.EventHandler(this.btKembaliDaftar_Click);
            // 
            // rbPria
            // 
            this.rbPria.AutoSize = true;
            this.rbPria.BackColor = System.Drawing.Color.White;
            this.rbPria.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPria.Location = new System.Drawing.Point(257, 416);
            this.rbPria.Name = "rbPria";
            this.rbPria.Size = new System.Drawing.Size(59, 24);
            this.rbPria.TabIndex = 24;
            this.rbPria.TabStop = true;
            this.rbPria.Text = "Pria";
            this.rbPria.UseVisualStyleBackColor = false;
            this.rbPria.CheckedChanged += new System.EventHandler(this.rbPria_CheckedChanged);
            // 
            // rbWanita
            // 
            this.rbWanita.AutoSize = true;
            this.rbWanita.BackColor = System.Drawing.Color.White;
            this.rbWanita.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWanita.Location = new System.Drawing.Point(388, 416);
            this.rbWanita.Name = "rbWanita";
            this.rbWanita.Size = new System.Drawing.Size(85, 24);
            this.rbWanita.TabIndex = 25;
            this.rbWanita.TabStop = true;
            this.rbWanita.Text = "Wanita";
            this.rbWanita.UseVisualStyleBackColor = false;
            this.rbWanita.CheckedChanged += new System.EventHandler(this.rbWanita_CheckedChanged);
            // 
            // Daftar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 708);
            this.Controls.Add(this.rbWanita);
            this.Controls.Add(this.rbPria);
            this.Controls.Add(this.btdaftar);
            this.Controls.Add(this.btKembaliDaftar);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbNoHp);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Daftar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbNoHp;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btdaftar;
        private System.Windows.Forms.Button btKembaliDaftar;
        private System.Windows.Forms.RadioButton rbPria;
        private System.Windows.Forms.RadioButton rbWanita;
    }
}