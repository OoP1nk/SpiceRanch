using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SpiceRanch.structures
{
    internal class Order
    {
        public int id { get; set; }
        public string? uuid { get; set; }
        public double total { get; set; }
        public Client? client { get; set; }

        public Order(int id, double total, Client client, Product product)
        {
            this.id = id;
            this.uuid = client.uuid;
            this.total = total;
            this.client = client;
        }
    }
}
