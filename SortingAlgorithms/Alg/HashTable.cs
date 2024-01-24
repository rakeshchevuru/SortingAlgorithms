

/* Algorithm
 * 
 * 1. Initialize the hash table with -1
 * 2. Find the key using data % size
 * 3. if hash table[key] is available i.r -1 insert the data
 * 4. Else there is a collision. So increment the key value by 1 continuously 
 *    key = (key + 1) % size until finding the next available index
 * 5. If any index available, insert the data
 * 6. In the process, if we again reach the starting point, we can understant that we have traversed the whole hash table and coludnt find the index
 * 
 *  Linear Probing: f(x) = (x + i) % size       : Checks/Uses for the next element
 *  
 *  Quadratic Probing: f(x) = (x + i^2) % size  : i = 1,2,3,4..etc
 *  
 *  Linear probing is also called as closed hashing
 *  
 *  Open hashing/Seperate Chaining
 * 
 */

namespace SortingAlgorithms.Alg
{
    internal class HashTable
    {
        public int[] Arr { get; set; }
        public int size { get; set; }

        public HashTable(int HashSize)
        {
            size = HashSize;
            Arr = new int[size];

            Array.Fill(Arr, -1);
        }

        public int insert(int value)
        {
            var key = value % size;
            var index = key;

            while (Arr[index] != -1) 
            { 
                index = (index + 1) % size;

                if(index == key)
                {
                    Console.WriteLine("Hash Table Full");
                    return 0;
                }
            }

            Arr[index] = value;

            return 1;
        }

        public int del(int value)
        {
            var key = value % size;
            var index = key;

            while (Arr[index] != -1)
            {
                index = (index + 1) % size;

                if (index == key)
                {
                    return 0;
                }
            }

            Arr[index] = -1;

            return 1;
        }


        public int search(int value)
        {
            var key = value % size;
            var index = key;

            while (Arr[index] != -1)
            {
                index = (index + 1) % size;

                if (index == key)
                {
                    return 0;
                }
            }

            return 1;
        }

    }

    internal class HashTableOpenHash
    {
        public LinkedList<int>[] Arr { get; set; }
        public int size { get; set; }

        public HashTableOpenHash(int HashSize)
        {
            size = HashSize;
            Arr = new LinkedList<int>[size];

            Array.Fill(Arr, null);
        }

        public int insert(int value)
        {
            var key = value % size;
            var index = key;

            if (Arr[index] == null)
            {
                var node = new LinkedList<int>();
                node.AddLast(value);
                Arr[index] = node;               
            }
            else
            {
                Arr[index].AddLast(value);
            }

            return 1;
        }

        public int del(int value)
        {
            var key = value % size;
            var index = key;

            if (Arr[index] == null)
            {
                return 0;
            }
            else
            {
                if (Arr[index].Contains(value))
                {
                    Arr[index].Remove(value);

                    if (Arr[index].Count == 0)
                        Arr[index] = null;

                    return 1;
                }
            }

            return 0;
        }


        public int search(int value)
        {
            var key = value % size;
            var index = key;

            if (Arr[index] == null)
            {
                return 0;
            }
            else
            {
                if (Arr[index].Contains(value))
                {
                    return 1;
                }
            }

            return 0;
        }

    }
}