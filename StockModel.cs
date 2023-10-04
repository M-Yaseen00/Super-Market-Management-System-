using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket_Management_System_new_
{
	class StockModel
	{
		public int stockId { get; set; }
		public string stockName { get; set; }
		public int stockQuantity { get; set; }
		public int stockCost { get; set; }
		public int stockAlertQuantity { get; set; }
	}
}
