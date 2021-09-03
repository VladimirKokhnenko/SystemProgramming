
namespace TaskOne.Resource
{
    public class Pair<T, K>
    {
        public T Key { get; set; }
        public K Value { get; set; }

        public Pair()
        {
            Key = default;
            Value = default;
        }

        public Pair(T key, K value)
        {
            Key = key;
            Value = value;
        }
    }
}
