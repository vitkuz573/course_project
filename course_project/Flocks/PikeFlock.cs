using System.Collections;
using System.Collections.Generic;

namespace course_project
{
    internal class PikeFlock<T> : IEnumerable<T>
    {
        Pike<T> head;
        Pike<T> tail;
        int count;

        public void Add(T data)
        {
            Pike<T> pike = new Pike<T>(data);

            if (head == null)
                head = pike;
            else
                tail.Next = pike;
            tail = pike;

            count++;
        }

        public bool Remove(T data)
        {
            Pike<T> current = head;
            Pike<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                        {
                            tail = previous;
                        }
                    }
                    else
                    {
                        head = head.Next;

                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }

        public int Count { get { return count; } }

        public bool isEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            Pike<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public void AppendFirst(T data)
        {
            Pike<T> pike = new Pike<T>(data);
            pike.Next = head;
            head = pike;
            if (count == 0)
            {
                tail = head;
            }
            count++;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Pike<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
