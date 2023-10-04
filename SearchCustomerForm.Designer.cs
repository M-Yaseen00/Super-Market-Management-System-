
namespace SuperMarket_Management_System_new_
{
	partial class SearchCustomerForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCustomerForm));
			this.dgvCust = new System.Windows.Forms.DataGridView();
			this.cCust_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cCust_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cCust_ph_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cCust_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cCNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtCNIC = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtPhoneNo = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label0 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.cboSearchBy = new System.Windows.Forms.ComboBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnclear = new System.Windows.Forms.Button();
			this.btnback = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvCust)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvCust
			// 
			this.dgvCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCust.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCust_Id,
            this.cCust_name,
            this.cCust_ph_no,
            this.cCust_address,
            this.Email,
            this.cCNIC});
			this.dgvCust.Location = new System.Drawing.Point(4, 315);
			this.dgvCust.Margin = new System.Windows.Forms.Padding(4);
			this.dgvCust.Name = "dgvCust";
			this.dgvCust.RowHeadersWidth = 51;
			this.dgvCust.Size = new System.Drawing.Size(891, 202);
			this.dgvCust.TabIndex = 16;
			this.dgvCust.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCust_CellClick);
			// 
			// cCust_Id
			// 
			this.cCust_Id.DataPropertyName = "Cust_Id";
			this.cCust_Id.HeaderText = "Cust Id";
			this.cCust_Id.MinimumWidth = 6;
			this.cCust_Id.Name = "cCust_Id";
			this.cCust_Id.Width = 125;
			// 
			// cCust_name
			// 
			this.cCust_name.DataPropertyName = "Cust_name";
			this.cCust_name.HeaderText = "Cust name";
			this.cCust_name.MinimumWidth = 6;
			this.cCust_name.Name = "cCust_name";
			this.cCust_name.Width = 125;
			// 
			// cCust_ph_no
			// 
			this.cCust_ph_no.DataPropertyName = "Cust_ph_no";
			this.cCust_ph_no.HeaderText = "Phone";
			this.cCust_ph_no.MinimumWidth = 6;
			this.cCust_ph_no.Name = "cCust_ph_no";
			this.cCust_ph_no.Width = 125;
			// 
			// cCust_address
			// 
			this.cCust_address.DataPropertyName = "Cust_address";
			this.cCust_address.HeaderText = "Address";
			this.cCust_address.MinimumWidth = 6;
			this.cCust_address.Name = "cCust_address";
			this.cCust_address.Width = 125;
			// 
			// Email
			// 
			this.Email.DataPropertyName = "Cust_Email";
			this.Email.HeaderText = "Email";
			this.Email.MinimumWidth = 6;
			this.Email.Name = "Email";
			this.Email.Width = 125;
			// 
			// cCNIC
			// 
			this.cCNIC.DataPropertyName = "Cust_CNIC";
			this.cCNIC.HeaderText = "CNIC";
			this.cCNIC.MinimumWidth = 6;
			this.cCNIC.Name = "cCNIC";
			this.cCNIC.Width = 125;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtCNIC);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.txtAddress);
			this.groupBox1.Controls.Add(this.txtPhoneNo);
			this.groupBox1.Controls.Add(this.txtID);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label0);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(4, 42);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(888, 265);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Customer Information";
			// 
			// txtCNIC
			// 
			this.txtCNIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCNIC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCNIC.Location = new System.Drawing.Point(188, 229);
			this.txtCNIC.Margin = new System.Windows.Forms.Padding(4);
			this.txtCNIC.Name = "txtCNIC";
			this.txtCNIC.Size = new System.Drawing.Size(674, 29);
			this.txtCNIC.TabIndex = 7;
			// 
			// txtEmail
			// 
			this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(188, 193);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(674, 29);
			this.txtEmail.TabIndex = 7;
			// 
			// txtAddress
			// 
			this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAddress.Location = new System.Drawing.Point(188, 156);
			this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(674, 29);
			this.txtAddress.TabIndex = 6;
			// 
			// txtPhoneNo
			// 
			this.txtPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPhoneNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPhoneNo.Location = new System.Drawing.Point(188, 119);
			this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(4);
			this.txtPhoneNo.Name = "txtPhoneNo";
			this.txtPhoneNo.Size = new System.Drawing.Size(674, 29);
			this.txtPhoneNo.TabIndex = 5;
			// 
			// txtID
			// 
			this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtID.Location = new System.Drawing.Point(188, 46);
			this.txtID.Margin = new System.Windows.Forms.Padding(4);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(674, 29);
			this.txtID.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 233);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 20);
			this.label5.TabIndex = 3;
			this.label5.Text = "CNIC:";
			// 
			// txtName
			// 
			this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(188, 82);
			this.txtName.Margin = new System.Windows.Forms.Padding(4);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(674, 29);
			this.txtName.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 197);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Email:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 160);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Address:";
			// 
			// label0
			// 
			this.label0.AutoSize = true;
			this.label0.Location = new System.Drawing.Point(11, 49);
			this.label0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label0.Name = "label0";
			this.label0.Size = new System.Drawing.Size(116, 20);
			this.label0.TabIndex = 0;
			this.label0.Text = "Customer ID:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 123);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Phone No:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 86);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(146, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Customer Name:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(302, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(241, 29);
			this.label6.TabIndex = 14;
			this.label6.Text = "Search   Customers";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnback);
			this.groupBox3.Controls.Add(this.btnclear);
			this.groupBox3.Controls.Add(this.btnSearch);
			this.groupBox3.Controls.Add(this.cboSearchBy);
			this.groupBox3.Controls.Add(this.txtSearch);
			this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.groupBox3.Location = new System.Drawing.Point(4, 525);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox3.Size = new System.Drawing.Size(891, 54);
			this.groupBox3.TabIndex = 17;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Search Customer";
			// 
			// btnSearch
			// 
			this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnSearch.Location = new System.Drawing.Point(343, 18);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(68, 28);
			this.btnSearch.TabIndex = 8;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// cboSearchBy
			// 
			this.cboSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSearchBy.FormattingEnabled = true;
			this.cboSearchBy.Location = new System.Drawing.Point(16, 21);
			this.cboSearchBy.Margin = new System.Windows.Forms.Padding(4);
			this.cboSearchBy.Name = "cboSearchBy";
			this.cboSearchBy.Size = new System.Drawing.Size(160, 24);
			this.cboSearchBy.TabIndex = 6;
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(185, 22);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(132, 22);
			this.txtSearch.TabIndex = 7;
			// 
			// btnclear
			// 
			this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnclear.ForeColor = System.Drawing.Color.Black;
			this.btnclear.Location = new System.Drawing.Point(436, 22);
			this.btnclear.Name = "btnclear";
			this.btnclear.Size = new System.Drawing.Size(92, 25);
			this.btnclear.TabIndex = 12;
			this.btnclear.Text = "Clear";
			this.btnclear.UseVisualStyleBackColor = true;
			this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
			// 
			// btnback
			// 
			this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnback.Location = new System.Drawing.Point(559, 18);
			this.btnback.Margin = new System.Windows.Forms.Padding(4);
			this.btnback.Name = "btnback";
			this.btnback.Size = new System.Drawing.Size(221, 29);
			this.btnback.TabIndex = 13;
			this.btnback.Text = "Back To Main Menu";
			this.btnback.UseVisualStyleBackColor = true;
			this.btnback.Click += new System.EventHandler(this.btnback_Click);
			// 
			// SearchCustomerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(918, 592);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.dgvCust);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label6);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SearchCustomerForm";
			this.Text = "SearchCustomerForm";
			this.Load += new System.EventHandler(this.SearchCustomerForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCust)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvCust;
		private System.Windows.Forms.DataGridViewTextBoxColumn cCust_Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn cCust_name;
		private System.Windows.Forms.DataGridViewTextBoxColumn cCust_ph_no;
		private System.Windows.Forms.DataGridViewTextBoxColumn cCust_address;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
		private System.Windows.Forms.DataGridViewTextBoxColumn cCNIC;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtCNIC;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtPhoneNo;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label0;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ComboBox cboSearchBy;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnclear;
		private System.Windows.Forms.Button btnback;
	}
}