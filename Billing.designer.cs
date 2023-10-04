
namespace SuperMarket_Management_System_new_
{
	partial class Billing
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.BillID = new Guna.UI2.WinForms.Guna2TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ProdName = new Guna.UI2.WinForms.Guna2TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.ProdQty = new Guna.UI2.WinForms.Guna2TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.ProdPrice = new Guna.UI2.WinForms.Guna2TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.BillsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
			this.button8 = new System.Windows.Forms.Button();
			this.Datelbl = new System.Windows.Forms.Label();
			this.SellerNamelbl = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.Amtlbl = new System.Windows.Forms.Label();
			this.ORDERDGV = new Guna.UI2.WinForms.Guna2DataGridView();
			this.Sr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label8 = new System.Windows.Forms.Label();
			this.ProdDGV = new Guna.UI2.WinForms.Guna2DataGridView();
			this.Del_btn = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnBack = new System.Windows.Forms.Button();
			this.buttonexit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ORDERDGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Document = this.printDocument1;
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label2.Location = new System.Drawing.Point(669, 5);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 31);
			this.label2.TabIndex = 5;
			this.label2.Text = "Selling";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new System.Drawing.Point(11, 62);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "BILLID";
			// 
			// BillID
			// 
			this.BillID.BackColor = System.Drawing.Color.Transparent;
			this.BillID.BorderColor = System.Drawing.SystemColors.Control;
			this.BillID.BorderThickness = 3;
			this.BillID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.BillID.CustomizableEdges.BottomLeft = false;
			this.BillID.CustomizableEdges.TopLeft = false;
			this.BillID.CustomizableEdges.TopRight = false;
			this.BillID.DefaultText = "";
			this.BillID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.BillID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.BillID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.BillID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.BillID.FocusedState.BorderColor = System.Drawing.SystemColors.WindowFrame;
			this.BillID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.BillID.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.BillID.HoverState.BorderColor = System.Drawing.Color.White;
			this.BillID.Location = new System.Drawing.Point(133, 50);
			this.BillID.Margin = new System.Windows.Forms.Padding(5);
			this.BillID.Name = "BillID";
			this.BillID.PasswordChar = '\0';
			this.BillID.PlaceholderForeColor = System.Drawing.SystemColors.WindowFrame;
			this.BillID.PlaceholderText = "";
			this.BillID.SelectedText = "";
			this.BillID.Size = new System.Drawing.Size(284, 31);
			this.BillID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.BillID.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label3.Location = new System.Drawing.Point(11, 122);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "ProdName";
			// 
			// ProdName
			// 
			this.ProdName.BackColor = System.Drawing.Color.Transparent;
			this.ProdName.BorderColor = System.Drawing.SystemColors.Control;
			this.ProdName.BorderThickness = 3;
			this.ProdName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ProdName.CustomizableEdges.BottomLeft = false;
			this.ProdName.CustomizableEdges.TopLeft = false;
			this.ProdName.CustomizableEdges.TopRight = false;
			this.ProdName.DefaultText = "";
			this.ProdName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.ProdName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.ProdName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.ProdName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.ProdName.Enabled = false;
			this.ProdName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.ProdName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.ProdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ProdName.HoverState.BorderColor = System.Drawing.Color.White;
			this.ProdName.Location = new System.Drawing.Point(133, 111);
			this.ProdName.Margin = new System.Windows.Forms.Padding(5);
			this.ProdName.Name = "ProdName";
			this.ProdName.PasswordChar = '\0';
			this.ProdName.PlaceholderText = "";
			this.ProdName.SelectedText = "";
			this.ProdName.Size = new System.Drawing.Size(284, 31);
			this.ProdName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.ProdName.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label4.Location = new System.Drawing.Point(11, 236);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 20);
			this.label4.TabIndex = 10;
			this.label4.Text = "Quantity";
			// 
			// ProdQty
			// 
			this.ProdQty.BackColor = System.Drawing.Color.Transparent;
			this.ProdQty.BorderColor = System.Drawing.SystemColors.Control;
			this.ProdQty.BorderThickness = 3;
			this.ProdQty.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ProdQty.CustomizableEdges.BottomLeft = false;
			this.ProdQty.CustomizableEdges.TopLeft = false;
			this.ProdQty.CustomizableEdges.TopRight = false;
			this.ProdQty.DefaultText = "";
			this.ProdQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.ProdQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.ProdQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.ProdQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.ProdQty.FocusedState.BorderColor = System.Drawing.SystemColors.WindowFrame;
			this.ProdQty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.ProdQty.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.ProdQty.HoverState.BorderColor = System.Drawing.Color.White;
			this.ProdQty.Location = new System.Drawing.Point(133, 225);
			this.ProdQty.Margin = new System.Windows.Forms.Padding(5);
			this.ProdQty.Name = "ProdQty";
			this.ProdQty.PasswordChar = '\0';
			this.ProdQty.PlaceholderForeColor = System.Drawing.SystemColors.WindowFrame;
			this.ProdQty.PlaceholderText = "";
			this.ProdQty.SelectedText = "";
			this.ProdQty.Size = new System.Drawing.Size(284, 31);
			this.ProdQty.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.ProdQty.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label5.Location = new System.Drawing.Point(11, 178);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 20);
			this.label5.TabIndex = 12;
			this.label5.Text = "Price";
			// 
			// ProdPrice
			// 
			this.ProdPrice.BackColor = System.Drawing.Color.Transparent;
			this.ProdPrice.BorderColor = System.Drawing.SystemColors.Control;
			this.ProdPrice.BorderThickness = 3;
			this.ProdPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ProdPrice.CustomizableEdges.BottomLeft = false;
			this.ProdPrice.CustomizableEdges.TopLeft = false;
			this.ProdPrice.CustomizableEdges.TopRight = false;
			this.ProdPrice.DefaultText = "";
			this.ProdPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.ProdPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.ProdPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.ProdPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.ProdPrice.Enabled = false;
			this.ProdPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.ProdPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.ProdPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ProdPrice.HoverState.BorderColor = System.Drawing.Color.White;
			this.ProdPrice.Location = new System.Drawing.Point(133, 167);
			this.ProdPrice.Margin = new System.Windows.Forms.Padding(5);
			this.ProdPrice.Name = "ProdPrice";
			this.ProdPrice.PasswordChar = '\0';
			this.ProdPrice.PlaceholderText = "";
			this.ProdPrice.SelectedText = "";
			this.ProdPrice.Size = new System.Drawing.Size(284, 31);
			this.ProdPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.ProdPrice.TabIndex = 13;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.White;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
			this.button4.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button4.Location = new System.Drawing.Point(542, 727);
			this.button4.Margin = new System.Windows.Forms.Padding(4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(100, 38);
			this.button4.TabIndex = 4;
			this.button4.Text = "Add";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.White;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
			this.button6.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button6.Location = new System.Drawing.Point(650, 727);
			this.button6.Margin = new System.Windows.Forms.Padding(4);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(111, 38);
			this.button6.TabIndex = 16;
			this.button6.Text = "PRINT";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// BillsDGV
			// 
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
			this.BillsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.HotTrack;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.BillsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.BillsDGV.ColumnHeadersHeight = 30;
			this.BillsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.BillsDGV.DefaultCellStyle = dataGridViewCellStyle12;
			this.BillsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.BillsDGV.Location = new System.Drawing.Point(543, 429);
			this.BillsDGV.Margin = new System.Windows.Forms.Padding(4);
			this.BillsDGV.Name = "BillsDGV";
			this.BillsDGV.RowHeadersVisible = false;
			this.BillsDGV.RowHeadersWidth = 51;
			this.BillsDGV.Size = new System.Drawing.Size(1063, 290);
			this.BillsDGV.TabIndex = 18;
			this.BillsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.BillsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.BillsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.BillsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.BillsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.BillsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.BillsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.BillsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.BillsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.BillsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BillsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.BillsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.BillsDGV.ThemeStyle.HeaderStyle.Height = 30;
			this.BillsDGV.ThemeStyle.ReadOnly = false;
			this.BillsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.BillsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.BillsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BillsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.BillsDGV.ThemeStyle.RowsStyle.Height = 22;
			this.BillsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.BillsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.BillsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillsDGV_CellContentClick);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.White;
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.button8.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.button8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button8.Location = new System.Drawing.Point(15, 281);
			this.button8.Margin = new System.Windows.Forms.Padding(4);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(199, 39);
			this.button8.TabIndex = 20;
			this.button8.Text = "Get Products";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// Datelbl
			// 
			this.Datelbl.AutoSize = true;
			this.Datelbl.BackColor = System.Drawing.Color.Transparent;
			this.Datelbl.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
			this.Datelbl.ForeColor = System.Drawing.Color.White;
			this.Datelbl.Location = new System.Drawing.Point(1131, 5);
			this.Datelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Datelbl.Name = "Datelbl";
			this.Datelbl.Size = new System.Drawing.Size(55, 23);
			this.Datelbl.TabIndex = 22;
			this.Datelbl.Text = "DATE";
			// 
			// SellerNamelbl
			// 
			this.SellerNamelbl.AutoSize = true;
			this.SellerNamelbl.BackColor = System.Drawing.Color.Transparent;
			this.SellerNamelbl.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
			this.SellerNamelbl.ForeColor = System.Drawing.Color.White;
			this.SellerNamelbl.Location = new System.Drawing.Point(11, 9);
			this.SellerNamelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.SellerNamelbl.Name = "SellerNamelbl";
			this.SellerNamelbl.Size = new System.Drawing.Size(145, 23);
			this.SellerNamelbl.TabIndex = 23;
			this.SellerNamelbl.Text = "SellerManager";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button1.Location = new System.Drawing.Point(229, 281);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(188, 39);
			this.button1.TabIndex = 24;
			this.button1.Text = "Add Product";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label6.Location = new System.Drawing.Point(536, 362);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(113, 31);
			this.label6.TabIndex = 25;
			this.label6.Text = "Amount";
			// 
			// Amtlbl
			// 
			this.Amtlbl.AutoSize = true;
			this.Amtlbl.BackColor = System.Drawing.Color.Transparent;
			this.Amtlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
			this.Amtlbl.ForeColor = System.Drawing.Color.White;
			this.Amtlbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Amtlbl.Location = new System.Drawing.Point(665, 362);
			this.Amtlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Amtlbl.Name = "Amtlbl";
			this.Amtlbl.Size = new System.Drawing.Size(50, 31);
			this.Amtlbl.TabIndex = 26;
			this.Amtlbl.Text = "Rs";
			// 
			// ORDERDGV
			// 
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
			this.ORDERDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.HotTrack;
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ORDERDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.ORDERDGV.ColumnHeadersHeight = 30;
			this.ORDERDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.ORDERDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sr,
            this.PName,
            this.Price,
            this.Quantity,
            this.Total});
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ORDERDGV.DefaultCellStyle = dataGridViewCellStyle15;
			this.ORDERDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ORDERDGV.Location = new System.Drawing.Point(543, 39);
			this.ORDERDGV.Margin = new System.Windows.Forms.Padding(4);
			this.ORDERDGV.Name = "ORDERDGV";
			this.ORDERDGV.RowHeadersVisible = false;
			this.ORDERDGV.RowHeadersWidth = 51;
			this.ORDERDGV.Size = new System.Drawing.Size(1063, 319);
			this.ORDERDGV.TabIndex = 27;
			this.ORDERDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.ORDERDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.ORDERDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.ORDERDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.ORDERDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.ORDERDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.ORDERDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ORDERDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.ORDERDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.ORDERDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ORDERDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.ORDERDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.ORDERDGV.ThemeStyle.HeaderStyle.Height = 30;
			this.ORDERDGV.ThemeStyle.ReadOnly = false;
			this.ORDERDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.ORDERDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.ORDERDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ORDERDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.ORDERDGV.ThemeStyle.RowsStyle.Height = 22;
			this.ORDERDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ORDERDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// Sr
			// 
			this.Sr.HeaderText = "Sr.";
			this.Sr.MinimumWidth = 6;
			this.Sr.Name = "Sr";
			// 
			// PName
			// 
			this.PName.HeaderText = "ProdName";
			this.PName.MinimumWidth = 6;
			this.PName.Name = "PName";
			// 
			// Price
			// 
			this.Price.HeaderText = "Price";
			this.Price.MinimumWidth = 6;
			this.Price.Name = "Price";
			// 
			// Quantity
			// 
			this.Quantity.HeaderText = "Quantity";
			this.Quantity.MinimumWidth = 6;
			this.Quantity.Name = "Quantity";
			// 
			// Total
			// 
			this.Total.HeaderText = "Total";
			this.Total.MinimumWidth = 6;
			this.Total.Name = "Total";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label8.Location = new System.Drawing.Point(536, 394);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(173, 31);
			this.label8.TabIndex = 28;
			this.label8.Text = "SELLS LIST";
			// 
			// ProdDGV
			// 
			dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
			this.ProdDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.HotTrack;
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ProdDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
			this.ProdDGV.ColumnHeadersHeight = 30;
			this.ProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ProdDGV.DefaultCellStyle = dataGridViewCellStyle18;
			this.ProdDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ProdDGV.Location = new System.Drawing.Point(15, 327);
			this.ProdDGV.Margin = new System.Windows.Forms.Padding(4);
			this.ProdDGV.Name = "ProdDGV";
			this.ProdDGV.RowHeadersVisible = false;
			this.ProdDGV.RowHeadersWidth = 51;
			this.ProdDGV.Size = new System.Drawing.Size(402, 441);
			this.ProdDGV.TabIndex = 29;
			this.ProdDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.ProdDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.ProdDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.ProdDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.ProdDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.ProdDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.ProdDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ProdDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.ProdDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.ProdDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.ProdDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.ProdDGV.ThemeStyle.HeaderStyle.Height = 30;
			this.ProdDGV.ThemeStyle.ReadOnly = false;
			this.ProdDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.ProdDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.ProdDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.ProdDGV.ThemeStyle.RowsStyle.Height = 22;
			this.ProdDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ProdDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.ProdDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV_CellContentClick);
			// 
			// Del_btn
			// 
			this.Del_btn.BackColor = System.Drawing.Color.White;
			this.Del_btn.FlatAppearance.BorderSize = 0;
			this.Del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Del_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
			this.Del_btn.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.Del_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Del_btn.Location = new System.Drawing.Point(768, 727);
			this.Del_btn.Margin = new System.Windows.Forms.Padding(4);
			this.Del_btn.Name = "Del_btn";
			this.Del_btn.Size = new System.Drawing.Size(124, 38);
			this.Del_btn.TabIndex = 30;
			this.Del_btn.Text = "Delete";
			this.Del_btn.UseVisualStyleBackColor = false;
			this.Del_btn.Click += new System.EventHandler(this.Del_btn_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.OrangeRed;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.buttonexit);
			this.panel1.Controls.Add(this.btnBack);
			this.panel1.Controls.Add(this.Del_btn);
			this.panel1.Controls.Add(this.ProdDGV);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.ORDERDGV);
			this.panel1.Controls.Add(this.Amtlbl);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.SellerNamelbl);
			this.panel1.Controls.Add(this.Datelbl);
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.BillsDGV);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.ProdPrice);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.ProdQty);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.ProdName);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.BillID);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(-3, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1848, 970);
			this.panel1.TabIndex = 2;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.btnBack.Location = new System.Drawing.Point(910, 727);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(228, 41);
			this.btnBack.TabIndex = 31;
			this.btnBack.Text = "Back to Main Menu";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// buttonexit
			// 
			this.buttonexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonexit.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonexit.Location = new System.Drawing.Point(1155, 727);
			this.buttonexit.Name = "buttonexit";
			this.buttonexit.Size = new System.Drawing.Size(102, 41);
			this.buttonexit.TabIndex = 31;
			this.buttonexit.Text = "Exit";
			this.buttonexit.UseVisualStyleBackColor = true;
			this.buttonexit.Click += new System.EventHandler(this.btnexit_Click);
			// 
			// Billing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1604, 875);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Billing";
			this.Text = "Billing";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ORDERDGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2TextBox BillID;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2TextBox ProdName;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2TextBox ProdQty;
		private System.Windows.Forms.Label label5;
		private Guna.UI2.WinForms.Guna2TextBox ProdPrice;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button6;
		private Guna.UI2.WinForms.Guna2DataGridView BillsDGV;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Label Datelbl;
		private System.Windows.Forms.Label SellerNamelbl;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label Amtlbl;
		private Guna.UI2.WinForms.Guna2DataGridView ORDERDGV;
		private System.Windows.Forms.Label label8;
		private Guna.UI2.WinForms.Guna2DataGridView ProdDGV;
		private System.Windows.Forms.Button Del_btn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sr;
		private System.Windows.Forms.DataGridViewTextBoxColumn PName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn Total;
		private System.Windows.Forms.Button buttonexit;
	}
}

