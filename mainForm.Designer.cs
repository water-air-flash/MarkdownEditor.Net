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
            this.@__contextMenu2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.@__appButton = new System.Windows.Forms.ToolStripButton();
            this.@__newButton = new System.Windows.Forms.ToolStripSplitButton();
            this.@__saveButton = new System.Windows.Forms.ToolStripSplitButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.@__webBrowser = new System.Windows.Forms.WebBrowser();
            this.linkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.@__listButton = new System.Windows.Forms.ToolStripSplitButton();
            this.numberListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bulletListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.@__viewButton = new System.Windows.Forms.ToolStripSplitButton();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.@__contextMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.@__contextMenu2.SuspendLayout();
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
            this.splitContainer2.Panel2Collapsed = true;
            this.splitContainer2.Size = new System.Drawing.Size(895, 500);
            this.splitContainer2.SplitterDistance = 509;
            this.splitContainer2.TabIndex = 0;
            // 
            // __textBox
            // 
            this.@__textBox.ContextMenuStrip = this.@__contextMenu2;
            this.@__textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.@__textBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.@__textBox.Location = new System.Drawing.Point(0, 50);
            this.@__textBox.Multiline = true;
            this.@__textBox.Name = "__textBox";
            this.@__textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.@__textBox.Size = new System.Drawing.Size(895, 428);
            this.@__textBox.TabIndex = 3;
            this.@__textBox.TextChanged += new System.EventHandler(this.@__textBox_TextChanged);
            // 
            // __contextMenu2
            // 
            this.@__contextMenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.toolStripSeparator1,
            this.codeToolStripMenuItem,
            this.linkToolStripMenuItem,
            this.headToolStripMenuItem,
            this.toolStripSeparator2,
            this.translateToolStripMenuItem});
            this.@__contextMenu2.Name = "contextMenuStrip1";
            this.@__contextMenu2.Size = new System.Drawing.Size(197, 170);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.codeToolStripMenuItem.Text = "Code";
            this.codeToolStripMenuItem.Click += new System.EventHandler(this.codeToolStripMenuItem_Click);
            // 
            // headToolStripMenuItem
            // 
            this.headToolStripMenuItem.Name = "headToolStripMenuItem";
            this.headToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.headToolStripMenuItem.Text = "Head";
            this.headToolStripMenuItem.Click += new System.EventHandler(this.headToolStripMenuItem_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(895, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.@__appButton,
            this.@__newButton,
            this.@__saveButton,
            this.@__listButton,
            this.@__viewButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(895, 25);
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
            // __newButton
            // 
            this.@__newButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.@__newButton.Image = ((System.Drawing.Image)(resources.GetObject("__newButton.Image")));
            this.@__newButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.@__newButton.Name = "__newButton";
            this.@__newButton.Size = new System.Drawing.Size(50, 22);
            this.@__newButton.Text = "New";
            this.@__newButton.ButtonClick += new System.EventHandler(this.@__newButton_ButtonClick);
            // 
            // __saveButton
            // 
            this.@__saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.@__saveButton.Image = ((System.Drawing.Image)(resources.GetObject("__saveButton.Image")));
            this.@__saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.@__saveButton.Name = "__saveButton";
            this.@__saveButton.Size = new System.Drawing.Size(51, 22);
            this.@__saveButton.Text = "Save";
            this.@__saveButton.ButtonClick += new System.EventHandler(this.@__saveButton_ButtonClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(895, 22);
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
            // linkToolStripMenuItem
            // 
            this.linkToolStripMenuItem.Name = "linkToolStripMenuItem";
            this.linkToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.linkToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.linkToolStripMenuItem.Text = "Link";
            this.linkToolStripMenuItem.Click += new System.EventHandler(this.linkToolStripMenuItem_Click);
            // 
            // translateToolStripMenuItem
            // 
            this.translateToolStripMenuItem.Name = "translateToolStripMenuItem";
            this.translateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Space)));
            this.translateToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.translateToolStripMenuItem.Text = "Translate";
            this.translateToolStripMenuItem.Click += new System.EventHandler(this.translateToolStripMenuItem_Click);
            // 
            // __listButton
            // 
            this.@__listButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.@__listButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberListToolStripMenuItem1,
            this.bulletListToolStripMenuItem});
            this.@__listButton.Image = ((System.Drawing.Image)(resources.GetObject("__listButton.Image")));
            this.@__listButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.@__listButton.Name = "__listButton";
            this.@__listButton.Size = new System.Drawing.Size(43, 22);
            this.@__listButton.Text = "List";
            // 
            // numberListToolStripMenuItem1
            // 
            this.numberListToolStripMenuItem1.Name = "numberListToolStripMenuItem1";
            this.numberListToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.numberListToolStripMenuItem1.Text = "Number List";
            this.numberListToolStripMenuItem1.Click += new System.EventHandler(this.numberListToolStripMenuItem1_Click);
            // 
            // bulletListToolStripMenuItem
            // 
            this.bulletListToolStripMenuItem.Name = "bulletListToolStripMenuItem";
            this.bulletListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bulletListToolStripMenuItem.Text = "Bullet List";
            this.bulletListToolStripMenuItem.Click += new System.EventHandler(this.bulletListToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(193, 6);
            // 
            // __viewButton
            // 
            this.@__viewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.@__viewButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previewToolStripMenuItem});
            this.@__viewButton.Image = ((System.Drawing.Image)(resources.GetObject("__viewButton.Image")));
            this.@__viewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.@__viewButton.Name = "__viewButton";
            this.@__viewButton.Size = new System.Drawing.Size(51, 22);
            this.@__viewButton.Text = "View";
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.CheckOnClick = true;
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.previewToolStripMenuItem.Text = "Preview";
            this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click);
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
            this.@__contextMenu2.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripSplitButton __saveButton;
        private System.Windows.Forms.ContextMenuStrip __contextMenu2;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton __newButton;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton __listButton;
        private System.Windows.Forms.ToolStripMenuItem numberListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bulletListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton __viewButton;
        private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
    }
}

