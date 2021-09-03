using System.Threading;

namespace VinnieFluffAndPearls.CommonResource
{
    public static class Resource
    {
        private static readonly Mutex _mutex = new Mutex();
        private static int _capacity;

        static Resource() => Capacity = 100;

        public static int Capacity
        {
            get => _capacity;

            set
            {
                _mutex.WaitOne();
                    _capacity = value;
                _mutex.ReleaseMutex();
            }
        }
    }
}