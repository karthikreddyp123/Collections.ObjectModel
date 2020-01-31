using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.ObjectModel
{
    class ReadOnlyCollection
    {
        static void Main()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(3);
            list.Add(5);

            // Constructor.
            ReadOnlyCollection<int> readOnlyCollection = new ReadOnlyCollection<int>(list);

            // Loop over ReadOnlyCollection.
            foreach (int value in readOnlyCollection)
            {
                Console.WriteLine("read: {0}", value);
            }

            // Copy ReadOnlyCollection to an array.
            int[] array = new int[3];
            readOnlyCollection.CopyTo(array, 0);

            // Display array.
            foreach (int value in array)
            {
                Console.WriteLine("array: {0}", value);
            }

            // Use methods on ReadOnlyCollection.
            int count = readOnlyCollection.Count;
            bool contains = readOnlyCollection.Contains(-1);
            int index = readOnlyCollection.IndexOf(3);
            //Append operation doesnot actully append it to the collection
            readOnlyCollection.Append(100);
            Console.WriteLine("{0}, {1}, {2}", count, contains, index);
            Console.WriteLine("After Appending 100:");
            foreach (int value in readOnlyCollection)
            {
                Console.WriteLine("read: {0}", value);
            }
            Console.ReadLine();
        }
    }
}
