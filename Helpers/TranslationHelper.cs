using System;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace MarkdownEditor.Net
{
    public static class TranslationHelper
    {
        private  const string HTTP = "http://fanyi.youdao.com/openapi.do?keyfrom=asdsadasd&key=1271366606&type=data&doctype=json&version=1.1&q=";

        public async static Task<string> Translate(this string v)
        {

           return await Task.Run(() =>
            {
                try
                {
                    HttpWebRequest wr = (HttpWebRequest)HttpWebRequest.Create(HTTP + v);
                    wr.Timeout = 30000;
                    HttpWebResponse wrp = (HttpWebResponse)wr.GetResponse();
                    Stream st = wrp.GetResponseStream();
                    var charset = wrp.CharacterSet;
                    var c = string.Empty;
                    using (var sr = new StreamReader(st
                        , Encoding.GetEncoding(charset)))
                    {
                        c = sr.ReadToEnd();
                    }
                    var obj = new JavaScriptSerializer().Deserialize<dynamic>(c);
                    var builder = new StringBuilder();
                    builder.Append(obj["translation"][0]);
                    builder.Append(Environment.NewLine);
                    builder.Append(obj["basic"]["explains"][0]);

                    return builder.ToString();
                }
                catch (Exception e)
                {

                    return e.Message;
                }

              
            });

        }
    }
}
