﻿using System;
using System.Collections.Generic;

namespace Indexer
{
    public class HttpCookie
    {
        //dictionary => datatype that use hash table to store data
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return _dictionary[key];}
            set { _dictionary[key] = value; }
        }
    }
}