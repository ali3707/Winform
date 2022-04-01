namespace Winform
{
    partial class ButtonAndViewer
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleLable1 = new System.Windows.Forms.Label();
            this.btnEvent1 = new System.Windows.Forms.Button();
            this.iOValue1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // titleLable1
            // 
            this.titleLable1.AutoSize = true;
            this.titleLable1.Location = new System.Drawing.Point(148, 106);
            this.titleLable1.Name = "titleLable1";
            this.titleLable1.Size = new System.Drawing.Size(55, 15);
            this.titleLable1.TabIndex = 0;
            this.titleLable1.Text = "label1";
            // 
            // btnEvent1
            // 
            this.btnEvent1.Location = new System.Drawing.Point(151, 158);
            this.btnEvent1.Name = "btnEvent1";
            this.btnEvent1.Size = new System.Drawing.Size(75, 23);
            this.btnEvent1.TabIndex = 1;
            this.btnEvent1.Text = "button1";
            this.btnEvent1.UseVisualStyleBackColor = true;
            this.btnEvent1.Click += new System.EventHandler(this.btnEvent1_Click);
            // 
            // iOValue1
            // 
            this.iOValue1.Location = new System.Drawing.Point(151, 214);
            this.iOValue1.Name = "iOValue1";
            this.iOValue1.Size = new System.Drawing.Size(100, 25);
            this.iOValue1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
          //  this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ButtonAndViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iOValue1);
            this.Controls.Add(this.btnEvent1);
            this.Controls.Add(this.titleLable1);
            this.Name = "ButtonAndViewer";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLable1;
        private System.Windows.Forms.Button btnEvent1;
        private System.Windows.Forms.TextBox iOValue1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
