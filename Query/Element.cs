using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query
{
    internal class Element <T>
    {
        internal Element<T> previous;
        internal Element<T> next;
        internal T value;
        public Element(T value, Element<T> previous = null, Element<T> next = null)
        {
            this.previous = previous;
            this.next = next;
            this.value = value;
        }
    }
}
