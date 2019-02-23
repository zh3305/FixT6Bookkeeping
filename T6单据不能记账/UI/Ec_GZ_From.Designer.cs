namespace Ec_Changjie
{
    partial class Ec_GZ_from
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
            this.Bt_About = new Glass.GlassButton();
            this.glassButton1 = new Glass.GlassButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bt_About
            // 
            this.Bt_About.Location = new System.Drawing.Point(146, 1);
            this.Bt_About.Name = "Bt_About";
            this.Bt_About.Size = new System.Drawing.Size(75, 23);
            this.Bt_About.TabIndex = 0;
            this.Bt_About.Text = "关于";
            this.Bt_About.Click += new System.EventHandler(this.Bt_About_Click);
            // 
            // glassButton1
            // 
            this.glassButton1.BackColor = System.Drawing.Color.LightGray;
            this.glassButton1.ForeColor = System.Drawing.Color.Red;
            this.glassButton1.Location = new System.Drawing.Point(19, 1);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.Size = new System.Drawing.Size(75, 23);
            this.glassButton1.TabIndex = 7;
            this.glassButton1.Text = "确定";
            this.glassButton1.Click += new System.EventHandler(this.glassButton1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "是因为存货总账表中IA_Summary数据存在多条\r\n记账中显示未记账，但又不能记账。\r\n删除整个数据库中多余数据保留最小ID，可正常记账";
            // 
            // Ec_GZ_from
            // 
            this.AllowDrag = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 70);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.glassButton1);
            this.Controls.Add(this.Bt_About);
            this.Name = "Ec_GZ_from";
            this.Text = "T6单据不能记账";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Glass.GlassButton Bt_About;
        private Glass.GlassButton glassButton1;
        private System.Windows.Forms.Label label2;

    }
}

