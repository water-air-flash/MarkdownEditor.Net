using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Web.Script.Serialization;
using Markdig;

namespace MarkdownEditor.Net
{
    public partial class __mainForm : Form
    {
        #region Fields
        const string _template = "<!DOCTYPE html>\n<html>\n<head>\n <title></title>\n <meta charset=\"utf-8\" />\n <link href=\"{0}\" rel=\"stylesheet\" />\n</head><body>\r\n\r\n\r\n";
        readonly string _appPath;

        MarkdownPipeline _pipeline;

        string _currentKey;
        bool _previewEnable;
        Dictionary<string, string> _dic;
        #endregion

        public __mainForm()
        {
            InitializeComponent();
            _appPath = "datas".GetApplicationPath();
            
            Initialize();
        }


        #region Methods
        private void Initialize()
        {
           
            _appPath.CreateDirectoryIfNotExist();
            RefreshFileBox();
            #region MarkDig

            _pipeline = new MarkdownPipelineBuilder().UseAutoLinks().UsePipeTables().UseAutoIdentifiers().Build();

            #endregion
            #region WebBrowser
            NativeMethods.CoInternetSetFeatureEnabled(NativeMethods.FEATURE_DISABLE_NAVIGATION_SOUNDS, NativeMethods.SET_FEATURE_ON_PROCESS, true);
            __webBrowser.ScriptErrorsSuppressed = true;
            #endregion

        }

        private string RenderMarkdown(string v)
        {

            return _template + Markdig.Markdown.ToHtml(v, _pipeline) + "\r\n\r\n\r\n</body></html>";
        }

        void RefreshFileBox()
        {
            __fileBox.Items.Clear();
            __fileBox.Items.AddRange(_appPath.GetFiles().Select(i => i.GetFileNameWithoutExtension()).ToArray());
            
        }
        void RefreshListBox(string v)
        {
            __listBox.Items.Clear();
            if (string.IsNullOrWhiteSpace(v)) return;
            _dic = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(v);
            
                __listBox.Items.AddRange(_dic.Keys.OrderBy(i=>i).ToArray());

        }
        void Reset()
        {
            _currentKey = "";
            _dic = null;

        }
        #endregion

        private void __textBox_TextChanged(object sender, EventArgs e)
        {
            if (this.Text.Length > 0 && this.Text[this.Text.Length - 1] != '*')
            {
                this.Text += "*";
            }
            if (_previewEnable)
                __webBrowser.DocumentText = RenderMarkdown(__textBox.Text);
        }

        private void __appButton_Click(object sender, EventArgs e)
        {
            FileSystemHelpers.OpenApplicationDirectory();
        }

        #region ContextMenu
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileName = __fileBox.Text.GetValidFileName().Trim();
            if (fileName.Length > 0)
            {
                _appPath.CombinePath(fileName + ".json").CreateEmptyFile();
                RefreshFileBox();
            }
        }
        #endregion

        private void __fileBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            var f = _appPath.CombinePath(__fileBox.Text + ".json");

            if (f.IsFile())
            {
                Reset();
                RefreshListBox(f.FileToString());
                
            }
        }

        private void __listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (__listBox.SelectedIndex != -1)
            {
               
                _currentKey = __listBox.SelectedItem.ToString();

                this.Text = _currentKey;
                __textBox.Text = _dic[_currentKey];

            }
        }

        private void __saveButton_ButtonClick(object sender, EventArgs e)
        {

        }
    }
}
