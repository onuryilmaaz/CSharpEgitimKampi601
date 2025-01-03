namespace CSharpEgitimKampi601
{
	partial class FrmEmployee
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnGetById = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.txtEmployeeSalary = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEmployeeSurname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEmployeeName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnList = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtEmployeeId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbEmployeeDepartment = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGetById
			// 
			this.btnGetById.BackColor = System.Drawing.Color.SkyBlue;
			this.btnGetById.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGetById.Location = new System.Drawing.Point(125, 429);
			this.btnGetById.Name = "btnGetById";
			this.btnGetById.Size = new System.Drawing.Size(189, 39);
			this.btnGetById.TabIndex = 49;
			this.btnGetById.Text = "Id\'ye Göre Getir";
			this.btnGetById.UseVisualStyleBackColor = false;
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.SkyBlue;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdate.Location = new System.Drawing.Point(125, 384);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(189, 39);
			this.btnUpdate.TabIndex = 48;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = false;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.SkyBlue;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDelete.Location = new System.Drawing.Point(125, 339);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(189, 39);
			this.btnDelete.TabIndex = 47;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = false;
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.Color.SkyBlue;
			this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCreate.Location = new System.Drawing.Point(125, 294);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(189, 39);
			this.btnCreate.TabIndex = 46;
			this.btnCreate.Text = "Ekle";
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// txtEmployeeSalary
			// 
			this.txtEmployeeSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtEmployeeSalary.Location = new System.Drawing.Point(125, 158);
			this.txtEmployeeSalary.Name = "txtEmployeeSalary";
			this.txtEmployeeSalary.Size = new System.Drawing.Size(189, 26);
			this.txtEmployeeSalary.TabIndex = 45;
			this.txtEmployeeSalary.Text = " ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(8, 158);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 20);
			this.label4.TabIndex = 44;
			this.label4.Text = "Personel Maaş:";
			// 
			// txtEmployeeSurname
			// 
			this.txtEmployeeSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtEmployeeSurname.Location = new System.Drawing.Point(125, 113);
			this.txtEmployeeSurname.Name = "txtEmployeeSurname";
			this.txtEmployeeSurname.Size = new System.Drawing.Size(189, 26);
			this.txtEmployeeSurname.TabIndex = 43;
			this.txtEmployeeSurname.Text = " ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(-1, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(127, 20);
			this.label3.TabIndex = 42;
			this.label3.Text = "Personel Soyadı:";
			// 
			// txtEmployeeName
			// 
			this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtEmployeeName.Location = new System.Drawing.Point(125, 68);
			this.txtEmployeeName.Name = "txtEmployeeName";
			this.txtEmployeeName.Size = new System.Drawing.Size(189, 26);
			this.txtEmployeeName.TabIndex = 41;
			this.txtEmployeeName.Text = " ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(24, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 20);
			this.label2.TabIndex = 40;
			this.label2.Text = "Personel Adı:";
			// 
			// btnList
			// 
			this.btnList.BackColor = System.Drawing.Color.SkyBlue;
			this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnList.Location = new System.Drawing.Point(125, 249);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(189, 39);
			this.btnList.TabIndex = 39;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = false;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(351, 24);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 45;
			this.dataGridView1.Size = new System.Drawing.Size(900, 444);
			this.dataGridView1.TabIndex = 38;
			// 
			// txtEmployeeId
			// 
			this.txtEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtEmployeeId.Location = new System.Drawing.Point(125, 24);
			this.txtEmployeeId.Name = "txtEmployeeId";
			this.txtEmployeeId.Size = new System.Drawing.Size(189, 26);
			this.txtEmployeeId.TabIndex = 37;
			this.txtEmployeeId.Text = " ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(33, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 20);
			this.label1.TabIndex = 36;
			this.label1.Text = "Personel Id:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(33, 202);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(93, 20);
			this.label5.TabIndex = 50;
			this.label5.Text = "Departman:";
			// 
			// cmbEmployeeDepartment
			// 
			this.cmbEmployeeDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F);
			this.cmbEmployeeDepartment.FormattingEnabled = true;
			this.cmbEmployeeDepartment.Location = new System.Drawing.Point(125, 201);
			this.cmbEmployeeDepartment.Name = "cmbEmployeeDepartment";
			this.cmbEmployeeDepartment.Size = new System.Drawing.Size(189, 28);
			this.cmbEmployeeDepartment.TabIndex = 51;
			// 
			// FrmEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1262, 492);
			this.Controls.Add(this.cmbEmployeeDepartment);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnGetById);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtEmployeeSalary);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtEmployeeSurname);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtEmployeeName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtEmployeeId);
			this.Controls.Add(this.label1);
			this.Name = "FrmEmployee";
			this.Text = "FrmEmployee";
			this.Load += new System.EventHandler(this.FrmEmployee_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGetById;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.TextBox txtEmployeeSalary;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEmployeeSurname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEmployeeName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtEmployeeId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbEmployeeDepartment;
	}
}