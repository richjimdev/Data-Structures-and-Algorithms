using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    class Hashtable
    {
        private HashNode[] storage = new HashNode[1024];

        /// <summary>
        /// Adds a node to the hashtable
        /// </summary>
        /// <param name="key">Key for new node</param>
        /// <param name="value">Value for new node</param>
        public void Add(string key, string value)
        {
            int idx = GetHashKey(key);
            HashNode newNode = new HashNode(key, value);

            if (storage[idx] == null) storage[idx] = newNode;
            else
            {
                HashNode head = storage[idx];
                while (head.Next != null)
                {
                    head = head.Next;
                }

                head.Next = newNode;
            }
        }

        /// <summary>
        /// Check if key is found in hashtable
        /// </summary>
        /// <param name="key">Key to search</param>
        /// <returns>True or False</returns>
        public bool Contains(string key)
        {
            int idx = GetHashKey(key);
            if (storage[idx] == null) return false;
            else
            {
                HashNode head = storage[idx];

                while (head != null)
                {
                    if (head.Key == key) return true;
                    head = head.Next;
                }

                return false;
            }
        }

        /// <summary>
        /// Finds a key and returns it's value if found
        /// </summary>
        /// <param name="key">Key search term</param>
        /// <returns>Value of found key</returns>
        public string Find(string key)
        {
            if (Contains(key))
            {
                int idx = GetHashKey(key);

                HashNode head = storage[idx];

                while (head != null)
                {
                    if (head.Key == key) return head.Value;
                    head = head.Next;
                }
            }

            return "Not Found";
        }
            
        /// <summary>
        /// Gets an index from input key to put into hash array
        /// </summary>
        /// <param name="key">Key to hash</param>
        /// <returns>Index number</returns>
        public int GetHashKey(string key)
        {
            int hashed = 0;

            for (int i = 0; i < key.Length; i++)
            {
                hashed += key[i];
            }

            return hashed % storage.Length;
        }
    }
}
