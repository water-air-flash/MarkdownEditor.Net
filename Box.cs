using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkdownEditor.Net
{
    public class Render : TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel
    {
        public Render()
        {

        }
    }
    public class Box : ComboBox
    {
        private int _lastedSelectedIndex = -1;
        private Func<int,bool> _beforeCommitChange;
        public Func<int,bool> BeforeCommitChange
        {
            set
            {
                _beforeCommitChange = value;
            }
        }
        public Box()
        {
            
        }
        protected override void OnSelectedIndexChanged(EventArgs e)
        {

            _beforeCommitChange?.Invoke(_lastedSelectedIndex);
            
            _lastedSelectedIndex = SelectedIndex;
            
            base.OnSelectedIndexChanged(e);
        }
    }
}
