using System.Collections.Generic;

namespace ExamAtWinForms
{
    public static class WordExtenshionMethods
    {
        public static List<WordInfo> WordExtMetGroupByWord(this List<WordInfo> colWord)
        {
            var newCol = new List<WordInfo>();

            for (int i = 0; i < colWord.Count; i++)
            {
                if (newCol.Count > 0)
                {
                    bool isExist = true;

                    for (int j = 0; j < newCol.Count; j++)
                    {
                        if (newCol[j].Word == colWord[i].Word)
                        {
                            newCol[j].CountWords += colWord[i].CountWords;
                            isExist = false;
                            break;
                        }
                    }

                    if (isExist)
                        newCol.Add(colWord[i]);
                }
                else
                {
                    newCol.Add(colWord[i]);
                }
            }

            return newCol;
        }
    }
}