using System.IO;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO.Compression;

namespace MarkdownEditor.Net
{
   public static class FileExtensions
    {

        public static void MoveFileByExtension(this string dir)
        {

            Directory.GetFiles(dir).AsParallel().ForAll((i) =>
            {
                var p = dir.CombinePath(Path.GetExtension(i).ToUpper());

                p.CreateDirectoryIfNotExist();
                if(!p.CombinePath(Path.GetFileName(i)).IsFile())
                File.Move(i, p.CombinePath(Path.GetFileName(i)));
            });
           
        }
        public static void KeepFileNameMeasureByRegex(this string dir,string regex)
        {

            var re = new Regex(regex);

            Directory.GetFiles(dir,"*",SearchOption.AllDirectories).AsParallel().ForAll((i) =>
            {
                var fn = Path.GetFileNameWithoutExtension(i);
                if (re.IsMatch(fn))
                {
                    fn = Path.Combine(Path.GetDirectoryName(i), re.Match(fn).Value + Path.GetExtension(i));
                    if (i!=fn&&!fn.IsFile())
                        File.Move(i, fn);
                }
               
            });

        }
        public static void RemoveFileNameMeasureByRegex(this string dir, string regex,string replace="")
        {

            var re = new Regex(regex);

            Directory.GetFiles(dir, "*", SearchOption.AllDirectories).AsParallel().ForAll((i) =>
            {
                var fn = Path.GetFileNameWithoutExtension(i);
                if (re.IsMatch(fn))
                {
                    fn = Path.Combine(Path.GetDirectoryName(i), re.Replace(fn,replace) + Path.GetExtension(i));
                    if (i != fn && !fn.IsFile())
                        File.Move(i, fn);
                }

            });

        }
        #region ZIP

        public static void ExtractZipArchive(this string  fileName,Func<string,bool> filter,string dir)
        {
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                var zip = new ZipArchive(fs);

                var entries = zip.Entries;

                foreach (var item in entries)
                {
                    if (item.Name!=""&&filter(item.FullName))
                    {

                        using (var fso=new FileStream(dir.CombinePath(item.Name), FileMode.OpenOrCreate))
                        {
                            item.Open().CopyTo(fso);
                        }
                        
                    }
                
                }

            }

        }
        #endregion
        public static void CreateEmptyFile(this string fileName)
        {
            File.Create(fileName).Close();
        }
        public static string CombinePath(this string dir, string f)
        {
            return Path.Combine(dir, f);
        }
        public static string GetFileNameWithoutExtension(this string v)
        {
            return Path.GetFileNameWithoutExtension(v);
        }
        public static string[] GetFiles(this string dir, string extFilter = "*.json")
        {
            return Directory.GetFiles(dir, extFilter);
        }
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
        public static bool IsDirectory(this string directory)
        {
            return Directory.Exists(directory);
        }
        public static bool IsFile(this string fullName)
        {
            return File.Exists(fullName);
        }
    }
}
