using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MarkdownEditor.Net
{
   public static  class StringExtensions
    {
       
        public static string Flat(this IEnumerable<string> ls)
        {
            if (ls == null)
                return null;
            return String.Join(Environment.NewLine, ls);
        }
        public static string[] CollectMatches(this string v,string reg)
        {
            var matches = Regex.Matches(v, reg);

            if (matches.Count > 0)
            {
                string[] rs = new string[matches.Count];


                for (int i = 0; i < matches.Count; i++)
                {
                  rs[i]=  matches[i].Value;
                }
                return rs;
            }
            return null;
        }


        public static List<string> CollectMarks(this string v)
        {
            var chs = v.ToString();
            var encountered = false;
            var list = new List<string>();

            var builder = new StringBuilder();

            for (int i = 0; i < chs.Length; i++)
            {
                if (chs[i] == '{')
                {
                    if (chs[i + 1] == '{' && chs[i + 2] == '{')
                    {

                        encountered = true;
                        i = i + 2;
                        continue;
                    }
                }
                if (encountered)
                {
                    if (chs[i] == '}')
                    {
                        if (chs[i + 1] == '}' && chs[i + 2] == '}')
                        {
                            i = i + 2;

                            encountered = false;

                            list.Add(builder.ToString());
                            builder.Clear();
                        }
                        else
                        {
                            builder.Append(chs[i]);
                        }
                    }
                    else
                    {
                        builder.Append(chs[i]);
                    }

                }

            }
            return list;
        }
        public static string RemoveMarks(this string v)
        {

            return Regex.Replace(v, "{{{[^}]*?}}}", "");
        }
        public static string[] Lines(this string v)
        {

            return v.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
