namespace Admin
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.book = new System.Windows.Forms.TabControl();
            this.bookin = new System.Windows.Forms.TabPage();
            this.schbk = new System.Windows.Forms.TabPage();
            this.schrd = new System.Windows.Forms.TabPage();
            this.person = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uid = new System.Windows.Forms.Label();
            this.book.SuspendLayout();
            this.person.SuspendLayout();
            this.SuspendLayout();
            // 
            // book
            // 
            this.book.Controls.Add(this.bookin);
            this.book.Controls.Add(this.schbk);
            this.book.Controls.Add(this.schrd);
            this.book.Controls.Add(this.person);
            this.book.Location = new System.Drawing.Point(14, 12);
            this.book.Name = "book";
            this.book.SelectedIndex = 0;
            this.book.Size = new System.Drawing.Size(662, 451);
            this.book.TabIndex = 0;
            // 
            // bookin
            // 
            this.bookin.Location = new System.Drawing.Point(4, 22);
            this.bookin.Name = "bookin";
            this.bookin.Padding = new System.Windows.Forms.Padding(3);
            this.bookin.Size = new System.Drawing.Size(654, 425);
            this.bookin.TabIndex = 0;
            this.bookin.Text = "图书录入";
            this.bookin.UseVisualStyleBackColor = true;
            // 
            // schbk
            // 
            this.schbk.Location = new System.Drawing.Point(4, 22);
            this.schbk.Name = "schbk";
            this.schbk.Padding = new System.Windows.Forms.Padding(3);
            this.schbk.Size = new System.Drawing.Size(654, 425);
            this.schbk.TabIndex = 2;
            this.schbk.Text = "图书查询";
            this.schbk.UseVisualStyleBackColor = true;
            // 
            // schrd
            // 
            this.schrd.Location = new System.Drawing.Point(4, 22);
            this.schrd.Name = "schrd";
            this.schrd.Padding = new System.Windows.Forms.Padding(3);
            this.schrd.Size = new System.Drawing.Size(654, 425);
            this.schrd.TabIndex = 3;
            this.schrd.Text = "读者查询";
            this.schrd.UseVisualStyleBackColor = true;
            // 
            // person
            // 
            this.person.Controls.Add(this.uid);
            this.person.Controls.Add(this.label3);
            this.person.Controls.Add(this.label2);
            this.person.Controls.Add(this.label1);
            this.person.Location = new System.Drawing.Point(4, 22);
            this.person.Name = "person";
            this.person.Padding = new System.Windows.Forms.Padding(3);
            this.person.Size = new System.Drawing.Size(654, 425);
            this.person.TabIndex = 4;
            this.person.Text = "个人管理";
            this.person.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码：";
            // 
            // uid
            // 
            this.uid.AutoSize = true;
            this.uid.Location = new System.Drawing.Point(209, 79);
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(23, 12);
            this.uid.TabIndex = 3;
            this.uid.Text = "uid";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 470);
            this.Controls.Add(this.book);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "古籍图书管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.book.ResumeLayout(false);
            this.person.ResumeLayout(false);
            this.person.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl book;
        private System.Windows.Forms.TabPage bookin;
        private System.Windows.Forms.TabPage schbk;
        private System.Windows.Forms.TabPage schrd;
        private System.Windows.Forms.TabPage person;
        private System.Windows.Forms.Label uid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

