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
	public partial class FrmEmployee : Form
	{
		public FrmEmployee()
		{
			InitializeComponent();
		}

		string connectionString = "Server=localhost;port=5432;Database=CustomerDb;user Id=postgres;Password=Onur123";

		void EmployeeList()
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "SELECT * FROM Employess";
			var command = new NpgsqlCommand(query, connection);
			var adapter = new NpgsqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			connection.Close();
		}

		void DepartmentList()
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "SELECT * FROM Departments";
			var command = new NpgsqlCommand(query, connection);
			var adapter = new NpgsqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			cmbEmployeeDepartment.DisplayMember = "DepartmentName";
			cmbEmployeeDepartment.ValueMember = "DepartmentId";
			cmbEmployeeDepartment.DataSource = dataTable;
			connection.Close();
		}
		private void btnList_Click(object sender, EventArgs e)
		{
			EmployeeList();
		}

		private void FrmEmployee_Load(object sender, EventArgs e)
		{
			EmployeeList();
			DepartmentList();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			string employeeName = txtEmployeeName.Text;
			string employeeSurname = txtEmployeeSurname.Text;
			decimal employeeSalary = decimal.Parse(txtEmployeeSalary.Text);
			int departmentId = int.Parse(cmbEmployeeDepartment.SelectedValue.ToString());

			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "INSERT INTO Employess (EmployeeName, EmployeeSurname, EmployeeSalary, DepartmentId) VALUES (@employeeName, @employeeSurname, @employeeSalary, @departmentId)";
			var command = new NpgsqlCommand(query, connection);
			command.Parameters.AddWithValue("@employeeName", employeeName);
			command.Parameters.AddWithValue("@employeeSurname", employeeSurname);
			command.Parameters.AddWithValue("@employeeSalary", employeeSalary);
			command.Parameters.AddWithValue("@departmentId", departmentId);
			command.ExecuteNonQuery();
			MessageBox.Show("Çalışan başarıyla eklendi.");
			connection.Close();
			EmployeeList();
		}
	}
}
