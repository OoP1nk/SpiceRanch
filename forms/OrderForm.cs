using System.Collections;
using System.Runtime.InteropServices;
using System.Text.Json.Nodes;
using System.Runtime.InteropServices;
using SpiceRanch.structures;

namespace SpiceRanch
{
    public partial class OrderForm : Form

    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public OrderForm()
        {
            InitializeComponent();
        }

        private HelpForm helpForm = new();

        private string name;
        private int quantity = 1;
        private double total;

        private readonly double deliveryCharge = 1.99;

        private void OrderForm_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15,15));
            foreach(Product product in SpiceRanch.GetProductManager().GetProducts())
            {
                var pstring = "";
                pstring += product.name;
                if (product.sides.Length > 0)
                {
                    pstring += " w/";
                    foreach (string side in product.sides)
                    {
                        pstring += $"{side},";
                    }
                }
                cmboItems.Items.Add($"{product.id}. {(product.size != null ? product.size : "")} {pstring} - {product.price}");
            }
            lblTotal.Text = "Total: 0";
            lstbBastket.Text = "";
            scrlQuantity.Value = this.quantity;
        }

        private void scrlQuantity_Scroll(object sender, ScrollEventArgs e)
        {
            this.quantity = scrlQuantity.Value;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbHelp_Click(object sender, EventArgs e)
        {
            helpForm.Show();
        }

        /**
         * Run whenever the "Order" button is clicked
         */
        private void cmbOrder_Click(object sender, EventArgs e)
        {
            string pId = cmboItems.Text.Split(".")[0];
            Product? product = SpiceRanch.GetProductManager().GetProduct(Int32.Parse(pId));
            if (product == null) return;

            var totalPrice = product.price * this.quantity;

            var pstring = "";
            pstring += product.name;
            if(product.sides.Length > 0)
            {
                pstring += " w/";
                foreach(string side in product.sides)
                {
                    pstring += $"{side},";
                }
            }

            Order order = new Order(SpiceRanch.GetOrderManager().GetId(), totalPrice, SpiceRanch.GetClientManager().GetActiveClient()!, product);
            SpiceRanch.GetOrderManager().AddOrder(order);

            this.setTotal();

            lstbBastket.Items.Add($"{pstring} x{this.quantity} - {totalPrice}");
        }

        private void setTotal()
        {
            double ftotal = 0.0;
            foreach(Order order in SpiceRanch.GetOrderManager().GetOrders())
            {
                ftotal += order.total;
            }

            if(rdoDelivery.Checked) { ftotal = ftotal + this.deliveryCharge; }
            else { ftotal = ftotal; }
            lblTotal.Text = $"Total: £{Math.Round(ftotal, 2)}";
        }
    }
}