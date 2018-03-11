namespace WindowsFormsTest
{
    partial class MainForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.butTestFX = new System.Windows.Forms.Button();
            this.butTestQ = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.butTestFX);
            this.flowLayoutPanel1.Controls.Add(this.butTestQ);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 21);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 110);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // butTestFX
            // 
            this.butTestFX.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butTestFX.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butTestFX.Location = new System.Drawing.Point(5, 5);
            this.butTestFX.Margin = new System.Windows.Forms.Padding(5);
            this.butTestFX.Name = "butTestFX";
            this.butTestFX.Size = new System.Drawing.Size(110, 100);
            this.butTestFX.TabIndex = 0;
            this.butTestFX.Text = "Test FX";
            this.butTestFX.UseVisualStyleBackColor = false;
            this.butTestFX.Click += new System.EventHandler(this.butTestFX_Click);
            // 
            // butTestQ
            // 
            this.butTestQ.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butTestQ.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butTestQ.Location = new System.Drawing.Point(125, 5);
            this.butTestQ.Margin = new System.Windows.Forms.Padding(5);
            this.butTestQ.Name = "butTestQ";
            this.butTestQ.Size = new System.Drawing.Size(110, 100);
            this.butTestQ.TabIndex = 1;
            this.butTestQ.Text = "Test Q";
            this.butTestQ.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("宋体", 14.5F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "三菱PLC通讯测试";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button butTestFX;
        private System.Windows.Forms.Button butTestQ;
    }
}

