namespace CourseProject.Classes.Flocks
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Drawing;

    using CourseProject.Classes.Extensions;
    using CourseProject.Classes.Fishes;

    /// <summary>
    /// The carp flock.
    /// </summary>
    internal class CarpFlock : IEnumerable<Carp>
    {
        /// <summary>
        /// The head.
        /// </summary>
        private Carp head;

        /// <summary>
        /// The tail.
        /// </summary>
        private Carp tail;

        /// <summary>
        /// Gets the count.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// The is empty.
        /// </summary>
        public bool IsEmpty => this.Count == 0;

        /// <summary>
        /// The is not empty.
        /// </summary>
        public bool IsNotEmpty => this.Count != 0;

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        public void Add(Point data)
        {
            var carp = new Carp(data);

            if (this.head == null)
            {
                this.head = carp;
            }
            else
            {
                this.tail.Next = carp;
            }

            this.tail = carp;

            this.Count++;
        }

        /// <summary>
        /// The clear.
        /// </summary>
        public void Clear()
        {
            this.head = null;
            this.tail = null;
            this.Count = 0;
        }

        /// <summary>
        /// The get enumerator.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerator"/>.
        /// </returns>
        public IEnumerator<Carp> GetEnumerator()
        {
            var current = this.head;

            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        /// <summary>
        /// The remove nearest.
        /// </summary>
        /// <param name="point">
        /// The point.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool RemoveNearest(Point point)
        {
            var list = new List<Point>();
            var current = this.head;

            while (current != null)
            {
                list.Add(current.Data);
                current = current.Next;
            }

            return this.Remove(list.Nearest(point, 100));
        }

        /// <summary>
        /// The get enumerator.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerator"/>.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        /// <summary>
        /// The remove.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        private bool Remove(Point data)
        {
            var current = this.head;
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
                            this.tail = previous;
                        }
                    }
                    else
                    {
                        this.head = this.head.Next;

                        if (this.head == null)
                        {
                            this.tail = null;
                        }
                    }

                    this.Count--;

                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }
    }
}