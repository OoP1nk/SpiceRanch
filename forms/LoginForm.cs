using SpiceRanch.structures;

namespace SpiceRanch.forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            string username = rtxtUsername.Text;
            string password = rtxtPassword.Text;
            Client? client = SpiceRanch.GetClientManager().Login(username, password);
            if (client != null)
            {
                this.Visible = false;
                OrderForm orderForm = new OrderForm();
                orderForm.Visible = true;
            }
            else
            {
                lblError.Text = Utils.ClientLoginError;
            }
        }
    }
}
