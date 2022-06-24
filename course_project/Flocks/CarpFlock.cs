﻿using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using course_project.Fishes;

namespace course_project.Flocks
{
    internal class CarpFlock : IEnumerable<Carp>
    {
        private Carp _head;
        private Carp _tail;

        public int Count { get; private set; }

        public bool IsEmpty => Count == 0;

        public IEnumerator<Carp> GetEnumerator()
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
            var carp = new Carp(data);

            if (_head == null)
                _head = carp;
            else
                _tail.Next = carp;

            _tail = carp;

            Count++;
        }

        public void AppendFirst(Point data)
        {
            var carp = new Carp(data)
            {
                Next = _head
            };

            _head = carp;

            if (Count == 0) _tail = _head;

            Count++;
        }

        public void Clear()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }

        public bool Contains(Point data)
        {
            var current = _head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;

                current = current.Next;
            }

            return false;
        }

        public bool Remove(Point data)
        {
            var current = _head;
            Carp previous = null;

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

                        if (_head == null)
                            _tail = null;
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