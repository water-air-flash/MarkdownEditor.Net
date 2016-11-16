using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.IO;

namespace MarkdownEditor.Net
{
    public class SimpleSever
    {
        private HttpListener _sever;
        private string _port;
        private Thread _thread;
        private string _content;
        private string _directory;
        private List<string> _severed;
        public SimpleSever(string port,string dir)
        {
            _port = port;
            _directory = dir;
            _thread = new Thread(this.Listen);
            _severed = new List<string>();
            _thread.Start();

        }
        public void Stop()
        {
            _thread.Abort();
            _sever.Stop();
        }
        private void Listen()
        {
            _sever = new HttpListener();

            _sever.Prefixes.Add("http://*:8181/");
            _sever.Start();
            while (true)
            {
                try
                {
                    HttpListenerContext context = _sever.GetContext();
                    Process(context);
                }
                catch (Exception ex)
                {

                }
            }
        }
       private static IDictionary<string, string> _mimeTypeMappings = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase) {
        #region extension to MIME type list
        //{".asf", "video/x-ms-asf"},
        //{".asx", "video/x-ms-asf"},
        //{".avi", "video/x-msvideo"},
        //{".bin", "application/octet-stream"},
        //{".cco", "application/x-cocoa"},
        //{".crt", "application/x-x509-ca-cert"},
        {".css", "text/css"},
        //{".deb", "application/octet-stream"},
        //{".der", "application/x-x509-ca-cert"},
        //{".dll", "application/octet-stream"},
        //{".dmg", "application/octet-stream"},
        //{".ear", "application/java-archive"},
        //{".eot", "application/octet-stream"},
        //{".exe", "application/octet-stream"},
        //{".flv", "video/x-flv"},
        //{".gif", "image/gif"},
        //{".hqx", "application/mac-binhex40"},
        //{".htc", "text/x-component"},
        //{".htm", "text/html"},
        //{".html", "text/html"},
        //{".ico", "image/x-icon"},
        //{".img", "application/octet-stream"},
        //{".iso", "application/octet-stream"},
        //{".jar", "application/java-archive"},
        //{".jardiff", "application/x-java-archive-diff"},
        //{".jng", "image/x-jng"},
        //{".jnlp", "application/x-java-jnlp-file"},
        {".jpeg", "image/jpeg"},
        {".jpg", "image/jpeg"},
        //{".js", "application/x-javascript"},
        //{".mml", "text/mathml"},
        //{".mng", "video/x-mng"},
        //{".mov", "video/quicktime"},
        //{".mp3", "audio/mpeg"},
        //{".mpeg", "video/mpeg"},
        //{".mpg", "video/mpeg"},
        //{".msi", "application/octet-stream"},
        //{".msm", "application/octet-stream"},
        //{".msp", "application/octet-stream"},
        //{".pdb", "application/x-pilot"},
        //{".pdf", "application/pdf"},
        //{".pem", "application/x-x509-ca-cert"},
        //{".pl", "application/x-perl"},
        //{".pm", "application/x-perl"},
         {".png", "image/png"},
        //{".prc", "application/x-pilot"},
        //{".ra", "audio/x-realaudio"},
        //{".rar", "application/x-rar-compressed"},
        //{".rpm", "application/x-redhat-package-manager"},
        //{".rss", "text/xml"},
        //{".run", "application/x-makeself"},
        //{".sea", "application/x-sea"},
        //{".shtml", "text/html"},
        //{".sit", "application/x-stuffit"},
        //{".swf", "application/x-shockwave-flash"},
        //{".tcl", "application/x-tcl"},
        //{".tk", "application/x-tcl"},
        //{".txt", "text/plain"},
        //{".war", "application/java-archive"},
        //{".wbmp", "image/vnd.wap.wbmp"},
        //{".wmv", "video/x-ms-wmv"},
        //{".xml", "text/xml"},
        //{".xpi", "application/x-xpinstall"},
        //{".zip", "application/zip"},
        #endregion
    };
        public void SetContent(string content)
        {
            _content = content;
        }

        private void ServeFile(HttpListenerContext context)
        {
            if (_severed.Contains(context.Request.RawUrl))
            {
                context.Response.StatusCode = (int)HttpStatusCode.NotModified;
                context.Response.OutputStream.Close();
                return;
            }

                string filename = context.Request.RawUrl;
            filename = filename.Substring(1);
        
        

            filename = Path.Combine(_directory, filename);

            if (File.Exists(filename))
            {
                try
                {
                    Stream input = new FileStream(filename, FileMode.Open);

                    //Adding permanent http response headers
                    string mime;
                    context.Response.ContentType = _mimeTypeMappings.TryGetValue(Path.GetExtension(filename), out mime) ? mime : "application/octet-stream";
                    context.Response.ContentLength64 = input.Length;
                    context.Response.AddHeader("Date", DateTime.Now.ToString("r"));
                    context.Response.AddHeader("Last-Modified", System.IO.File.GetLastWriteTime(filename).ToString("r"));

                    byte[] buffer = new byte[1024 * 16];
                    int nbytes;
                    while ((nbytes = input.Read(buffer, 0, buffer.Length)) > 0)
                        context.Response.OutputStream.Write(buffer, 0, nbytes);
                    input.Close();
                    context.Response.OutputStream.Flush();
                    _severed.Add(context.Request.RawUrl);
                    context.Response.StatusCode = (int)HttpStatusCode.OK;
                }
                catch (Exception ex)
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                }

            }
            else
            {
                context.Response.StatusCode = (int)HttpStatusCode.NotFound;
            }

            context.Response.OutputStream.Close();
        }
        private void Process(HttpListenerContext context)
        {

            var req = context.Request.RawUrl.Substring(1);

            if (req.Length == 0)
            {
                var buffer = new UTF8Encoding().GetBytes(_content);
                context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                context.Response.OutputStream.Flush();

                context.Response.StatusCode = (int)HttpStatusCode.OK;


                context.Response.OutputStream.Close();
            }
            else
            {
                ServeFile(context);
            }
           
        }
    }
}
