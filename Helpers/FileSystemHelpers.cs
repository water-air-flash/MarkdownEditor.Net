using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;


namespace MarkdownEditor.Net
{
  public  class FileSystemHelpers
    {
        public static void OpenApplicationDirectory()
        {
            Process.Start(Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]));
        }
    }
}
