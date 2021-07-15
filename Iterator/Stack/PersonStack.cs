using Iterator.Collection;
using System.Collections.Generic;
using System.Linq;

namespace Iterator.Stack
{
    public class PersonStack : IMyEnumerable
    {
        private Stack<Person> _people = new Stack<Person>();

        public IMyEnum GetEnumerator()
        {
            return new StackEnumerator(this);
        }
        public Person this[int index]
        {
            get
            {
                return _people.ElementAt(index);
            }
            set
            {
                _people.Push(value);
            }
        }

        public int Count()
        {
            return _people.Count;
        }
    }
}
