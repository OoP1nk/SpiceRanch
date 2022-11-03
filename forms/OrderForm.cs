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
        private int quantity;
        private double total;

        private readonly double deliveryCharge = 1.99;

        private void OrderForm_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15,15));
            foreach(Product product in SpiceRanch.GetProductManager().GetProducts())
            {
                cmboItems.Items.Add(product.name + " - " + product.price);
            }
            lblTotal.Text = "Total: 0";
            lstbBastket.Text = "";
            scrlQuantity.Value = 1;
        }

        private void scrlQuantity_Scroll(object sender, ScrollEventArgs e)
        {
            quantity = e.NewValue;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbHelp_Click(object sender, EventArgs e)
        {
            helpForm.ShowDialog();
        }

        private void cmbOrder_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}