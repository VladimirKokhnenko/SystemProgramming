using System.Collections.Generic;
using System.IO;

namespace ExamAtWinForms
{
    public class ForTheReport
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public int FileSize { get; set; }
        public int FileCountReplacements { get; set; }
        public List<WordInfo> CollectionWords { get; set; } = new List<WordInfo>();

        public ForTheReport(string filePath, string word)
        {
            var fileInfo = new FileInfo(filePath);

            FileName = fileInfo.Name;
            FilePath = filePath;
            FileSize = (int)fileInfo.Length;
            FileCountReplacements = 1;
            CollectionWords.Add(new WordInfo(word));
        }

        public void AddWord(string word)
        {
            if (CollectionWords.Count > 0)
            {
                bool IsExist = true;

                for (int i = 0; i < CollectionWords.Count; i++)
                {
                    if (CollectionWords[i].Word == word)
                    {
                        CollectionWords[i].CountWords++;
                        IsExist = false;
                        break;
                    }
                }
                if (IsExist)
                    CollectionWords.Add(new WordInfo(word));
            }
            else
            {
                CollectionWords.Add(new WordInfo(word));
            }
        }
    }
}