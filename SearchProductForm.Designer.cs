
namespace SuperMarket_Management_System_new_
{
	partial class SearchProductForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchProductForm));
			this.dgvProduct = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtPDesc = new System.Windows.Forms.TextBox();
			this.txtPPrice = new System.Windows.Forms.TextBox();
			this.txtPName = new System.Windows.Forms.TextBox();
			this.txtPID = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Searchbox = new System.Windows.Forms.GroupBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.cboSearchBy = new System.Windows.Forms.ComboBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnclear = new System.Windows.Forms.Button();
			this.btnback = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.Searchbox.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvProduct
			// 
			this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProduct.Location = new System.Drawing.Point(18, 258);
			this.dgvProduct.Margin = new System.Windows.Forms.Padding(4);
			this.dgvProduct.Name = "dgvProduct";
			this.dgvProduct.RowHeadersWidth = 51;
			this.dgvProduct.Size = new System.Drawing.Size(747, 243);
			this.dgvProduct.TabIndex = 13;
			this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(276, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(206, 29);
			this.label1.TabIndex = 12;
			this.label1.Text = "Search   Product";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.txtPDesc);
			this.groupBox1.Controls.Add(this.txtPPrice);
			this.groupBox1.Controls.Add(this.txtPName);
			this.groupBox1.Controls.Add(this.txtPID);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(13, 42);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(752, 208);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Product Information";
			// 
			// txtPDesc
			// 
			this.txtPDesc.Location = new System.Drawing.Point(247, 155);
			this.txtPDesc.Margin = new System.Windows.Forms.Padding(4);
			this.txtPDesc.Name = "txtPDesc";
			this.txtPDesc.Size = new System.Drawing.Size(393, 29);
			this.txtPDesc.TabIndex = 7;
			// 
			// txtPPrice
			// 
			this.txtPPrice.Location = new System.Drawing.Point(247, 113);
			this.txtPPrice.Margin = new System.Windows.Forms.Padding(4);
			this.txtPPrice.Name = "txtPPrice";
			this.txtPPrice.Size = new System.Drawing.Size(393, 29);
			this.txtPPrice.TabIndex = 6;
			// 
			// txtPName
			// 
			this.txtPName.Location = new System.Drawing.Point(247, 76);
			this.txtPName.Margin = new System.Windows.Forms.Padding(4);
			this.txtPName.Name = "txtPName";
			this.txtPName.Size = new System.Drawing.Size(393, 29);
			this.txtPName.TabIndex = 5;
			// 
			// txtPID
			// 
			this.txtPID.Location = new System.Drawing.Point(247, 39);
			this.txtPID.Margin = new System.Windows.Forms.Padding(4);
			this.txtPID.Name = "txtPID";
			this.txtPID.Size = new System.Drawing.Size(393, 29);
			this.txtPID.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 158);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(199, 22);
			this.label5.TabIndex = 3;
			this.label5.Text = "Product Description:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 113);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(147, 22);
			this.label4.TabIndex = 2;
			this.label4.Text = "Product Price :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 76);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(147, 22);
			this.label3.TabIndex = 1;
			this.label3.Text = "Product Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 46);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 22);
			this.label2.TabIndex = 0;
			this.label2.Text = "Product Id:";
			// 
			// Searchbox
			// 
			this.Searchbox.Controls.Add(this.btnback);
			this.Searchbox.Controls.Add(this.btnclear);
			this.Searchbox.Controls.Add(this.btnSearch);
			this.Searchbox.Controls.Add(this.cboSearchBy);
			this.Searchbox.Controls.Add(this.txtSearch);
			this.Searchbox.ForeColor = System.Drawing.Color.White;
			this.Searchbox.Location = new System.Drawing.Point(18, 509);
			this.Searchbox.Margin = new System.Windows.Forms.Padding(4);
			this.Searchbox.Name = "Searchbox";
			this.Searchbox.Padding = new System.Windows.Forms.Padding(4);
			this.Searchbox.Size = new System.Drawing.Size(755, 54);
			this.Searchbox.TabIndex = 18;
			this.Searchbox.TabStop = false;
			this.Searchbox.Text = "Search Product";
			// 
			// btnSearch
			// 
			this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnSearch.Location = new System.Drawing.Point(396, 20);
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
			this.cboSearchBy.Location = new System.Drawing.Point(39, 20);
			this.cboSearchBy.Margin = new System.Windows.Forms.Padding(4);
			this.cboSearchBy.Name = "cboSearchBy";
			this.cboSearchBy.Size = new System.Drawing.Size(160, 24);
			this.cboSearchBy.TabIndex = 6;
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(228, 24);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(132, 22);
			this.txtSearch.TabIndex = 7;
			// 
			// btnclear
			// 
			this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnclear.ForeColor = System.Drawing.Color.Black;
			this.btnclear.Location = new System.Drawing.Point(471, 20);
			this.btnclear.Name = "btnclear";
			this.btnclear.Size = new System.Drawing.Size(92, 26);
			this.btnclear.TabIndex = 17;
			this.btnclear.Text = "Clear";
			this.btnclear.UseVisualStyleBackColor = true;
			this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
			// 
			// btnback
			// 
			this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnback.ForeColor = System.Drawing.Color.Black;
			this.btnback.Location = new System.Drawing.Point(570, 18);
			this.btnback.Margin = new System.Windows.Forms.Padding(4);
			this.btnback.Name = "btnback";
			this.btnback.Size = new System.Drawing.Size(177, 28);
			this.btnback.TabIndex = 18;
			this.btnback.Text = "Back To Main Menu";
			this.btnback.UseVisualStyleBackColor = true;
			this.btnback.Click += new System.EventHandler(this.btnback_Click);
			// 
			// SearchProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(789, 621);
			this.Controls.Add(this.Searchbox);
			this.Controls.Add(this.dgvProduct);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SearchProductForm";
			this.Text = "SearchProductForm";
			this.Load += new System.EventHandler(this.SearchProductForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.Searchbox.ResumeLayout(false);
			this.Searchbox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvProduct;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtPDesc;
		private System.Windows.Forms.TextBox txtPPrice;
		private System.Windows.Forms.TextBox txtPName;
		private System.Windows.Forms.TextBox txtPID;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox Searchbox;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ComboBox cboSearchBy;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnclear;
		private System.Windows.Forms.Button btnback;
	}
}