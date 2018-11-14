using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class HashNode
    {
        public string Key { get; set; }
        public string Value { get; set; }

        /// <summary>
        /// Building a node requires a value and key
        /// </summary>
        /// <param name="key">Key for node</param>
        /// <param name="value">Value for node</param>
        public HashNode(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
