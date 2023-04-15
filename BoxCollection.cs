using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1_Generics
{
    internal class BoxCollection : ICollection<Box>
    {
        private List<Box> innerCollection;
        public BoxCollection() { innerCollection = new List<Box>(); }
        public Box this[int index]
        {
            get { return (Box)innerCollection[index]; }
            set { innerCollection[index] = value; }
        }

        public int Count
        {
            get { return innerCollection.Count; }
        }

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(Box item)
        {
            if (!Contains(item))
            {
                innerCollection.Add(item);
            }
            else
            {
                Console.WriteLine("A box with these dimensions is already added");
            }
        }

        public void Clear()
        {
            innerCollection.Clear();
        }
        public bool Contains(Box item)
        {
            bool found = false;
            foreach (Box b in innerCollection)
            {
                if (b.Equals(item))
                {
                    found = true;
                }
            }
            return found;
        }
        public bool Contains(Box item, EqualityComparer<Box> equalityComparer)
        {
            bool found = false;
            foreach (Box b in innerCollection)
            {
                if (equalityComparer.Equals(item))
                {
                    found = true;
                }
            }
            return found;
        }

        public void CopyTo(Box[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return innerCollection.GetEnumerator();
        }

        public bool Remove(Box item)
        {
            return innerCollection.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
