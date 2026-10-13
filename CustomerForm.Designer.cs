namespace WinFormUI
{
    partial class CustomerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnGetCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.DataGridView dataGridView1;

        private void InitializeComponent()
        {
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnGetCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            // lblCustomerId
            this.lblCustomerId.Text = "Customer Id:";
            this.lblCustomerId.Location = new System.Drawing.Point(20, 20);
            this.lblCustomerId.Size = new System.Drawing.Size(90, 23);

            // txtCustomerId
            this.txtCustomerId.Location = new System.Drawing.Point(120, 17);
            this.txtCustomerId.Size = new System.Drawing.Size(120, 23);

            // lblName
            this.lblName.Text = "Name:";
            this.lblName.Location = new System.Drawing.Point(20, 55);
            this.lblName.Size = new System.Drawing.Size(90, 23);

            // txtName
            this.txtName.Location = new System.Drawing.Point(120, 52);
            this.txtName.Size = new System.Drawing.Size(220, 23);

            // lblEmail
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(20, 90);
            this.lblEmail.Size = new System.Drawing.Size(90, 23);

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(120, 87);
            this.txtEmail.Size = new System.Drawing.Size(220, 23);

            // btnAddCustomer
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.Location = new System.Drawing.Point(20, 130);
            this.btnAddCustomer.Size = new System.Drawing.Size(110, 30);
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);

            // btnGetCustomer
            this.btnGetCustomer.Text = "Get Customer";
            this.btnGetCustomer.Location = new System.Drawing.Point(140, 130);
            this.btnGetCustomer.Size = new System.Drawing.Size(110, 30);
            this.btnGetCustomer.Click += new System.EventHandler(this.btnGetCustomer_Click);

            // btnUpdateCustomer
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.Location = new System.Drawing.Point(260, 130);
            this.btnUpdateCustomer.Size = new System.Drawing.Size(120, 30);
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);

            // btnDeleteCustomer
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.Location = new System.Drawing.Point(390, 130);
            this.btnDeleteCustomer.Size = new System.Drawing.Size(120, 30);
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);

            // dataGridView1
            this.dataGridView1.Location = new System.Drawing.Point(20, 175);
            this.dataGridView1.Size = new System.Drawing.Size(540, 260);
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);

            // CustomerForm
            this.ClientSize = new System.Drawing.Size(580, 460);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnGetCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.dataGridView1);
            this.Text = "Customer Management - 3-Tier WinForms";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
        }
    }
}
