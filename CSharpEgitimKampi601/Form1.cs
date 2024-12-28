using CSharpEgitimKampi601.Entities;
using CSharpEgitimKampi601.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		CustomerOperations customerOperations = new CustomerOperations();
		private void btnAdd_Click(object sender, EventArgs e)
		{
			var customer = new Entities.Customer
			{
				CustomerName = txtCustomerName.Text,
				CustomerSurname = txtCustomerSurname.Text,
				CustomerCity = txtCustomerCity.Text,
				CustomerBalance = decimal.Parse(txtCustomerBalace.Text),
				CustomerShoppingCount = int.Parse(txtCustomerShoppingCount.Text)
			};

			customerOperations.AddCustomer(customer);
			MessageBox.Show("Müşteri başarıyla eklendi.", "Uyarı", MessageBoxButtons.OK ,MessageBoxIcon.Question);
		}

		private void btnCustomerList_Click(object sender, EventArgs e)
		{
			List<Customer> customers = customerOperations.GetAllCustomers();
			dataGridView1.DataSource = customers;
		}

		private void btnCustomerDelete_Click(object sender, EventArgs e)
		{
			string customerId = txtCustomerId.Text;
			customerOperations.DeleteCustomer(customerId);
			MessageBox.Show("Müşteri başarıyla silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
		}

		private void btnCustomerUpdate_Click(object sender, EventArgs e)
		{
			string id = txtCustomerId.Text;
			var uptadedCustomer = new Entities.Customer
			{
				CustomerName = txtCustomerName.Text,
				CustomerSurname = txtCustomerSurname.Text,
				CustomerCity = txtCustomerCity.Text,
				CustomerBalance = decimal.Parse(txtCustomerBalace.Text),
				CustomerShoppingCount = int.Parse(txtCustomerShoppingCount.Text),
				CustomerId = id
			};
			customerOperations.UpdateCustomer(uptadedCustomer);
			MessageBox.Show("Müşteri başarıyla güncellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
		}

		private void btnGetByCustomerId_Click(object sender, EventArgs e)
		{
			string id = txtCustomerId.Text;
			Customer customer = customerOperations.GetCustomerById(id);
			dataGridView1.DataSource = new List<Customer> { customer };
		}
	}
}
