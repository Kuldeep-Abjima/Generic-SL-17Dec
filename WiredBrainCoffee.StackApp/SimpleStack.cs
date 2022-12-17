using System.Transactions;

namespace WiredBrainCoffee
{
    public class SimpleStack<T>
    {
        private readonly T[] _item;
        private int _CurrentIndex = -1;

        public SimpleStack() => _item = new T[10];
        public int Count => _CurrentIndex+ 1;
        public void push(T item) => _item[++_CurrentIndex] = item;

        public T pop() => _item[_CurrentIndex--];
    }

//    public class SimpleStackString
//    {

//        private readonly string[] _items;
//        private int _currentIndex = -1;
//        public SimpleStackString() => _items = new string[10];


//        public int count => _currentIndex + 1;
//        public void Push(string item)
//        {

//            _items[++_currentIndex] = item;

//        }
//        public string Pop() => _items[_currentIndex--];
//    }


//}
//    public class SimpleStackDouble
//    {
//        private readonly double[] _items;
//        private int _currentIndex = -1;
//        public SimpleStackDouble() => _items = new double[10];


//        public int count => _currentIndex + 1;
//        public void Push(double item)
//        {

//            _items[++_currentIndex] = item;

//        }
//        public double Pop() => _items[_currentIndex--];
//    }
}