namespace Admin
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.upwd = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btlogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID：";
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(76, 111);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(69, 21);
            this.uname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码：";
            // 
            // upwd
            // 
            this.upwd.Location = new System.Drawing.Point(200, 111);
            this.upwd.Name = "upwd";
            this.upwd.Size = new System.Drawing.Size(100, 21);
            this.upwd.TabIndex = 4;
            this.upwd.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Admin.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(54, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 86);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btlogin
            // 
            this.btlogin.Location = new System.Drawing.Point(373, 111);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(49, 23);
            this.btlogin.TabIndex = 5;
            this.btlogin.Text = "登陆";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(483, 172);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.upwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.Text = "登陆";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox upwd;
        private System.Windows.Forms.Button btlogin;
    }
}