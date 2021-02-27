using System.Collections.Generic;

namespace lab
{
    class StringWorker
    {
        private const int lineLength = 20;
        public string[] getSuitableStrings(string[] fileContent)
        {
            List<string> data = new List<string>();
            foreach(string line in fileContent)
            {
                if (line.Length < lineLength)
                {
                    data.Add(line);
                }
            }
            return data.ToArray();
        }
    }
}
