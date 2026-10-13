using System;
using System.Windows.Forms;
using BLL;
using DAL;

namespace WinFormUI
{
    public partial class CustomerForm : Form
    {
        private readonly CustomerService customerService;

        public CustomerForm()
        {
            InitializeComponent();
            customerService = new CustomerService();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            try
            {
                var customers = customerService.GetAllCustomers();
                dataGridView1.DataSource = customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load customers: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                customerService.AddCustomer(txtName.Text, txtEmail.Text);
                MessageBox.Show("Customer added successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtCustomerId.Text);
                Customer customer = customerService.GetCustomerById(id);
                if (customer != null)
                {
                    txtName.Text = customer.Name;
                    txtEmail.Text = customer.Email;
                }
                else
                {
                    MessageBox.Show("Customer not found.", "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric Customer Id.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtCustomerId.Text);
                customerService.UpdateCustomer(id, txtName.Text, txtEmail.Text);
                MessageBox.Show("Customer updated successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadCustomers();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric Customer Id.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtCustomerId.Text);
                var confirm = MessageBox.Show("Delete this customer?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    customerService.DeleteCustomer(id);
                    MessageBox.Show("Customer deleted.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                    LoadCustomers();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric Customer Id.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Customer c = dataGridView1.CurrentRow != null
                ? dataGridView1.CurrentRow.DataBoundItem as Customer
                : null;
            if (c != null)
            {
                txtCustomerId.Text = c.Id.ToString();
                txtName.Text = c.Name;
                txtEmail.Text = c.Email;
            }
        }

        private void ClearInputs()
        {
            txtCustomerId.Clear();
            txtName.Clear();
            txtEmail.Clear();
        }
    }
}
