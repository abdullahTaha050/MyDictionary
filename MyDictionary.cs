using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] _tempKey;
        TValue[] _tempValue;
        TKey[] _key;
        TValue[] _value;

        public MyDictionary()
        {
            _key = new TKey[0];
            _value = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            _tempValue = _value;
            _tempKey = _key;

            _value = new TValue[_tempValue.Length + 1];
            _key = new TKey[_tempKey.Length + 1];

            for (int i = 0; i < _tempValue.Length; i++)
            {
                _value[i] = _tempValue[i];
            }

            for (int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
            }

            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;
        }

        public int Length
        {
            get { return _key.Length; }
        }

        public void Show()
        {
            for (int i = 0; i < _key.Length; i++)
            {
                Console.WriteLine("Key = " + _key[i] + " Value = " + _value[i]);
            }
        }

    }
}
