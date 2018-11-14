using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    class Hashtable
    {
        private HashNode[] storage = new HashNode[1024];
            
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
