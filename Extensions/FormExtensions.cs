
using System.Windows.Forms;

namespace MarkdownEditor.Net
{
    public static class FormExtensions
    {
        public static string GetFirstNotEmptyLine(this TextBox textBox)
        {

            if (string.IsNullOrWhiteSpace(textBox.Text)) return null;
            for (int i = 0; i < textBox.Lines.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(textBox.Lines[i]))
                    return textBox.Lines[i];
            }
            return null;
        }
        public static int GetPreviousNewLine(this TextBox textBox)
        {
            for (int i = textBox.SelectionStart-1; i >0 ; i--)
            {
                if (textBox.Text[i] == '\n')
                    return i;
            }
            return -1;
        }
        public static string GetCurrentLine(this TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text)) return null;
            var chs = textBox.Text;
            var start = textBox.SelectionStart;
            var sf = 0;
            var se = chs.Length;
            var sfa = 0;
            while (start-- > 0)
            {
                if (chs[start] == '\n')
                {
                    sf = start;
                    break;
                }
            }
            sfa = sf;
            while (sfa++ < chs.Length - 1)
            {
                if (chs[sfa] == '\n')
                {
                    se = sfa;
                    break;
                }
            }
            return textBox.Text.Substring(sf, se - sf);
        }
        public static string GetSelectLine(this TextBox textbox)
        {
            if (string.IsNullOrWhiteSpace(textbox.SelectedText))
                return textbox.GetCurrentLine();
            else
                return textbox.SelectedText;
        }
    }
}
