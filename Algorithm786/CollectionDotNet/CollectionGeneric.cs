
using System.Collections.Generic;
using System.Collections;
using System.Collections.Concurrent;
using System.Reflection.Metadata.Ecma335;

namespace MyCollection
{
    public class CollectionGeneric : ICollection
    {
        //System.Collections.Generic;
        List<string> types = new List<string>();
        Queue<string> names = new Queue<string>();
        Stack<string> values = new Stack<string>();
        LinkedList<string> fields = new LinkedList<string>();
        Dictionary<int, int> m_ = new Dictionary<int, int>();
        SortedList<int, int> keyValuePairs = new SortedList<int, int>();

        //System.Collections
        ArrayList arrayList = new ArrayList();
        Hashtable hashtable = new Hashtable();
        Queue queue= new Queue();
        Stack stack= new Stack();

        //System.Collections.Concurrent
        ConcurrentDictionary<string, string> key = new ConcurrentDictionary<string, string>();
        ConcurrentQueue<string> strings = new ConcurrentQueue<string>(); 
        ConcurrentStack<int> ints= new ConcurrentStack<int>();

        public int Count => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class Test<T> : ICollection<T>
    {
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class Test1<T> : IList<T>
    {
        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
