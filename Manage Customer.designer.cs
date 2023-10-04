
namespace SuperMarket_Management_System_new_
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.menuStripDropDown = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnDeleteCustomer = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnUpdateCustomer = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnSearchCustomer = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnBack = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripDropDown,
            this.toolStripMenuItem2,
            this.BtnAddCustomer,
            this.toolStripMenuItem3,
            this.BtnDeleteCustomer,
            this.toolStripMenuItem4,
            this.BtnUpdateCustomer,
            this.toolStripMenuItem5,
            this.BtnSearchCustomer,
            this.toolStripMenuItem6,
            this.BtnBack});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(1151, 36);
			this.menuStrip.TabIndex = 12;
			this.menuStrip.Text = "menuStrip";
			// 
			// menuStripDropDown
			// 
			this.menuStripDropDown.Name = "menuStripDropDown";
			this.menuStripDropDown.Size = new System.Drawing.Size(35, 32);
			this.menuStripDropDown.Text = "↓";
			this.menuStripDropDown.Click += new System.EventHandler(this.menuStripDropDown_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(33, 32);
			this.toolStripMenuItem2.Text = "|";
			// 
			// BtnAddCustomer
			// 
			this.BtnAddCustomer.Name = "BtnAddCustomer";
			this.BtnAddCustomer.Size = new System.Drawing.Size(175, 32);
			this.BtnAddCustomer.Text = "Add  Customers";
			this.BtnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(33, 32);
			this.toolStripMenuItem3.Text = "|";
			// 
			// BtnDeleteCustomer
			// 
			this.BtnDeleteCustomer.Name = "BtnDeleteCustomer";
			this.BtnDeleteCustomer.Size = new System.Drawing.Size(199, 32);
			this.BtnDeleteCustomer.Text = "Delete  Customers";
			this.BtnDeleteCustomer.Click += new System.EventHandler(this.BtnDeleteCustomer_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(33, 32);
			this.toolStripMenuItem4.Text = "|";
			// 
			// BtnUpdateCustomer
			// 
			this.BtnUpdateCustomer.Name = "BtnUpdateCustomer";
			this.BtnUpdateCustomer.Size = new System.Drawing.Size(205, 32);
			this.BtnUpdateCustomer.Text = "Update  Customers";
			this.BtnUpdateCustomer.Click += new System.EventHandler(this.BtnUpdateCustomer_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(33, 32);
			this.toolStripMenuItem5.Text = "|";
			// 
			// BtnSearchCustomer
			// 
			this.BtnSearchCustomer.Name = "BtnSearchCustomer";
			this.BtnSearchCustomer.Size = new System.Drawing.Size(200, 32);
			this.BtnSearchCustomer.Text = "Search  Customers";
			this.BtnSearchCustomer.Click += new System.EventHandler(this.BtnSearchCustomer_Click);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(33, 32);
			this.toolStripMenuItem6.Text = "|";
			// 
			// BtnBack
			// 
			this.BtnBack.Name = "BtnBack";
			this.BtnBack.Size = new System.Drawing.Size(62, 32);
			this.BtnBack.Text = "Exit";
			this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
			// 
			// FrmCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(1151, 641);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.Name = "FrmCustomer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmCustomer";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem menuStripDropDown;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem BtnAddCustomer;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem BtnDeleteCustomer;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem BtnUpdateCustomer;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem BtnSearchCustomer;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem BtnBack;
	}
}