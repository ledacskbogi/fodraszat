namespace Fodraszat
{
   public interface IFileUtil
    {
        string ReadAllText(string path);
        void WriteAllText(string path, string content);
    }
}
