using System.Collections.Generic;

namespace Iterator.Collection
{
    public class PersonCollection : IMyEnumerable
    {
        private List<Person> _people = new List<Person>();

        public IMyEnum GetEnumerator()
        {
            return new ListEnumerator(this);
        }
        public Person this[int index]
        {
            get
            {
                return _people[index];
            }
            set
            {
                _people.Add(value);
            }
        }

        public int Count()
        {
            return _people.Count;
        }
    }
}
