﻿namespace CSharpEgitimKampi601
{
	partial class FrmCustomer
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
			this.btnGetByCustomerId = new System.Windows.Forms.Button();
			this.btnCustomerUpdate = new System.Windows.Forms.Button();
			this.btnCustomerDelete = new System.Windows.Forms.Button();
			this.btnCustomerCreate = new System.Windows.Forms.Button();
			this.txtCustomerCity = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCustomerSurname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCustomerList = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtCustomerId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGetByCustomerId
			// 
			this.btnGetByCustomerId.BackColor = System.Drawing.Color.IndianRed;
			this.btnGetByCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGetByCustomerId.Location = new System.Drawing.Point(122, 388);
			this.btnGetByCustomerId.Name = "btnGetByCustomerId";
			this.btnGetByCustomerId.Size = new System.Drawing.Size(189, 39);
			this.btnGetByCustomerId.TabIndex = 35;
			this.btnGetByCustomerId.Text = "Id\'ye Göre Getir";
			this.btnGetByCustomerId.UseVisualStyleBackColor = false;
			// 
			// btnCustomerUpdate
			// 
			this.btnCustomerUpdate.BackColor = System.Drawing.Color.IndianRed;
			this.btnCustomerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCustomerUpdate.Location = new System.Drawing.Point(122, 343);
			this.btnCustomerUpdate.Name = "btnCustomerUpdate";
			this.btnCustomerUpdate.Size = new System.Drawing.Size(189, 39);
			this.btnCustomerUpdate.TabIndex = 34;
			this.btnCustomerUpdate.Text = "Güncelle";
			this.btnCustomerUpdate.UseVisualStyleBackColor = false;
			this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
			// 
			// btnCustomerDelete
			// 
			this.btnCustomerDelete.BackColor = System.Drawing.Color.IndianRed;
			this.btnCustomerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCustomerDelete.Location = new System.Drawing.Point(122, 298);
			this.btnCustomerDelete.Name = "btnCustomerDelete";
			this.btnCustomerDelete.Size = new System.Drawing.Size(189, 39);
			this.btnCustomerDelete.TabIndex = 33;
			this.btnCustomerDelete.Text = "Sil";
			this.btnCustomerDelete.UseVisualStyleBackColor = false;
			this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
			// 
			// btnCustomerCreate
			// 
			this.btnCustomerCreate.BackColor = System.Drawing.Color.IndianRed;
			this.btnCustomerCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCustomerCreate.Location = new System.Drawing.Point(122, 253);
			this.btnCustomerCreate.Name = "btnCustomerCreate";
			this.btnCustomerCreate.Size = new System.Drawing.Size(189, 39);
			this.btnCustomerCreate.TabIndex = 32;
			this.btnCustomerCreate.Text = "Ekle";
			this.btnCustomerCreate.UseVisualStyleBackColor = false;
			this.btnCustomerCreate.Click += new System.EventHandler(this.btnCustomerCreate_Click);
			// 
			// txtCustomerCity
			// 
			this.txtCustomerCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCustomerCity.Location = new System.Drawing.Point(122, 158);
			this.txtCustomerCity.Name = "txtCustomerCity";
			this.txtCustomerCity.Size = new System.Drawing.Size(189, 26);
			this.txtCustomerCity.TabIndex = 27;
			this.txtCustomerCity.Text = " ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(11, 158);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 20);
			this.label4.TabIndex = 26;
			this.label4.Text = "Müşteri Şehir:";
			// 
			// txtCustomerSurname
			// 
			this.txtCustomerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCustomerSurname.Location = new System.Drawing.Point(122, 113);
			this.txtCustomerSurname.Name = "txtCustomerSurname";
			this.txtCustomerSurname.Size = new System.Drawing.Size(189, 26);
			this.txtCustomerSurname.TabIndex = 25;
			this.txtCustomerSurname.Text = " ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(0, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 20);
			this.label3.TabIndex = 24;
			this.label3.Text = "Müşteri Soyadı:";
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCustomerName.Location = new System.Drawing.Point(122, 68);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(189, 26);
			this.txtCustomerName.TabIndex = 23;
			this.txtCustomerName.Text = " ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(25, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 20);
			this.label2.TabIndex = 22;
			this.label2.Text = "Müşteri Adı:";
			// 
			// btnCustomerList
			// 
			this.btnCustomerList.BackColor = System.Drawing.Color.IndianRed;
			this.btnCustomerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCustomerList.Location = new System.Drawing.Point(122, 208);
			this.btnCustomerList.Name = "btnCustomerList";
			this.btnCustomerList.Size = new System.Drawing.Size(189, 39);
			this.btnCustomerList.TabIndex = 21;
			this.btnCustomerList.Text = "Listele";
			this.btnCustomerList.UseVisualStyleBackColor = false;
			this.btnCustomerList.Click += new System.EventHandler(this.btnCustomerList_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(348, 24);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 45;
			this.dataGridView1.Size = new System.Drawing.Size(900, 403);
			this.dataGridView1.TabIndex = 20;
			// 
			// txtCustomerId
			// 
			this.txtCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCustomerId.Location = new System.Drawing.Point(122, 24);
			this.txtCustomerId.Name = "txtCustomerId";
			this.txtCustomerId.Size = new System.Drawing.Size(189, 26);
			this.txtCustomerId.TabIndex = 19;
			this.txtCustomerId.Text = " ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(34, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 20);
			this.label1.TabIndex = 18;
			this.label1.Text = "Müşteri Id:";
			// 
			// FrmCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1263, 442);
			this.Controls.Add(this.btnGetByCustomerId);
			this.Controls.Add(this.btnCustomerUpdate);
			this.Controls.Add(this.btnCustomerDelete);
			this.Controls.Add(this.btnCustomerCreate);
			this.Controls.Add(this.txtCustomerCity);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCustomerSurname);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCustomerName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCustomerList);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtCustomerId);
			this.Controls.Add(this.label1);
			this.Name = "FrmCustomer";
			this.Text = "FrmCustomer";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGetByCustomerId;
		private System.Windows.Forms.Button btnCustomerUpdate;
		private System.Windows.Forms.Button btnCustomerDelete;
		private System.Windows.Forms.Button btnCustomerCreate;
		private System.Windows.Forms.TextBox txtCustomerCity;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCustomerSurname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCustomerList;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtCustomerId;
		private System.Windows.Forms.Label label1;
	}
}