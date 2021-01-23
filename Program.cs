using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Salih");
            myDictionary.Add(2, "Sema");
            Console.WriteLine(myDictionary.Count);

        }
        class MyDictionary<Tkey, Tvalue>
        {
            Tkey[] _key;
            Tvalue[] _value;
            Tkey[] _tempKey;
            Tvalue[] _tempValue;
            public MyDictionary()
            {
                _key = new Tkey[0];
                _value = new Tvalue[0];
            }
            public void Add(Tkey key,Tvalue value)
            {
                _tempKey = _key;
                _tempValue = _value;

                _key = new Tkey[_key.Length + 1];
                _value = new Tvalue[_value.Length + 1];

                for (int i = 0; i < _tempKey.Length; i++)
                {
                    _tempKey[i] = _key[i];
                    _tempValue[i] = _value[i];
                }
                _key[_key.Length - 1] = key;
                _value[_value.Length - 1] = value;
            }
            public int Count
            {
                get { return _key.Length; }
            }
        
        }
    }
}
