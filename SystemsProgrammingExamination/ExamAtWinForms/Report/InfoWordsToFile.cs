using System.Collections.Generic;

namespace ExamAtWinForms
{
    public static class InfoWordsToFile
    {
        public static List<ForTheReport> Report { get; set; } = new List<ForTheReport>();

        public static void Adding(string filePath, string word)
        {
            if (Report.Count > 0)
            {
                bool IsExist = true;

                for (int i = 0; i < Report.Count; i++)
                {
                    if (filePath == Report[i].FilePath)
                    {
                        Report[i].FileCountReplacements++;
                        IsExist = false;
                        Report[i].AddWord(word);
                        break;
                    }
                }

                if (IsExist)
                    Report.Add(new ForTheReport(filePath, word));
            }
            else
            {
                Report.Add(new ForTheReport(filePath, word));
            }
        }

        public static List<WordInfo> GetGroupedCollectionWords()
        {
            List<WordInfo> newColNotGroup = new List<WordInfo>();

            for (int i = 0; i < Report.Count; i++)
            {
                for (int j = 0; j < Report[i].CollectionWords.Count; j++)
                {
                    newColNotGroup.Add(new WordInfo(
                        Report[i].CollectionWords[j].Word)
                    {
                        CountWords = Report[i].CollectionWords[j].CountWords
                    }
                    );
                }
            }

            var newColGroup = new List<WordInfo>();

            for (int i = 0; i < newColNotGroup.Count; i++)
            {
                if (newColGroup.Count > 0)
                {
                    bool isExist = true;

                    for (int j = 0; j < newColGroup.Count; j++)
                    {
                        if (newColGroup[j].Word == newColNotGroup[i].Word)
                        {
                            newColGroup[j].CountWords += newColNotGroup[i].CountWords;
                            isExist = false;
                            break;
                        }
                    }

                    if (isExist)
                        newColGroup.Add(newColNotGroup[i]);
                }
                else
                {
                    newColGroup.Add(newColNotGroup[i]);
                }
            }

            return newColGroup;
        }
    }
}