using Newtonsoft.Json;
using SpiceRanch.structures;
using System;

namespace SpiceRanch.managers
{
    internal class ProductManager
    {
        private readonly List<Product> products = new();
        public ProductManager()
        {
            this.products = JsonConvert.DeserializeObject<List<Product>>(Utils.APIRestProductResponse)!;
        }

        public List<Product> GetProducts() { return this.products; }
    }
}
