using SpiceRanch.structures;

namespace SpiceRanch.managers
{
    internal class OrderManager
    {
        private List<Order> orders = new();

        public OrderManager() {}

        public int GetId()
        {
            return this.orders.Count + 1;
        }

        public void AddOrder(Order order)
        {
            this.orders.Add(order);
        }

        public List<Order> GetOrders()
        {
            return this.orders;
        }
    }
}
