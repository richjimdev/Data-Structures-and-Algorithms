using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    class Hashtable
    {
        private HashNode[] storage = new HashNode[1024];

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
