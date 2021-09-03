
namespace VinnieFluffAndPearls.CommonResource
{
    public static class Resource
    {
        private static readonly object locker = new object();
        private static int _capacity;

        static Resource() => Capacity = 100;

        public static int Capacity
        {
            get
            {
                lock (locker)
                {
                    return _capacity;
                }
            }

            set
            {
                lock (locker)
                {
                    _capacity = value;
                }
            }
        }
    }
}