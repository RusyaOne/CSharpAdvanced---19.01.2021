using System.Collections;

namespace UserCollection
{
    class UserCollection : IEnumerable
    {
        public int[] Array { get; set; }
        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }
    }

    class Iterator : IEnumerator
    {
        int[] array;
        public Iterator(UserCollection col)
        {
            array = col.Array;
        }

        int currentPosition = -1;

        public object Current
        {
            get
            {
                return array[currentPosition];
            }
        }

        public bool MoveNext()
        {
            if (currentPosition < array.Length - 1)
            {
                currentPosition++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            currentPosition = -1;
        }
    }

}
