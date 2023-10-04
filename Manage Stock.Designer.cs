
namespace SuperMarket_Management_System_new_
{
	partial class Manage_Stock
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Stock));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.menuStripDropDown = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnAddStock = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnDeleteStock = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnUpdateStock = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnSearchStock = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnBack = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripDropDown,
            this.toolStripMenuItem2,
            this.BtnAddStock,
            this.toolStripMenuItem3,
            this.BtnDeleteStock,
            this.toolStripMenuItem4,
            this.BtnUpdateStock,
            this.toolStripMenuItem5,
            this.BtnSearchStock,
            this.toolStripMenuItem6,
            this.BtnBack});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(1485, 40);
			this.menuStrip.TabIndex = 11;
			this.menuStrip.Text = "menuStrip";
			// 
			// menuStripDropDown
			// 
			this.menuStripDropDown.Name = "menuStripDropDown";
			this.menuStripDropDown.Size = new System.Drawing.Size(40, 36);
			this.menuStripDropDown.Text = "↓";
			this.menuStripDropDown.Click += new System.EventHandler(this.menuStripDropDown_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(37, 36);
			this.toolStripMenuItem2.Text = "|";
			// 
			// BtnAddStock
			// 
			this.BtnAddStock.Name = "BtnAddStock";
			this.BtnAddStock.Size = new System.Drawing.Size(162, 36);
			this.BtnAddStock.Text = "Add  Stocks";
			this.BtnAddStock.Click += new System.EventHandler(this.BtnAddStock_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(37, 36);
			this.toolStripMenuItem3.Text = "|";
			// 
			// BtnDeleteStock
			// 
			this.BtnDeleteStock.Name = "BtnDeleteStock";
			this.BtnDeleteStock.Size = new System.Drawing.Size(188, 36);
			this.BtnDeleteStock.Text = "Delete  Stocks";
			this.BtnDeleteStock.Click += new System.EventHandler(this.BtnDeleteStock_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(37, 36);
			this.toolStripMenuItem4.Text = "|";
			// 
			// BtnUpdateStock
			// 
			this.BtnUpdateStock.Name = "BtnUpdateStock";
			this.BtnUpdateStock.Size = new System.Drawing.Size(197, 36);
			this.BtnUpdateStock.Text = "Update  Stocks";
			this.BtnUpdateStock.Click += new System.EventHandler(this.BtnUpdateStock_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(37, 36);
			this.toolStripMenuItem5.Text = "|";
			// 
			// BtnSearchStock
			// 
			this.BtnSearchStock.Name = "BtnSearchStock";
			this.BtnSearchStock.Size = new System.Drawing.Size(190, 36);
			this.BtnSearchStock.Text = "Search  Stocks";
			this.BtnSearchStock.Click += new System.EventHandler(this.BtnSearchStock_Click);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(37, 36);
			this.toolStripMenuItem6.Text = "|";
			// 
			// BtnBack
			// 
			this.BtnBack.Name = "BtnBack";
			this.BtnBack.Size = new System.Drawing.Size(71, 36);
			this.BtnBack.Text = "Exit";
			this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click_1);
			// 
			// Manage_Stock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
			this.ClientSize = new System.Drawing.Size(1485, 539);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.Name = "Manage_Stock";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manage_Stock";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem menuStripDropDown;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem BtnAddStock;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem BtnDeleteStock;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem BtnUpdateStock;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem BtnSearchStock;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem BtnBack;
	}
}