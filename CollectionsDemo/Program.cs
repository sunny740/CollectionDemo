using System;

namespace CollectionsDemo
{
    class program
    {
        public static void Main(string[] args)
        {
            CollectionDemo collection = new CollectionDemo();
            collection.doListDemo();
            collection.doStackDemo();
            collection.doQueueDemo();
            collection.doSetDemo();
            collection.doDictionaryDemo();
        }
    }
}