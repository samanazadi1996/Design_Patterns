namespace Iterator.Collection
{
    public class ListEnumerator : IMyEnum
    {
        private readonly PersonCollection personCollection;
        private int _index = -1;
        public ListEnumerator(PersonCollection personCollection)
        {
            this.personCollection = personCollection;
        }
        public Person Curent
        {
            get
            {
                return personCollection[_index];
            }
        }

        public Person MoveNext()
        {
            _index++;
            if (personCollection.Count() > _index)
            {
                return personCollection[_index];
            }
            return null;
        }

    }
}
