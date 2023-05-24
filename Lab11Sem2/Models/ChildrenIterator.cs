using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Sem2.Models
{
    class ChildrenIterator : IEnumerator<Child>
    {
        private List<Child> children;
        private int currentIndex;

        public ChildrenIterator(List<Child> children)
        {
            this.children = children;
            currentIndex = -1;
        }

        public Child Current
        {
            get { return children[currentIndex]; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public bool MoveNext()
        {
            currentIndex++;
            return currentIndex < children.Count;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public void Dispose()
        {
            // Порожня реалізація, немає ресурсів для вивільнення
        }
    }
}
