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
            this.@__listBox = new System.Windows.Forms.ListBox();
            this.@__fileBox = new System.Windows.Forms.ComboBox();
            this.@__contextMenu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.@__textBox = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.@__appButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.@__webBrowser = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.@__contextMenu1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.@__listBox);
            this.splitContainer1.Panel1.Controls.Add(this.@__fileBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1106, 500);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 0;
            // 
            // __listBox
            // 
            this.@__listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.@__listBox.FormattingEnabled = true;
            this.@__listBox.ItemHeight = 12;
            this.@__listBox.Location = new System.Drawing.Point(0, 20);
            this.@__listBox.Name = "__listBox";
            this.@__listBox.Size = new System.Drawing.Size(207, 480);
            this.@__listBox.TabIndex = 1;
            this.@__listBox.SelectedIndexChanged += new System.EventHandler(this.@__listBox_SelectedIndexChanged);
            // 
            // __fileBox
            // 
            this.@__fileBox.ContextMenuStrip = this.@__contextMenu1;
            this.@__fileBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.@__fileBox.FormattingEnabled = true;
            this.@__fileBox.Location = new System.Drawing.Point(0, 0);
            this.@__fileBox.Name = "__fileBox";
            this.@__fileBox.Size = new System.Drawing.Size(207, 20);
            this.@__fileBox.TabIndex = 0;
            this.@__fileBox.SelectedIndexChanged += new System.EventHandler(this.@__fileBox_SelectedIndexChanged);
            // 
            // __contextMenu1
            // 
            this.@__contextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem});
            this.@__contextMenu1.Name = "__contextMenu1";
            this.@__contextMenu1.Size = new System.Drawing.Size(115, 26);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
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
            this.splitContainer2.Size = new System.Drawing.Size(895, 500);
            this.splitContainer2.SplitterDistance = 509;
            this.splitContainer2.TabIndex = 0;
            // 
            // __textBox
            // 
            this.@__textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.@__textBox.Location = new System.Drawing.Point(0, 50);
            this.@__textBox.Multiline = true;
            this.@__textBox.Name = "__textBox";
            this.@__textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.@__textBox.Size = new System.Drawing.Size(509, 428);
            this.@__textBox.TabIndex = 3;
            this.@__textBox.TextChanged += new System.EventHandler(this.@__textBox_TextChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(509, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.@__appButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(509, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
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
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(509, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // __webBrowser
            // 
            this.@__webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.@__webBrowser.Location = new System.Drawing.Point(0, 0);
            this.@__webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.@__webBrowser.Name = "__webBrowser";
            this.@__webBrowser.Size = new System.Drawing.Size(382, 500);
            this.@__webBrowser.TabIndex = 0;
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
            this.@__contextMenu1.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox __listBox;
        private System.Windows.Forms.ComboBox __fileBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox __textBox;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.WebBrowser __webBrowser;
        private System.Windows.Forms.ToolStripButton __appButton;
        private System.Windows.Forms.ContextMenuStrip __contextMenu1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
    }
}

