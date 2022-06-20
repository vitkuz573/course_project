using System.Collections;
using System.Collections.Generic;

namespace course_project
{
    internal class CarpFlock<T> : IEnumerable<T>
    {
        Carp<T> head;
        Carp<T> tail;
        int count;

        public void Add(T data, AquariumForm aquariumForm)
        {
            Carp<T> carp = new Carp<T>(data, aquariumForm);

            if (head == null)
                head = carp;
            else
                tail.Next = carp;
            tail = carp;

            count++;
        }

        public bool Remove(T data)
        {
            Carp<T> current = head;
            Carp<T> previous = null;

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
            Carp<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public void AppendFirst(T data, AquariumForm aquariumForm)
        {
            Carp<T> carp = new Carp<T>(data, aquariumForm);
            carp.Next = head;
            head = carp;
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
            Carp<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
