using System.IO;
using System;
using System.Text;


namespace MarkdownEditor.Net
{
   public static class FileExtensions
    {
        public static void CreateDirectoryIfNotExist(this string f)
        {
            if (!Directory.Exists(f))
            {
                Directory.CreateDirectory(f);
            }
        }
        public static String FileToString(this string fullName, bool isChineseEncoding = false)
        {
            var encoding = new UTF8Encoding(false);
            return File.ReadAllText(fullName, encoding);
        }
        public static void StringToFile(this string fullName, String content, bool isChineseEncoding = false)
        {

            var encoding = new UTF8Encoding(false);
            File.WriteAllText(fullName, content, encoding);
        }
        public static string GetValidFileName(this string filename)
        {
            if (filename.Length > 200)
            {
                filename = filename.Substring(0, 200);
            }
            var fn = filename.Replace("&amp;", "&").Replace("&#39;", "'").Replace(": ", "-").Replace("&quot;", "'");
            var chs = Path.GetInvalidFileNameChars();
            foreach (var item in chs)
            {
                fn = fn.Replace(item, '-');
            }
            if (fn.Length > 255)
            {
                return fn.Substring(0, 200);
            }
            return fn.Trim('-');
        }
        public static string GetApplicationPath(this string fileName)
        {
            return $"{Path.GetDirectoryName(Environment.GetCommandLineArgs()[0])}\\{fileName}";
        }
    }
}
