using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using course_project.Fishes;

namespace course_project.Flocks
{
    internal class PikeFlock : IEnumerable<Pike>
    {
        private Pike _head;
        private Pike _tail;

        public int Count { get; private set; }

        public bool IsEmpty => Count == 0;

        public IEnumerator<Pike> GetEnumerator()
        {
            var current = _head;

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

        public void Add(Point data)
        {
            var pike = new Pike(data);

            if (_head == null)
                _head = pike;
            else
                _tail.Next = pike;

            _tail = pike;

            Count++;
        }

        public void Clear()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }

        public bool Remove(Point data)
        {
            var current = _head;
            Pike previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null) _tail = previous;
                    }
                    else
                    {
                        _head = _head.Next;

                        if (_head == null) _tail = null;
                    }

                    Count--;

                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }
    }
}