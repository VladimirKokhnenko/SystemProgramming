using System.Collections.Generic;

namespace ExamAtWinForms
{
    public static class IlRes
    {
        private static readonly object _locker = new object();
        private static List<string> _words = new List<string>();
        public static List<string> Words
        {
            get { lock (_locker) { return _words; } }

            set => _words = value;
        }
    }
}