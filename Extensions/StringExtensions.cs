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
        public static string JavaScriptStringEncode(this string value, bool addDoubleQuotes=false)
        {
            if (string.IsNullOrEmpty(value))
                return addDoubleQuotes ? "\"\"" : string.Empty;

            int len = value.Length;
            bool needEncode = false;
            char c;
            for (int i = 0; i < len; i++)
            {
                c = value[i];

                if (c >= 0 && c <= 31 || c == 34 || c == 39 || c == 60 || c == 62 || c == 92)
                {
                    needEncode = true;
                    break;
                }
            }

            if (!needEncode)
                return addDoubleQuotes ? "\"" + value + "\"" : value;

            var sb = new System.Text.StringBuilder();
            if (addDoubleQuotes)
                sb.Append('"');

            for (int i = 0; i < len; i++)
            {
                c = value[i];
                if (c >= 0 && c <= 7 || c == 11 || c >= 14 && c <= 31 || c == 39 || c == 60 || c == 62)
                    sb.AppendFormat("\\u{0:x4}", (int)c);
                else switch ((int)c)
                    {
                        case 8:
                            sb.Append("\\b");
                            break;

                        case 9:
                            sb.Append("\\t");
                            break;

                        case 10:
                            sb.Append("\\n");
                            break;

                        case 12:
                            sb.Append("\\f");
                            break;

                        case 13:
                            sb.Append("\\r");
                            break;

                        case 34:
                            sb.Append("\\\"");
                            break;

                        case 92:
                            sb.Append("\\\\");
                            break;

                        default:
                            sb.Append(c);
                            break;
                    }
            }

            if (addDoubleQuotes)
                sb.Append('"');

            return sb.ToString();
        }
        public static string Flat(this IEnumerable<string> ls,string j="\r\n")
        {
            if (ls == null)
                return null;
            return String.Join(j, ls);
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
