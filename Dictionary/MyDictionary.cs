using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<K,V>
    {
        K[] index;
        V[] name;

        K[] indexEmanet;//var olan diizlerimizi tutacaklar
        V[] nameEmanet;
        public MyDictionary()
        {
            index = new K[0];
            name = new V[0];
        }
        public void Add(K key,V value)
        {
            indexEmanet = index;
            nameEmanet = name;

            name = new V[name.Length + 1];
            index = new K[index.Length + 1];

            for(int i = 0; i < nameEmanet.Length; i++)
            {
                name[i] = nameEmanet[i];
                index[i] = indexEmanet[i];
            }
            name[name.Length - 1] = value;
            index[index.Length - 1] = key;

            Console.WriteLine(value + " başarıyla eklendi");
            DictionaryList();
        }
        public void DictionaryList()
        {
            Console.WriteLine("-------Tüm Liste--------");
            for(int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(index[i] + "  -->  " + name[i]);
            }
            Console.WriteLine(index.Length+" adet veri");
        }
    }
}
