using System.Threading;

namespace MyThreadInfo
{
    public class ThEnc
    {
        public ThEnc(int id)
        {
            IdThread = id;
        }

        public int IdThread { get; set; } = -1;
        public int IdListOper { get; set; } = -1;
        public bool ThIsAlive { get; set; } = false;
        public Thread MyTh { get; set; } = null;
    }
}