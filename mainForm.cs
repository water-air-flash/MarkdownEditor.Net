﻿using System;
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
        readonly string _title;
        readonly string _template;
        readonly string _appPath;
        readonly string _translatePath;
        readonly string _markdownPath;
        readonly string _achieve;
        MarkdownPipeline _pipeline;
        string _currentKey = null;
        bool _previewEnable;
        bool _changed;
        int _scroll;

        Dictionary<string, string> _dic;
        #endregion
        public __mainForm()
        {
            InitializeComponent();
            //.GetApplicationPath();
            _title = "Markdown Editor";
            _template = string.Format("<!DOCTYPE html>\n<html>\n<head>\n <title></title>\n <meta charset=\"utf-8\" />\n <link href=\"{0}\" rel=\"stylesheet\" />\n</head><body>\r\n\r\n\r\n", "../resource/style.css");
            _appPath = "datas".GetApplicationPath();
            _achieve = _appPath.CombinePath("achieve");
            _translatePath = _appPath.CombinePath("translat");
            _markdownPath = _appPath.CombinePath("markdown");
            Initialize();
        }
        #region Methods
        bool CheckReadyNew()
        {
            if (!string.IsNullOrEmpty(__fileBox.Text) && !string.IsNullOrWhiteSpace(__textBox.Text)) return true;
            return false;
        }
        bool CheckReadyModify()
        {
            if (_currentKey != null && _dic != null && !string.IsNullOrEmpty(__fileBox.Text) && _appPath.CombinePath(__fileBox.Text + ".json").IsFile()) return true;
            return false;
        }
        void UpdateStatus(string key)
        {
            _currentKey = key;
            this.Text = key;
            _changed = false;
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
                    if (key != null)
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
            //__hmtPanel.BaseStylesheet = "datas\\resource\\style.css".GetApplicationPath().FileToString();
            _appPath.CreateDirectoryIfNotExist();
            _translatePath.CreateDirectoryIfNotExist();
            _markdownPath.CreateDirectoryIfNotExist();
            _achieve.CreateDirectoryIfNotExist();
            RefreshFileBox();
            #region MarkDig
            _pipeline = new MarkdownPipelineBuilder().UseAutoLinks().UsePipeTables().UseAutoIdentifiers().Build();
            #endregion


            __fileBox.BeforeCommitChange = (i) =>
              {
                  if (!_changed || i == -1) return false;
                  string fileName = null;
                  fileName = __fileBox.Items[i] + ".json";
                  SaveWithoutUpdate(fileName);
                  return false;
              };
        }
        async void Translating()
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
            if (string.IsNullOrWhiteSpace(v)) return;
            __listBox.Items.Clear();
            _dic = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(v);
            if (_dic == null) return;
            __listBox.Items.AddRange(_dic.Keys.OrderBy(i => i).ToArray());
        }
        void Reset()
        {
            _currentKey = null;
            _dic = null;
        }
        void ResetEverything()
        {
            this.Text = _title;
            __textBox.Text = null;
            _currentKey = null;
            _dic = null;
            __listBox.Items.Clear();
            _changed = false;
        }
        void SaveWithoutUpdate(string fileName)
        {
            if (string.IsNullOrEmpty(__textBox.Text)) return;
            if (_currentKey != null)
            {
                _dic[_currentKey] = __textBox.Text;

            }
            else
            {

                var key = __textBox.GetFirstNotEmptyLine();

                key = key.Trim().TrimStart(new char[] { '#', ' ' });

                if (_dic == null)
                    _dic = new Dictionary<string, string>();
                _dic.Add(key, __textBox.Text);


            }
            Flush(_appPath.CombinePath(fileName));
        }
        #endregion
        #region TextBox
        private void __textBox_TextChanged(object sender, EventArgs e)
        {
            _changed = true;
            if (this.Text.Length > 0 && this.Text[this.Text.Length - 1] != '*')
            {
                this.Text += "*";
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
        #region Box

        private void __fileBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetEverything();
            string fileName = __fileBox.SelectedItem.ToString() + ".json";
            if (_appPath.CombinePath(fileName).IsFile())
                RefreshListBox(_appPath.CombinePath(fileName).FileToString());
        }
        #endregion
        private void __listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (__listBox.SelectedIndex != -1)
            {
                _currentKey = __listBox.SelectedItem.ToString();
                __textBox.Text = _dic[_currentKey];
                _changed = false;
                this.Text = _currentKey;

            }
        }
        #region Under Save Button

        private void hTMLToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Markdown.ToHtml(__textBox.Text, _pipeline));

        }
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
                var fileName = __fileBox.Text + ".json";
                _dic.Remove(_currentKey);
                _dic.Add(key, __textBox.Text);
                RefreshListBox(Flush(_appPath.CombinePath(fileName)));
                UpdateStatus(key);
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (__listBox.SelectedIndex != -1)
            {
                _dic.Remove(__listBox.SelectedItem.ToString());
                var fileName = __fileBox.Text + ".json";
                RefreshListBox(Flush(_appPath.CombinePath(fileName)));
                _currentKey = null;
            }
        }
        private void collectDocumentKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            __textBox.SelectedText += Environment.NewLine + string.Join(Environment.NewLine, _dic.Keys);
        }
        #endregion
        private void __newButton_ButtonClick(object sender, EventArgs e)
        {
            this.Text = null;
            __textBox.Text = null;
            _currentKey = null;
        }
        #region  ContextMenu
        private void codeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(__textBox.SelectedText) && __textBox.SelectedText.IndexOf('\n') == -1)
                __textBox.SelectedText = $" `{__textBox.SelectedText.Trim()}` ";
            else
                __textBox.SelectedText = $"\r\n\r\n```\r\n{__textBox.SelectedText.Trim()}\r\n```\r\n\r\n";
        }
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
        private void linkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            __textBox.SelectedText = $"[{__textBox.SelectedText.Trim()}]()";
        }
        private void translateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Translating();
        }
        #endregion
        #region Toolbar
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
        private void __translateButton_Click(object sender, EventArgs e)
        {
            Translating();
        }
        #endregion
        #region Under PreviewButton
        private void __viewButton_ButtonClick(object sender, EventArgs e)
        {
            if (_currentKey != null)
            {
                if (string.IsNullOrEmpty(__fileBox.Text) || string.IsNullOrEmpty(__textBox.Text)) return;
                if (_currentKey != null)
                {

                    var fn = _achieve.CombinePath(__fileBox.Text);
                    fn.CreateDirectoryIfNotExist();
                    fn = fn.CombinePath(_currentKey.GetValidFileName() + ".html");
                    fn.StringToFile(RenderMarkdown(__textBox.Text));

                    System.Diagnostics.Process.Start("chrome", $"\"{fn}\"");

                }

            }
        }
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
       
        #endregion
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
        private void twiceIncreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var str = string.Join(Environment.NewLine,
          __textBox.SelectedText.Lines().Select((i) =>
          {
              return "\t\t" + i.TrimEnd();
          }));
            __textBox.SelectedText = $"{str}";
        }
        #endregion

        #region Under Tools Button
        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (__textBox.Text.Trim().IsDirectory())
                __textBox.Text.Trim().MoveFileByExtension();
        }
        private void materialIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (__textBox.Text.Trim().IsDirectory())
            {
                var dir = __textBox.Text.Trim();
                __textBox.Text.Trim().GetFiles("*.zip").AsParallel().ForAll((i) =>
                {
                    i.ExtractZipArchive((f) =>
                    {
                        if (f.Contains("web") && f.Contains("2x")) return true;
                        else
                            return false;
                    }, dir);
                });
            }
        }
        #endregion
        #region Form
        private void __mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Menu | Keys.Alt))
            {
                Translating();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void __mainForm_Load(object sender, EventArgs e)
        {
            _appPath.CombinePath("resource").CreateDirectoryIfNotExist();
        }
        #endregion
        #region Under Find Button
        private void windowPreferNewLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            __textBox.Text = __textBox.Lines.Flat();
        }

        private void removeNonneedLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pos = __textBox.SelectionStart;
            var len = __textBox.Lines.Length;
            var builder = new StringBuilder(__textBox.Text.Length);

            for (int i = 0; i < len; i++)
            {
                if (i + 1 < len && string.IsNullOrEmpty(__textBox.Lines[i]) && string.IsNullOrWhiteSpace(__textBox.Lines[i + 1]))
                {
                    continue;
                }
                else
                {
                    builder.Append(__textBox.Lines[i]).Append(Environment.NewLine);
                }
            }

            __textBox.Text = builder.ToString();
            __textBox.SelectionStart = pos;
            __textBox.ScrollToCaret();

        }
        private void keepMatchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(__findBox.Text))
            {
                var str = __textBox.Text.CollectMatches(__findBox.Text).Distinct().OrderBy(i => i).Flat();
                if (str != null)
                {
                    __textBox.Text = str;
                }
            }
        }
        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var str = string.IsNullOrWhiteSpace(__textBox.SelectedText) ? __findBox.Text : __textBox.SelectedText.Trim();
            var pos = __textBox.Text.IndexOf(str, __textBox.SelectionStart + str.Length);
            if (pos != -1)
            {
                __textBox.SelectionStart = pos;
                __textBox.SelectionLength = str.Length;
                __textBox.ScrollToCaret();
            }
        }
        #endregion
        #region Under Code Button
        private void chromeHeadersToJavaScriptObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(__textBox.Text))
            {
                var s = new char[] { ':' };
                __textBox.Text = __textBox.Lines.Select((i) =>
                {
                    var ls = i.Split(s, 2);
                    return $"\"{ls[0]}\":\"{ ls[1]}\",";
                }).Flat();
            }
        }
        private void sortDistinctToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(__textBox.Text))
            {
                __textBox.Text = __textBox.Lines.Distinct().OrderBy(i => i).Flat();
            }
        }
        private void removeEmptyLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            __textBox.Text = __textBox.Text.Lines().Flat();
        }

        private void codeReferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            __textBox.SelectedText = $" [`{__textBox.SelectedText.Trim()}`]()： ";
        }
        private void escapeForJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            __textBox.Text = __textBox.Text.JavaScriptStringEncode();
        }

        private void visualStudio2015JavaScriptCodeSnippetCLIPBOARDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var filename = "app.json".GetApplicationPath();

                var obj = new JavaScriptSerializer().Deserialize<dynamic>(filename.FileToString());

                string dir = obj["js_snippet_dir"];
                string temlate = obj["snippet_template"];
                if (dir.IsDirectory())
                {
                    var content = Clipboard.GetText();
                    var shortcut = content.Trim().Lines().First().Split(' ').Last().GetValidFileName();
                    var fn = dir.CombinePath(shortcut + ".snippet");
                    content = string.Format(temlate, shortcut, content.Trim().Lines().Skip(1).Flat(), "JavaScript");
                    fn.StringToFile(content);
                }
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }

        }
        #endregion



        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetEverything();

        }


        private void removeFileNameMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var marks = __textBox.Text.CollectMarks();

            if (marks.Count > 2)
            {
                var dir = marks[0];
                var reg = marks[1];

                if (dir.IsDirectory())
                {
                    dir.RemoveFileNameMeasureByRegex(reg);
                }
            }
        }


      
        private void _formatButton_Click(object sender, EventArgs e)
        {
            
        }

        private void hTMLAndBrowseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (_currentKey != null)
            {
                var filename = "HTM".GetApplicationPath();
                filename.CreateDirectoryIfNotExist();
                filename = filename.CombinePath(_currentKey.GetValidFileName() + ".htm");

                filename.StringToFile(Markdown.ToHtml(__textBox.Text,_pipeline));

                System.Diagnostics.Process.Start("chrome", $"\"{filename}\"");
            }
        }

         

        private void keepMatchFileNameMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var marks = __textBox.Text.CollectMarks();

            if (marks.Count > 2)
            {
                var dir = marks[0];
                var reg = marks[1];

                if (dir.IsDirectory())
                {
                    dir .KeepFileNameMeasureByRegex(reg);
                }
            }
        }

       

        private async void testServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msg =await "http://127.0.0.1:18080".Request("{1:1}");
            MessageBox.Show(msg);
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var t = Clipboard.GetText();
            var ls = t.Lines().Select(i => i.Trim().TrimStart(new char[] { ' ', '\t', '*' }));
            __textBox.SelectedText = ls.Flat(" ");
        }

        private void chromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var str = __textBox.GetSelectLine();

            var url = System.Text.RegularExpressions.Regex.Match(str,@"(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?").Value;
            if (!string.IsNullOrWhiteSpace(url))
            {
                System.Diagnostics.Process.Start("chrome", url);
            }
        }


    }
}