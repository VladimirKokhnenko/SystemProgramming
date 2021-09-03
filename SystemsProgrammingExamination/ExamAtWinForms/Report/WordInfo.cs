using System;

namespace ExamAtWinForms
{
    public class WordInfo
    {
        public string Word { get; set; }
        public int CountWords { get; set; }

        public WordInfo() { }

        public WordInfo(string word)
        {
            Word = word;
            CountWords = 1;
        }
    }
}