namespace CheckMD5
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxshow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRoad = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "MD5值";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "选择文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxshow
            // 
            this.textBoxshow.Location = new System.Drawing.Point(71, 79);
            this.textBoxshow.Name = "textBoxshow";
            this.textBoxshow.Size = new System.Drawing.Size(437, 21);
            this.textBoxshow.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "文件路径";
            // 
            // textBoxRoad
            // 
            this.textBoxRoad.Location = new System.Drawing.Point(71, 28);
            this.textBoxRoad.Name = "textBoxRoad";
            this.textBoxRoad.Size = new System.Drawing.Size(437, 21);
            this.textBoxRoad.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(525, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 21);
            this.button2.TabIndex = 6;
            this.button2.Text = "确定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 125);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxRoad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxshow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "CheckMD5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxshow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRoad;
        private System.Windows.Forms.Button button2;

    }
}

