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
        readonly string _template;
        readonly string _appPath;
        readonly string _translatePath;

        MarkdownPipeline _pipeline;

        string _currentKey=null;
        bool _previewEnable;
        Dictionary<string, string> _dic;
        #endregion

        public __mainForm()
        {
            InitializeComponent();
            _template =  string.Format("<!DOCTYPE html>\n<html>\n<head>\n <title></title>\n <meta charset=\"utf-8\" />\n <link href=\"{0}\" rel=\"stylesheet\" />\n</head><body>\r\n\r\n\r\n", "style.css".GetApplicationPath());
            _appPath = "datas".GetApplicationPath();
            _translatePath = _appPath.CombinePath("translat");
            Initialize();
        }


        #region Methods
        bool CheckReadyNew()
        {
            if (!string.IsNullOrEmpty(__fileBox.Text) &&!string.IsNullOrWhiteSpace(__textBox.Text)) return true;
            return false;
        }
        bool CheckReadyModify()
        {
            if (_currentKey != null&&_dic!=null && !string.IsNullOrEmpty(__fileBox.Text)&& _appPath.CombinePath(__fileBox.Text+".json").IsFile()) return true;
            return false;
        }
        void UpdateStatus(string key)
        {
            _currentKey = key;
            this.Text = key;

        }
        string Flush(string fullName)
        {
            var str = new JavaScriptSerializer().Serialize(_dic);
            fullName.StringToFile(str);
            return str;
        }
        void Save()
        {
            if (_currentKey != null)
            {
                if (!string.IsNullOrWhiteSpace(__fileBox.Text))
                {
                    var fileName = __fileBox.Text.GetValidFileName() + ".json";
                    _dic[_currentKey] = __textBox.Text;
                    RefreshListBox(Flush(_appPath.CombinePath(fileName)));

                    UpdateStatus(_currentKey);
                }
            }
            else
            {
                if (CheckReadyNew())
                {
                    var key = __textBox.GetFirstNotEmptyLine();

                    if ( key != null)
                    {
                        key = key.Trim().TrimStart(new char[] { '#', ' ' });
                        var fileName = __fileBox.Text.GetValidFileName() + ".json";
                      
                        if (_dic == null)
                            _dic = new Dictionary<string, string>();
                        _dic.Add(key, __textBox.Text);

                        RefreshListBox(Flush(_appPath.CombinePath(fileName)));
                        UpdateStatus(key);
                    }
                }
               
            }
          
        }
        private void Initialize()
        {
           
            _appPath.CreateDirectoryIfNotExist();
            _translatePath.CreateDirectoryIfNotExist();
            RefreshFileBox();
            #region MarkDig

            _pipeline = new MarkdownPipelineBuilder().UseAutoLinks().UsePipeTables().UseAutoIdentifiers().Build();

            #endregion
            #region WebBrowser
            NativeMethods.CoInternetSetFeatureEnabled(NativeMethods.FEATURE_DISABLE_NAVIGATION_SOUNDS, NativeMethods.SET_FEATURE_ON_PROCESS, true);
            __webBrowser.ScriptErrorsSuppressed = true;
            #endregion

        }

       async  void Translating()
        {

            if (!string.IsNullOrWhiteSpace(__textBox.SelectedText))
            {
                var v = await __textBox.SelectedText.Trim().Translate();
                _translatePath.CombinePath(__textBox.SelectedText.Trim().GetValidFileName().ToLower() + ".txt").StringToFile(v);
                __transTextBox.Text = v;

            }
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
            _currentKey = null;
            _dic = null;

        }
        #endregion


        #region TextBox

        private void __textBox_TextChanged(object sender, EventArgs e)
        {
            if (this.Text.Length > 0 && this.Text[this.Text.Length - 1] != '*')
            {
                this.Text += "*";
            }
            if (_previewEnable)
            {
                __webBrowser.DocumentText = RenderMarkdown(__textBox.Text);
                __textBox.Focus();
            }
        }
        #endregion


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

        #region Under Save Button
        private void __saveButton_ButtonClick(object sender, EventArgs e)
        {
            Save();
        }
        private void changeNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckReadyModify())
            {
                var key = __textBox.GetFirstNotEmptyLine();
                key = key.Trim().TrimStart(new char[] { '#', ' ' });
                var fileName = __fileBox.Text+ ".json";

                _dic.Remove(_currentKey);
                _dic.Add(key, __textBox.Text);

                RefreshListBox(Flush(_appPath.CombinePath(fileName)));
                UpdateStatus(key);

             
            }
        }
        #endregion


        private void __newButton_ButtonClick(object sender, EventArgs e)
        {
            this.Text = null;
            __textBox.Text = null;
            _currentKey = null;
        }

       

        #region 
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(__textBox.GetSelectLine());
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            __textBox.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            __textBox.SelectAll();
        }
        #endregion


        #region 
        private void codeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(__textBox.SelectedText) && __textBox.SelectedText.IndexOf('\n') == -1)
                __textBox.SelectedText = $" `{__textBox.SelectedText.Trim()}` ";
            else
                __textBox.SelectedText = $"\r\n\r\n```\r\n{__textBox.SelectedText.Trim()}\r\n```\r\n\r\n";


        }
   
       

        #endregion

        private void linkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            __textBox.SelectedText = $"[{__textBox.SelectedText.Trim()}]()";
        }

        private void translateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Translating();
        }

     

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var dir = __textBox.Text.Trim();
           __textBox.Text.Trim().GetFiles("*.zip").AsParallel().ForAll((i) =>
            {
                i.ExtractZipArchive((f)=> {
                    if (f.Contains("web") && f.Contains("2x")) return true;
                    else
                        return false;
                }, dir);
            });
        }

        #region 

        private void _titleButton_Click(object sender, EventArgs e)
        {
            var pos = __textBox.GetPreviousNewLine() + 1;

            if (pos != -1)
            {
                __textBox.SelectionStart = pos;
                __textBox.SelectionLength = 0;

                if (__textBox.Text[pos] == '#')
                {

                    __textBox.SelectedText = "#";
                }
                else
                {
                    __textBox.SelectedText = "# ";

                }
            }
        }
      

        private void bulletListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (previewToolStripMenuItem.Checked)
            {
                _previewEnable = true;
                splitContainer2.Panel2Collapsed = false;

            }
            else
            {
                _previewEnable = false;
                splitContainer2.Panel2Collapsed = true;
            }
        }



        #region 


        private void __boldButton_Click(object sender, EventArgs e)
        {
            __textBox.SelectedText = $" **{__textBox.SelectedText.Trim()}** ";
        }
        private void __italicButton_Click(object sender, EventArgs e)
        {
            __textBox.SelectedText = $" *{__textBox.SelectedText.Trim()}* ";
        }
        private void __codeButton_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(__textBox.SelectedText) && __textBox.SelectedText.IndexOf('\n') == -1)
                __textBox.SelectedText = $" `{__textBox.SelectedText.Trim()}` ";
            else
                __textBox.SelectedText = $"\r\n\r\n```\r\n{__textBox.SelectedText.Trim()}\r\n```\r\n\r\n";


        }

        #endregion
        private   void __translateButton_Click(object sender, EventArgs e)
        {
            Translating(); 
        }
        #endregion

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Menu|Keys.Alt))
            {
                Translating();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        #region Under List Button
        private void __listButton_ButtonClick(object sender, EventArgs e)
        {

            var str = string.Join(Environment.NewLine,
                 __textBox.SelectedText.Lines().Select((i) =>
                 {

                     return "- " + i.Trim();
                 }));
            __textBox.SelectedText = $"\r\n\r\n{str}\r\n";
        }
        private void numberListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var index = 0;
            var str = string.Join(Environment.NewLine,
                 __textBox.SelectedText.Lines().Select((i) =>
                 {
                     index++;

                     return index + ". " + i.Trim();
                 }));
            __textBox.SelectedText = $"\r\n\r\n{str}\r\n";
        }
        #endregion




        #region Under Indent Button
        private void __indentButton_ButtonClick(object sender, EventArgs e)
        {

            var str = string.Join(Environment.NewLine,
                 __textBox.SelectedText.Lines().Select((i) =>
                 {

                     return "\t" + i.TrimEnd();
                 }));
            __textBox.SelectedText = $"{str}";
        }
        #endregion

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listToolStripMenuItem.Checked)
            {
                splitContainer1.Panel1Collapsed = false;

            }
            else
            {
                splitContainer1.Panel1Collapsed = true;

            }
        }
    }
}
