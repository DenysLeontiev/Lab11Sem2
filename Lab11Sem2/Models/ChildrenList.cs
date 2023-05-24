using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Sem2.Models
{
    public class ChildrenList : IEnumerable<Child>
    {
        private List<Child> children;

        public ChildrenList()
        {
            children = new List<Child>();
        }

        public void AddChild(Child child)
        {
            children.Add(child);
        }

        public IEnumerator<Child> GetEnumerator()
        {
            return new ChildrenIterator(children);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
