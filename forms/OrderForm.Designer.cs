namespace SpiceRanch
{
    partial class OrderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.rdoDelivery = new System.Windows.Forms.RadioButton();
            this.rdoCollection = new System.Windows.Forms.RadioButton();
            this.cmboItems = new System.Windows.Forms.ComboBox();
            this.scrlQuantity = new System.Windows.Forms.HScrollBar();
            this.lstbBastket = new System.Windows.Forms.ListBox();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.cmbHelp = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblOrderNow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOrder = new System.Windows.Forms.Button();
            this.lblBasket = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlNav.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(652, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rdoDelivery
            // 
            this.rdoDelivery.AutoSize = true;
            this.rdoDelivery.Location = new System.Drawing.Point(225, 104);
            this.rdoDelivery.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.rdoDelivery.Name = "rdoDelivery";
            this.rdoDelivery.Size = new System.Drawing.Size(68, 21);
            this.rdoDelivery.TabIndex = 2;
            this.rdoDelivery.TabStop = true;
            this.rdoDelivery.Text = "Delivery";
            this.rdoDelivery.UseVisualStyleBackColor = true;
            // 
            // rdoCollection
            // 
            this.rdoCollection.AutoSize = true;
            this.rdoCollection.Location = new System.Drawing.Point(225, 135);
            this.rdoCollection.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.rdoCollection.Name = "rdoCollection";
            this.rdoCollection.Size = new System.Drawing.Size(80, 21);
            this.rdoCollection.TabIndex = 3;
            this.rdoCollection.TabStop = true;
            this.rdoCollection.Text = "Collection";
            this.rdoCollection.UseVisualStyleBackColor = true;
            // 
            // cmboItems
            // 
            this.cmboItems.FormattingEnabled = true;
            this.cmboItems.Location = new System.Drawing.Point(225, 55);
            this.cmboItems.Name = "cmboItems";
            this.cmboItems.Size = new System.Drawing.Size(201, 25);
            this.cmboItems.TabIndex = 4;
            this.cmboItems.Text = "Select an Item";
            // 
            // scrlQuantity
            // 
            this.scrlQuantity.Location = new System.Drawing.Point(225, 83);
            this.scrlQuantity.Maximum = 10;
            this.scrlQuantity.Minimum = 1;
            this.scrlQuantity.Name = "scrlQuantity";
            this.scrlQuantity.Size = new System.Drawing.Size(201, 17);
            this.scrlQuantity.TabIndex = 5;
            this.scrlQuantity.Value = 1;
            this.scrlQuantity.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlQuantity_Scroll);
            // 
            // lstbBastket
            // 
            this.lstbBastket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstbBastket.FormattingEnabled = true;
            this.lstbBastket.ItemHeight = 17;
            this.lstbBastket.Location = new System.Drawing.Point(446, 47);
            this.lstbBastket.Name = "lstbBastket";
            this.lstbBastket.Size = new System.Drawing.Size(195, 274);
            this.lstbBastket.TabIndex = 6;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlNav.Controls.Add(this.cmbHelp);
            this.pnlNav.Controls.Add(this.pnlLogo);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(130, 340);
            this.pnlNav.TabIndex = 8;
            // 
            // cmbHelp
            // 
            this.cmbHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmbHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbHelp.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.cmbHelp.FlatAppearance.BorderSize = 2;
            this.cmbHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHelp.ForeColor = System.Drawing.Color.White;
            this.cmbHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbHelp.Location = new System.Drawing.Point(0, 296);
            this.cmbHelp.Margin = new System.Windows.Forms.Padding(0);
            this.cmbHelp.Name = "cmbHelp";
            this.cmbHelp.Size = new System.Drawing.Size(130, 44);
            this.cmbHelp.TabIndex = 9;
            this.cmbHelp.Text = "Need Help?";
            this.cmbHelp.UseVisualStyleBackColor = false;
            this.cmbHelp.Click += new System.EventHandler(this.cmbHelp_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(130, 100);
            this.pnlLogo.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SpiceRanch.Properties.Resources.spiceranch2;
            this.pictureBox1.Location = new System.Drawing.Point(35, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblOrderNow
            // 
            this.lblOrderNow.AutoSize = true;
            this.lblOrderNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOrderNow.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrderNow.Location = new System.Drawing.Point(136, 9);
            this.lblOrderNow.Name = "lblOrderNow";
            this.lblOrderNow.Size = new System.Drawing.Size(165, 35);
            this.lblOrderNow.TabIndex = 9;
            this.lblOrderNow.Text = "Order Now!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Select a Dish:";
            // 
            // cmbOrder
            // 
            this.cmbOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbOrder.Location = new System.Drawing.Point(225, 180);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(90, 31);
            this.cmbOrder.TabIndex = 13;
            this.cmbOrder.Text = "Order Now!";
            this.cmbOrder.UseVisualStyleBackColor = true;
            this.cmbOrder.Click += new System.EventHandler(this.cmbOrder_Click);
            // 
            // lblBasket
            // 
            this.lblBasket.AutoSize = true;
            this.lblBasket.Location = new System.Drawing.Point(446, 27);
            this.lblBasket.Name = "lblBasket";
            this.lblBasket.Size = new System.Drawing.Size(42, 17);
            this.lblBasket.TabIndex = 14;
            this.lblBasket.Text = "Basket";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(225, 160);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(38, 17);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total:";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(676, 340);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblBasket);
            this.Controls.Add(this.cmbOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOrderNow);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.lstbBastket);
            this.Controls.Add(this.scrlQuantity);
            this.Controls.Add(this.cmboItems);
            this.Controls.Add(this.rdoCollection);
            this.Controls.Add(this.rdoDelivery);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpiceRanch";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.pnlNav.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnClose;
        private RadioButton rdoDelivery;
        private RadioButton rdoCollection;
        private ComboBox cmboItems;
        private HScrollBar scrlQuantity;
        private ListBox lstbBastket;
        private Panel pnlNav;
        private Panel pnlLogo;
        private PictureBox pictureBox1;
        private Button cmbHelp;
        private Label lblOrderNow;
        private Label label3;
        private Button cmbOrder;
        private Label lblBasket;
        private Label lblTotal;
    }
}