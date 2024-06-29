using System.Collections;

namespace _24_Enumerators
{
    // Implementing IEnumerable interface in FiveIntegers class to make it iterable 
    // IEnumerable interface has only one method GetEnumerator that returns IEnumerator object 
    // IEnumerable is like a counter that iterates over a collection of objects 
    class FiveIntegers : IEnumerable
    {
        private int[] _values = new int[5];

        public FiveIntegers(int number1, int number2, int number3, int number4, int number5)
        {
            _values = new int[] { number1, number2, number3, number4, number5 };
        }

        // Implementing GetEnumerator method of IEnumerable interface
        // Modern way of implementing IEnumerable interface => You can use this way if you are using C# 8.0 or later 
        // yield return statement is used to return IEnumerator object in GetEnumerator method
        // yield under the hood creates an IEnumerator object and returns it 
        public IEnumerator GetEnumerator()
        {
            foreach (var item in _values)
            {
                // We can use yield return statement to return IEnumerator object in GetEnumerator method
                yield return item;
            }
        }




        //public IEnumerator GetEnumerator() => new FiveIntegersEnumerator(this);

        // This is an old way of implementing IEnumerable interface => You can use this way if you are not using C# 8.0 or later
        // We can use yield return statement to return IEnumerator object in GetEnumerator method
        // Nested class FiveIntegersEnumerator that implements IEnumerator interface
        //class FiveIntegersEnumerator : IEnumerator
        //{
        //    private FiveIntegers _fiveIntegers;
        //    private int _currentIndex = -1;

        //    public FiveIntegersEnumerator(FiveIntegers fiveIntegers)
        //    {
        //        _fiveIntegers = fiveIntegers;
        //    }

        //    public object Current
        //    {
        //        get
        //        {
        //            if (_currentIndex == -1)
        //            {
        //                throw new InvalidOperationException("Enumeration has not started.");
        //            }

        //            if (_currentIndex > _fiveIntegers._values.Length - 1)
        //            {
        //                throw new InvalidOperationException("Enumeration has finished.");
        //            }

        //            return _fiveIntegers._values[_currentIndex];
        //        }
        //    }

        //    public bool MoveNext()
        //    {
        //        if (_currentIndex >= _fiveIntegers._values.Length - 1)
        //        {
        //            return false;
        //        }

        //        return ++_currentIndex < _fiveIntegers._values.Length;
        //    }

        //    public void Reset()
        //    {
        //        _currentIndex = -1;
        //    }
        //}
    }
}
