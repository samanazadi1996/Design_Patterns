using System;

namespace Iterator.Stack
{
    public class StackEnumerator : IMyEnum
    {
        private readonly PersonStack personStack;
        private int _index = -1;

        public StackEnumerator(PersonStack personStack)
        {
            this.personStack = personStack;
        }
        public Person Curent
        {
            get
            {
                return personStack[_index];
            }
        }


        public Person MoveNext()
        {
            _index++;
            if (personStack.Count() > _index)
            {
                return personStack[_index];
            }
            return null;
        }
    }
}
