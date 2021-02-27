using System.IO;

namespace lab
{
    class FileWorker
    {
        private const string path = @"C:\Users\lighabs\source\repos\lab\lab\files\";

        private StringWorker stringWorker;
        public FileWorker()
        {
            stringWorker = new StringWorker();
        }

        public string[] ProccesFile(string filename)
        {
            string[] content = getFileContent(filename);
            string[] suitable = stringWorker.getSuitableStrings(content);
            return suitable;
        }

        public void CopyContent(string filename, string[] content)
        {
            File.WriteAllLines(path + filename, content);
        }
        private string[] getFileContent(string filename)
        {
            return File.ReadAllLines(path + filename); 
        }
    }
}
