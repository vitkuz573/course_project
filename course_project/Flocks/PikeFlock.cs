using System.Collections;

namespace course_project
{
    internal class PikeFlock : IEnumerable
    {
        Pike head;
        Pike tail;
        int count;

        public void Add(int[] data, AquariumForm aquariumForm)
        {
            Pike pike = new Pike(data, aquariumForm);

            if (head == null)
                head = pike;
            else
                tail.Next = pike;

            tail = pike;

            count++;
        }

        public bool Remove(int[] data)
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

        public bool Contains(int[] data)
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

        public void AppendFirst(int[] data, AquariumForm aquariumForm)
        {
            Pike pike = new Pike(data, aquariumForm)
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            Pike current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
