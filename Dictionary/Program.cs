using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Elvan");
            myDictionary.Add(2, "Ayşe");
            myDictionary.DictionaryList();
        }
    }
}
