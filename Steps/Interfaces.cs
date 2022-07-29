using System.Collections.Generic;

namespace Steps
{
    public interface IBaseCollection
    {
        void Add(object obj);
        void Remove(object obj);
    }

    public static class BaceCollectionExtension
    {
        public static void AddRange(this IBaseCollection collection, IEnumerable<object> objects)
        {
            foreach (var obj in objects)
            {
                collection.Add(obj);
            }
        }
    }
    public class BaseList : IBaseCollection
    {

        private object[] items;
        private int count = 0;
        public BaseList(int initialCapacity)
        {
            items = new object[initialCapacity];
        }
        public void Add(object obj)
        {
            items[count] = obj;
            count++;
        }

        public void Remove(object obj)
        {
            items[count] = null;
            count--;
        }
    }
}
