using System;
using System.Collections;
using System.Runtime;

namespace SpiceRanch.structures
{
    internal class Product
    {
        public int id { get; set; }
        public string uuid { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string? size { get; set; }
        public string[] sides { get; set; }
    }
}
