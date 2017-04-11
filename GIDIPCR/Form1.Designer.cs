namespace GIDIPCR
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnXuLie = new System.Windows.Forms.Button();
            this.btnFanXuLie = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnXuLie
            // 
            this.btnXuLie.Location = new System.Drawing.Point(36, 50);
            this.btnXuLie.Name = "btnXuLie";
            this.btnXuLie.Size = new System.Drawing.Size(75, 23);
            this.btnXuLie.TabIndex = 0;
            this.btnXuLie.Text = "序列化";
            this.btnXuLie.UseVisualStyleBackColor = true;
            this.btnXuLie.Click += new System.EventHandler(this.btnXuLie_Click);
            // 
            // btnFanXuLie
            // 
            this.btnFanXuLie.Location = new System.Drawing.Point(36, 100);
            this.btnFanXuLie.Name = "btnFanXuLie";
            this.btnFanXuLie.Size = new System.Drawing.Size(75, 23);
            this.btnFanXuLie.TabIndex = 1;
            this.btnFanXuLie.Text = "反序列化";
            this.btnFanXuLie.UseVisualStyleBackColor = true;
            this.btnFanXuLie.Click += new System.EventHandler(this.btnFanXuLie_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(265, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(354, 280);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 307);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnFanXuLie);
            this.Controls.Add(this.btnXuLie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXuLie;
        private System.Windows.Forms.Button btnFanXuLie;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

