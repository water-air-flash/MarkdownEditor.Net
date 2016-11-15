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

namespace MarkdownEditor.Net
{
    public partial class __mainForm : Form
    {
        public __mainForm()
        {
            InitializeComponent();
            Initialize();
        }


        #region Methods
        private void Initialize()
        {

            #region WebBrowser
            NativeMethods.CoInternetSetFeatureEnabled(NativeMethods.FEATURE_DISABLE_NAVIGATION_SOUNDS, NativeMethods.SET_FEATURE_ON_PROCESS, true);
            __webBrowser.ScriptErrorsSuppressed = true;
            #endregion

        }
        #endregion

    }
}
