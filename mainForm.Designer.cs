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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.@__viewButton = new System.Windows.Forms.ToolStripSplitButton();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.@__imageButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this._titleButton = new System.Windows.Forms.ToolStripButton();
            this.@__boldButton = new System.Windows.Forms.ToolStripButton();
            this.@__italicButton = new System.Windows.Forms.ToolStripButton();
            this.@__codeButton = new System.Windows.Forms.ToolStripButton();
            this.@__translateButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.@__transTextBox = new System.Windows.Forms.TextBox();
            this.changeNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.@__indentButton = new System.Windows.Forms.ToolStripSplitButton();
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
            this.splitContainer1.Panel1.Controls.Add(this.@__transTextBox);
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
            this.@__listBox.Size = new System.Drawing.Size(207, 358);
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
            this.@__textBox.Location = new System.Drawing.Point(0, 56);
            this.@__textBox.Multiline = true;
            this.@__textBox.Name = "__textBox";
            this.@__textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.@__textBox.Size = new System.Drawing.Size(895, 422);
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
            this.toolStripSeparator2,
            this.translateToolStripMenuItem});
            this.@__contextMenu2.Name = "contextMenuStrip1";
            this.@__contextMenu2.Size = new System.Drawing.Size(174, 148);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.codeToolStripMenuItem.Text = "Code";
            this.codeToolStripMenuItem.Click += new System.EventHandler(this.codeToolStripMenuItem_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(0, 31);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(895, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.@__appButton,
            this.toolStripSeparator4,
            this.@__newButton,
            this.@__saveButton,
            this.toolStripSeparator3,
            this._titleButton,
            this.@__boldButton,
            this.@__italicButton,
            this.@__codeButton,
            this.@__indentButton,
            this.@__listButton,
            this.toolStripSeparator5,
            this.@__imageButton,
            this.toolStripSeparator6,
            this.@__viewButton,
            this.toolStripSeparator7,
            this.@__translateButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(895, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // __appButton
            // 
            this.@__appButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.@__appButton.Image = ((System.Drawing.Image)(resources.GetObject("__appButton.Image")));
            this.@__appButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.@__appButton.Name = "__appButton";
            this.@__appButton.Size = new System.Drawing.Size(36, 28);
            this.@__appButton.Text = "App";
            this.@__appButton.Click += new System.EventHandler(this.@__appButton_Click);
            // 
            // __newButton
            // 
            this.@__newButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.@__newButton.Image = ((System.Drawing.Image)(resources.GetObject("__newButton.Image")));
            this.@__newButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.@__newButton.Name = "__newButton";
            this.@__newButton.Size = new System.Drawing.Size(40, 28);
            this.@__newButton.Text = "New";
            this.@__newButton.ButtonClick += new System.EventHandler(this.@__newButton_ButtonClick);
            // 
            // __saveButton
            // 
            this.@__saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.@__saveButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeNameToolStripMenuItem});
            this.@__saveButton.Image = ((System.Drawing.Image)(resources.GetObject("__saveButton.Image")));
            this.@__saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.@__saveButton.Name = "__saveButton";
            this.@__saveButton.Size = new System.Drawing.Size(40, 28);
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
            this.linkToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.linkToolStripMenuItem.Text = "Link";
            this.linkToolStripMenuItem.Click += new System.EventHandler(this.linkToolStripMenuItem_Click);
            // 
            // translateToolStripMenuItem
            // 
            this.translateToolStripMenuItem.Name = "translateToolStripMenuItem";
            this.translateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.translateToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.translateToolStripMenuItem.Text = "Translate";
            this.translateToolStripMenuItem.Click += new System.EventHandler(this.translateToolStripMenuItem_Click);
            // 
            // __listButton
            // 
            this.@__listButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.@__listButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberListToolStripMenuItem1});
            this.@__listButton.Image = ((System.Drawing.Image)(resources.GetObject("__listButton.Image")));
            this.@__listButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.@__listButton.Name = "__listButton";
            this.@__listButton.Size = new System.Drawing.Size(40, 28);
            this.@__listButton.Text = "List";
            this.@__listButton.ButtonClick += new System.EventHandler(this.@__listButton_ButtonClick);
            // 
            // numberListToolStripMenuItem1
            // 
            this.numberListToolStripMenuItem1.Name = "numberListToolStripMenuItem1";
            this.numberListToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.numberListToolStripMenuItem1.Text = "Number List";
            this.numberListToolStripMenuItem1.Click += new System.EventHandler(this.numberListToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // __viewButton
            // 
            this.@__viewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.@__viewButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previewToolStripMenuItem,
            this.toolStripMenuItem2});
            this.@__viewButton.Image = ((System.Drawing.Image)(resources.GetObject("__viewButton.Image")));
            this.@__viewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.@__viewButton.Name = "__viewButton";
            this.@__viewButton.Size = new System.Drawing.Size(40, 28);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // __imageButton
            // 
            this.@__imageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.@__imageButton.Image = ((System.Drawing.Image)(resources.GetObject("__imageButton.Image")));
            this.@__imageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.@__imageButton.Name = "__imageButton";
            this.@__imageButton.Size = new System.Drawing.Size(28, 28);
            this.@__imageButton.Text = "Image";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // _titleButton
            // 
            this._titleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._titleButton.Image = ((System.Drawing.Image)(resources.GetObject("_titleButton.Image")));
            this._titleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._titleButton.Name = "_titleButton";
            this._titleButton.Size = new System.Drawing.Size(28, 28);
            this._titleButton.Text = "Title";
            this._titleButton.Click += new System.EventHandler(this._titleButton_Click);
            // 
            // __boldButton
            // 
            this.@__boldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.@__boldButton.Image = ((System.Drawing.Image)(resources.GetObject("__boldButton.Image")));
            this.@__boldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.@__boldButton.Name = "__boldButton";
            this.@__boldButton.Size = new System.Drawing.Size(28, 28);
            this.@__boldButton.Text = "Bold";
            this.@__boldButton.Click += new System.EventHandler(this.@__boldButton_Click);
            // 
            // __italicButton
            // 
            this.@__italicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.@__italicButton.Image = ((System.Drawing.Image)(resources.GetObject("__italicButton.Image")));
            this.@__italicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.@__italicButton.Name = "__italicButton";
            this.@__italicButton.Size = new System.Drawing.Size(28, 28);
            this.@__italicButton.Tag = "Italic";
            this.@__italicButton.Click += new System.EventHandler(this.@__italicButton_Click);
            // 
            // __codeButton
            // 
            this.@__codeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.@__codeButton.Image = ((System.Drawing.Image)(resources.GetObject("__codeButton.Image")));
            this.@__codeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.@__codeButton.Name = "__codeButton";
            this.@__codeButton.Size = new System.Drawing.Size(28, 28);
            this.@__codeButton.Text = "Code";
            this.@__codeButton.Click += new System.EventHandler(this.@__codeButton_Click);
            // 
            // __translateButton
            // 
            this.@__translateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.@__translateButton.Image = ((System.Drawing.Image)(resources.GetObject("__translateButton.Image")));
            this.@__translateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.@__translateButton.Name = "__translateButton";
            this.@__translateButton.Size = new System.Drawing.Size(28, 28);
            this.@__translateButton.Text = "Translate";
            this.@__translateButton.Click += new System.EventHandler(this.@__translateButton_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // __transTextBox
            // 
            this.@__transTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.@__transTextBox.Location = new System.Drawing.Point(0, 378);
            this.@__transTextBox.Multiline = true;
            this.@__transTextBox.Name = "__transTextBox";
            this.@__transTextBox.Size = new System.Drawing.Size(207, 122);
            this.@__transTextBox.TabIndex = 2;
            // 
            // changeNameToolStripMenuItem
            // 
            this.changeNameToolStripMenuItem.Name = "changeNameToolStripMenuItem";
            this.changeNameToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.changeNameToolStripMenuItem.Text = "Change Name";
            this.changeNameToolStripMenuItem.Click += new System.EventHandler(this.changeNameToolStripMenuItem_Click);
            // 
            // __indentButton
            // 
            this.@__indentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.@__indentButton.Image = ((System.Drawing.Image)(resources.GetObject("__indentButton.Image")));
            this.@__indentButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.@__indentButton.Name = "__indentButton";
            this.@__indentButton.Size = new System.Drawing.Size(40, 28);
            this.@__indentButton.Text = "Indent";
            this.@__indentButton.ButtonClick += new System.EventHandler(this.@__indentButton_ButtonClick);
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
            this.splitContainer1.Panel1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem linkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton __listButton;
        private System.Windows.Forms.ToolStripMenuItem numberListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton __viewButton;
        private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripButton __imageButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton _titleButton;
        private System.Windows.Forms.ToolStripButton __boldButton;
        private System.Windows.Forms.ToolStripButton __italicButton;
        private System.Windows.Forms.ToolStripButton __codeButton;
        private System.Windows.Forms.ToolStripButton __translateButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.TextBox __transTextBox;
        private System.Windows.Forms.ToolStripMenuItem changeNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton __indentButton;
    }
}

