﻿
namespace SuperMarket_Management_System_new_
{
	partial class SearchStockForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchStockForm));
			this.dgvStock = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label0 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSCost = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSQuantity = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSName = new System.Windows.Forms.TextBox();
			this.txtSId = new System.Windows.Forms.TextBox();
			this.btnclear = new System.Windows.Forms.Button();
			this.btnback = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.cboSearchBy = new System.Windows.Forms.ComboBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvStock
			// 
			this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStock.Location = new System.Drawing.Point(13, 330);
			this.dgvStock.Margin = new System.Windows.Forms.Padding(4);
			this.dgvStock.Name = "dgvStock";
			this.dgvStock.RowHeadersWidth = 51;
			this.dgvStock.Size = new System.Drawing.Size(822, 268);
			this.dgvStock.TabIndex = 19;
			this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellClick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.Control;
			this.label5.Location = new System.Drawing.Point(272, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(174, 29);
			this.label5.TabIndex = 18;
			this.label5.Text = "Search  Stock";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.Add(this.label0);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtSCost);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtSQuantity);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtSName);
			this.groupBox1.Controls.Add(this.txtSId);
			this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(13, 51);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(814, 271);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Stock Information";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(245, 197);
			this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(410, 29);
			this.numericUpDown1.TabIndex = 7;
			// 
			// label0
			// 
			this.label0.AutoSize = true;
			this.label0.Location = new System.Drawing.Point(45, 57);
			this.label0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label0.Name = "label0";
			this.label0.Size = new System.Drawing.Size(99, 22);
			this.label0.TabIndex = 0;
			this.label0.Text = "Stock  ID:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 130);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(151, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "Stock Quantity:";
			// 
			// txtSCost
			// 
			this.txtSCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSCost.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSCost.Location = new System.Drawing.Point(245, 161);
			this.txtSCost.Margin = new System.Windows.Forms.Padding(4);
			this.txtSCost.Name = "txtSCost";
			this.txtSCost.Size = new System.Drawing.Size(409, 29);
			this.txtSCost.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(45, 165);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 22);
			this.label3.TabIndex = 2;
			this.label3.Text = "Stock Cost:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(45, 94);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Stock Name:";
			// 
			// txtSQuantity
			// 
			this.txtSQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSQuantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSQuantity.Location = new System.Drawing.Point(245, 124);
			this.txtSQuantity.Margin = new System.Windows.Forms.Padding(4);
			this.txtSQuantity.Name = "txtSQuantity";
			this.txtSQuantity.Size = new System.Drawing.Size(408, 29);
			this.txtSQuantity.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(45, 203);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(143, 22);
			this.label4.TabIndex = 3;
			this.label4.Text = "Alert Quantity:";
			// 
			// txtSName
			// 
			this.txtSName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSName.Location = new System.Drawing.Point(245, 87);
			this.txtSName.Margin = new System.Windows.Forms.Padding(4);
			this.txtSName.Name = "txtSName";
			this.txtSName.Size = new System.Drawing.Size(408, 29);
			this.txtSName.TabIndex = 4;
			// 
			// txtSId
			// 
			this.txtSId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSId.Location = new System.Drawing.Point(245, 50);
			this.txtSId.Margin = new System.Windows.Forms.Padding(4);
			this.txtSId.Name = "txtSId";
			this.txtSId.Size = new System.Drawing.Size(409, 29);
			this.txtSId.TabIndex = 4;
			// 
			// btnclear
			// 
			this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnclear.ForeColor = System.Drawing.Color.Black;
			this.btnclear.Location = new System.Drawing.Point(519, 19);
			this.btnclear.Name = "btnclear";
			this.btnclear.Size = new System.Drawing.Size(73, 26);
			this.btnclear.TabIndex = 11;
			this.btnclear.Text = "Clear";
			this.btnclear.UseVisualStyleBackColor = true;
			this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
			// 
			// btnback
			// 
			this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnback.ForeColor = System.Drawing.Color.Black;
			this.btnback.Location = new System.Drawing.Point(618, 20);
			this.btnback.Margin = new System.Windows.Forms.Padding(4);
			this.btnback.Name = "btnback";
			this.btnback.Size = new System.Drawing.Size(196, 28);
			this.btnback.TabIndex = 4;
			this.btnback.Text = "Back To Main Menu";
			this.btnback.UseVisualStyleBackColor = true;
			this.btnback.Click += new System.EventHandler(this.btnback_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnback);
			this.groupBox3.Controls.Add(this.btnclear);
			this.groupBox3.Controls.Add(this.btnSearch);
			this.groupBox3.Controls.Add(this.cboSearchBy);
			this.groupBox3.Controls.Add(this.txtSearch);
			this.groupBox3.ForeColor = System.Drawing.Color.White;
			this.groupBox3.Location = new System.Drawing.Point(13, 606);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox3.Size = new System.Drawing.Size(822, 70);
			this.groupBox3.TabIndex = 21;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Search Stock";
			// 
			// btnSearch
			// 
			this.btnSearch.ForeColor = System.Drawing.Color.Black;
			this.btnSearch.Location = new System.Drawing.Point(412, 19);
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
			this.txtSearch.Location = new System.Drawing.Point(235, 22);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(132, 22);
			this.txtSearch.TabIndex = 7;
			// 
			// SearchStockForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
			this.ClientSize = new System.Drawing.Size(861, 702);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.dgvStock);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SearchStockForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SearchStockForm";
			this.Load += new System.EventHandler(this.SearchStockForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvStock;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label0;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSCost;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSQuantity;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSName;
		private System.Windows.Forms.TextBox txtSId;
		private System.Windows.Forms.Button btnclear;
		private System.Windows.Forms.Button btnback;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ComboBox cboSearchBy;
		private System.Windows.Forms.TextBox txtSearch;
	}
}