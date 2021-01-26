using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K, V>
    {
        K[] _key;
        V[] _value;
        public MyDictionary()
        {
            _key = new K[0];
            _value = new V[0];
        }
        public void Add(K key, V value)
        {
            K[] tempKey = _key;
            V[] tempValue = _value;
            _key = new K[_key.Length + 1];
            _value = new V[_value.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                _key[i] = tempKey[i];
            }
            for (int j = 0; j < tempKey.Length; j++)
            {
                _value[j] = tempValue[j];
            }
            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;
        }
    }
}
