using System.Collections;

namespace UserCollection
{
    public class UserCollection : IEnumerable
    {
        private readonly int[] _array;

        public UserCollection(params int[] array)
        {
            _array = array;
        }

        public IEnumerator GetEnumerator()
        {
            return new Iterator(_array);
        }
    }

    public class Iterator : IEnumerator
    {
        private int[] _array;
        private int _currentPosition = -1;

        public object Current
        {
            get
            {
                return _array[_currentPosition];
            }
        }

        public Iterator(int[] array)
        {
            _array = array;
        }

        public bool MoveNext()
        {
            if (_currentPosition < _array.Length - 1)
            {
                _currentPosition++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _currentPosition = -1;
        }
    }
}