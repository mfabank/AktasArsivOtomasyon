namespace AktaslarArsiv
{
    partial class login_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_screen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.admin_radio = new System.Windows.Forms.RadioButton();
            this.calisan_radio = new System.Windows.Forms.RadioButton();
            this.entry_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pass_text = new System.Windows.Forms.TextBox();
            this.kadi_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // admin_radio
            // 
            this.admin_radio.AutoSize = true;
            this.admin_radio.Location = new System.Drawing.Point(470, 252);
            this.admin_radio.Name = "admin_radio";
            this.admin_radio.Size = new System.Drawing.Size(63, 17);
            this.admin_radio.TabIndex = 1;
            this.admin_radio.TabStop = true;
            this.admin_radio.Text = "Yönetici";
            this.admin_radio.UseVisualStyleBackColor = true;
            // 
            // calisan_radio
            // 
            this.calisan_radio.AutoSize = true;
            this.calisan_radio.Location = new System.Drawing.Point(470, 275);
            this.calisan_radio.Name = "calisan_radio";
            this.calisan_radio.Size = new System.Drawing.Size(59, 17);
            this.calisan_radio.TabIndex = 2;
            this.calisan_radio.TabStop = true;
            this.calisan_radio.Text = "Çalışan";
            this.calisan_radio.UseVisualStyleBackColor = true;
            // 
            // entry_btn
            // 
            this.entry_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.entry_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.entry_btn.Location = new System.Drawing.Point(343, 259);
            this.entry_btn.Name = "entry_btn";
            this.entry_btn.Size = new System.Drawing.Size(92, 33);
            this.entry_btn.TabIndex = 3;
            this.entry_btn.Text = "Giriş";
            this.entry_btn.UseVisualStyleBackColor = false;
            this.entry_btn.Click += new System.EventHandler(this.entry_btn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(325, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 1);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(328, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giriş Ekranı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parola";
            // 
            // pass_text
            // 
            this.pass_text.Location = new System.Drawing.Point(328, 191);
            this.pass_text.Name = "pass_text";
            this.pass_text.Size = new System.Drawing.Size(142, 20);
            this.pass_text.TabIndex = 8;
            // 
            // kadi_text
            // 
            this.kadi_text.Location = new System.Drawing.Point(328, 109);
            this.kadi_text.Name = "kadi_text";
            this.kadi_text.Size = new System.Drawing.Size(142, 20);
            this.kadi_text.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(576, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label5_MouseMove);
            // 
            // login_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kadi_text);
            this.Controls.Add(this.pass_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entry_btn);
            this.Controls.Add(this.calisan_radio);
            this.Controls.Add(this.admin_radio);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_screen_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.login_screen_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.login_screen_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton admin_radio;
        private System.Windows.Forms.RadioButton calisan_radio;
        private System.Windows.Forms.Button entry_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pass_text;
        private System.Windows.Forms.TextBox kadi_text;
        private System.Windows.Forms.Label label5;
    }
}