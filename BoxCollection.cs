using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance.NET_labb1
{

    internal class BoxCollection : ICollection<Box>
    {
        private List<Box> boxes;

        public BoxCollection()
        {
            boxes = new List<Box>();
        }

        public Box this[int index]
        {
            get { return (Box)boxes[index]; }
            set { boxes[index] = value; }
        }

        public int Count
        {
            get { return boxes.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(Box item)
        {
            int index = boxes.FindIndex(box => box.Equals(item));
            if (index == -1)
            {
                boxes.Add(item);
            }
            else
            {
                Console.WriteLine($"The dimensions of box at position {index + 1} are not unique and cannot be added.");
            }
        }

        public void Clear()
        {
            boxes.Clear();
        }

        public bool Contains(Box item)
        {
            return boxes.Contains(item, new BoxSameDim());
        }

        //To find specific dimension
        public bool Contains(Box item, IEqualityComparer<Box> comparer)
        {
            return boxes.Contains(item, comparer);
        }


        public void CopyTo(Box[] array, int arrayIndex)
        {
            boxes.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return boxes.GetEnumerator();
        }

        public bool Remove(Box item)
        {
            return boxes.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return boxes.GetEnumerator();
        }

        internal class BoxSameDim : EqualityComparer<Box>
        {
            public override bool Equals(Box x, Box y)
            {
                return x.Height == y.Height && x.Length == y.Length && x.Width == y.Width;
            }

            public override int GetHashCode(Box obj)
            {
                return obj.Height.GetHashCode() ^ obj.Length.GetHashCode() ^ obj.Width.GetHashCode();
            }
        }
    }
}
