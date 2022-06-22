using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace course_project
{
    internal class PikeFlock : IEnumerable<Pike>
    {
        Pike head;
        Pike tail;
        int count;

        public void Add(Point data)
        {
            Pike pike = new Pike(data);

            if (head == null)
                head = pike;
            else
                tail.Next = pike;

            tail = pike;

            count++;
        }

        public bool Remove(Point data)
        {
            Pike current = head;
            Pike previous = null;

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

        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(Point data)
        {
            Pike current = head;

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
            Pike pike = new Pike(data)
            {
                Next = head
            };

            head = pike;

            if (count == 0)
            {
                tail = head;
            }

            count++;
        }

        public IEnumerator<Pike> GetEnumerator()
        {
            Pike current = head;

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
