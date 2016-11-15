using System;
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

        MarkdownPipeline _pipeline;

        string _currentKey;
        bool _previewEnable;
        #endregion

        public __mainForm()
        {
            InitializeComponent();
            Initialize();
        }


        #region Methods
        private void Initialize()
        {

            "datas".GetApplicationPath().CreateDirectoryIfNotExist();

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
    }
}
