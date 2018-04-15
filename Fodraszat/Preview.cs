using System;
using System.IO;
using System.Windows.Forms;

namespace Fodraszat
{
    public class Preview : IPreview
    {
        private readonly RichTextBox _richTextBox;

        public Preview(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox; 
        }
        public void Write(string text)
        {
            _richTextBox.Text += text;
        }

        public void WriteLine(string text)
        {
            _richTextBox.Text += text + Environment.NewLine;
        }

        public void Clear()
        {
            _richTextBox.Clear();
        }
    }
}
