namespace CourseProject.Classes.Flocks
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Drawing;

    using CourseProject.Classes.Fishes;

    /// <summary>
    /// The pike flock.
    /// </summary>
    internal class PikeFlock : IEnumerable<Pike>
    {
        /// <summary>
        /// The head.
        /// </summary>
        private Pike head;

        /// <summary>
        /// The tail.
        /// </summary>
        private Pike tail;

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
            var pike = new Pike(data);

            if (this.head == null)
            {
                this.head = pike;
            }
            else
            {
                this.tail.Next = pike;
            }

            this.tail = pike;

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
        public IEnumerator<Pike> GetEnumerator()
        {
            var current = this.head;

            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
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
    }
}