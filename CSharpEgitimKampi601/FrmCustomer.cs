using Npgsql;
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
	public partial class FrmCustomer : Form
	{
		public FrmCustomer()
		{
			InitializeComponent();
		}

		string connectionString = "Server=localhost;port=5432;Database=CustomerDb;user Id=postgres;Password=Onur123";

		void GetAllCustomers()
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "SELECT * FROM Customers";
			var command = new NpgsqlCommand(query, connection);
			var adapter = new NpgsqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			connection.Close();
		}

		private void btnCustomerList_Click(object sender, EventArgs e)
		{
			GetAllCustomers();
		}

		private void btnCustomerCreate_Click(object sender, EventArgs e)
		{
			string CustomerName = txtCustomerName.Text;
			string CustomerSurname = txtCustomerSurname.Text;
			string CustomerCity = txtCustomerCity.Text;
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "INSERT INTO Customers (CustomerName, CustomerSurname, CustomerCity) VALUES (@customerName, @customerSurname, @customerCity)";
			var command = new NpgsqlCommand(query, connection);
			command.Parameters.AddWithValue("@customerName", CustomerName);
			command.Parameters.AddWithValue("@customerSurname", CustomerSurname);
			command.Parameters.AddWithValue("@customerCity", CustomerCity);
			command.ExecuteNonQuery();
			MessageBox.Show("Müşteri başarıyla eklendi.");
			connection.Close();
			GetAllCustomers();
		}

		private void btnCustomerDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtCustomerId.Text);
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "DELETE FROM Customers WHERE CustomerId = @customerId";
			var command = new NpgsqlCommand(query, connection);
			command.Parameters.AddWithValue("@customerId", id);
			command.ExecuteNonQuery();
			MessageBox.Show("Müşteri başarıyla silindi.");
			connection.Close();
			GetAllCustomers();
		}

		private void btnCustomerUpdate_Click(object sender, EventArgs e)
		{
			string CustomerName = txtCustomerName.Text;
			string CustomerSurname = txtCustomerSurname.Text;
			string CustomerCity = txtCustomerCity.Text;
			int id = int.Parse(txtCustomerId.Text);
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "UPDATE Customers SET CustomerName = @customerName, CustomerSurname = @customerSurname, CustomerCity = @customerCity WHERE CustomerId = @customerId";
			var command = new NpgsqlCommand(query, connection);
			command.Parameters.AddWithValue("@customerName", CustomerName);
			command.Parameters.AddWithValue("@customerSurname", CustomerSurname);
			command.Parameters.AddWithValue("@customerCity", CustomerCity);
			command.Parameters.AddWithValue("@customerId", id);
			command.ExecuteNonQuery();
			MessageBox.Show("Müşteri başarıyla güncellendi.");
			connection.Close();
			GetAllCustomers();
		}
	}
}
