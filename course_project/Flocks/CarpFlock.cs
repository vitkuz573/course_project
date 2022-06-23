using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace course_project
{
    internal class CarpFlock : IEnumerable<Carp>
    {
        private Carp head;
        private Carp tail;
        private int count;

        public void Add(Point data)
        {
            Carp carp = new Carp(data);

            if (head == null)
                head = carp;
            else
                tail.Next = carp;

            tail = carp;

            count++;
        }

        public bool Remove(Point data)
        {
            Carp current = head;
            Carp previous = null;

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

        public int Count
        { get { return count; } }

        public bool IsEmpty
        { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(Point data)
        {
            Carp current = head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;

                current = current.Next;
            }

            return false;
        }

        public void AppendFirst(Point data)
        {
            Carp carp = new Carp(data)
            {
                Next = head
            };

            head = carp;

            if (count == 0)
            {
                tail = head;
            }

            count++;
        }

        public IEnumerator<Carp> GetEnumerator()
        {
            Carp current = head;

            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}