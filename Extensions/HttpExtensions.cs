using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace MarkdownEditor.Net
{
  public static   class HttpExtensions
    {

        public async static Task<string> Request(this string url,string content)
        {
            return await Task.Run(() =>
            {
                try
                {
                    HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
                    req.ContentType = "application/json";
                    req.Method = "POST";
                    using (var stream = req.GetRequestStream())
                    {
                        var buffer = new UTF8Encoding(false, true).GetBytes(content);
                        stream.Write(buffer, 0, buffer.Length);
                    }

                    HttpWebResponse res = (HttpWebResponse)req.GetResponse();

                    using (var stream = res.GetResponseStream())
                    {
                        using (var stringReader = new StreamReader(stream))
                        {
                            return stringReader.ReadToEnd();
                        }
                    }
                }
                catch (Exception ex)
                {

                    return ex.Message;
                }
            });

         
           
        }
    }
}
