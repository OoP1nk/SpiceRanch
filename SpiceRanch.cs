using SpiceRanch.managers;
using System.Runtime.InteropServices;

namespace SpiceRanch
{
    internal static class SpiceRanch
    {
        private static ProductManager productManager;
        private static ClientManager clientManager;
        private static OrderManager orderManager;
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialise Managers
            productManager = new ProductManager();
            clientManager = new ClientManager();
            orderManager = new OrderManager();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new OrderForm());
        }

        public static ProductManager GetProductManager()
        {
            return productManager;
        }
        public static ClientManager GetClientManager()
        {
            return clientManager;
        }

        public static OrderManager GetOrderManager()
        {
            return orderManager;
        }
    }
}