using System;
using System.IO;

namespace Fodraszat
{
    public class FileUtil : IFileUtil
    {
        public string ReadAllText(string path)
        {
            var text = string.Empty;

            if (File.Exists(path))
            {
                text = File.ReadAllText(path);
            }
            
            return text;
        }

        public void WriteAllText(string path, string content)
        {
            File.WriteAllText(path, content);
        }
    }
}
