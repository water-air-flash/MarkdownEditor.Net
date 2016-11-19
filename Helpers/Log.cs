using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MarkdownEditor.Net
{
   public class Log
    {

        public static Log _log;

        string _fileName;
        StreamWriter _writer;
        public Log()
        {
            _fileName = "log.txt".GetApplicationPath();
            _writer = new StreamWriter(_fileName, true, Encoding.UTF8); 
        }

        public static Log GetInstance()
        {
            if (_log == null)

                _log = new Log();
            return _log;
        }
        public void Close()
        {
            
            _writer.Close();
        }
        public void Write<T>(T t)
        {
            _writer.Write(t.ToString() + Environment.NewLine);
            _writer.Flush();
        }
    }
}
