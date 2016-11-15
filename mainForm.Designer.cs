namespace MarkdownEditor.Net
{
    partial class __mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(@__mainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.@__textBox = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.@__webBrowser = new System.Windows.Forms.WebBrowser();
            this.@__appButton = new System.Windows.Forms.ToolStripButton();
            this.@__contextMenu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1106, 500);
            this.splitContainer1.SplitterDistance = 304;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(0, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(304, 480);
            this.listBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(304, 20);
            this.comboBox1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.@__textBox);
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip2);
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer2.Panel1.Controls.Add(this.statusStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.@__webBrowser);
            this.splitContainer2.Size = new System.Drawing.Size(798, 500);
            this.splitContainer2.SplitterDistance = 454;
            this.splitContainer2.TabIndex = 0;
            // 
            // __textBox
            // 
            this.@__textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.@__textBox.Location = new System.Drawing.Point(0, 50);
            this.@__textBox.Multiline = true;
            this.@__textBox.Name = "__textBox";
            this.@__textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.@__textBox.Size = new System.Drawing.Size(454, 428);
            this.@__textBox.TabIndex = 3;
            this.@__textBox.TextChanged += new System.EventHandler(this.@__textBox_TextChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(454, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.@__appButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(454, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(454, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // __webBrowser
            // 
            this.@__webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.@__webBrowser.Location = new System.Drawing.Point(0, 0);
            this.@__webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.@__webBrowser.Name = "__webBrowser";
            this.@__webBrowser.Size = new System.Drawing.Size(340, 500);
            this.@__webBrowser.TabIndex = 0;
            // 
            // __appButton
            // 
            this.@__appButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.@__appButton.Image = ((System.Drawing.Image)(resources.GetObject("__appButton.Image")));
            this.@__appButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.@__appButton.Name = "__appButton";
            this.@__appButton.Size = new System.Drawing.Size(36, 22);
            this.@__appButton.Text = "App";
            this.@__appButton.Click += new System.EventHandler(this.@__appButton_Click);
            // 
            // __contextMenu1
            // 
            this.@__contextMenu1.Name = "__contextMenu1";
            this.@__contextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // __mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 500);
            this.Controls.Add(this.splitContainer1);
            this.Name = "__mainForm";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox __textBox;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.WebBrowser __webBrowser;
        private System.Windows.Forms.ToolStripButton __appButton;
        private System.Windows.Forms.ContextMenuStrip __contextMenu1;
    }
}

