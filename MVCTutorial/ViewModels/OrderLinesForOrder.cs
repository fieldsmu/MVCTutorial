using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorial.ViewModels {
	public class OrderLinesForOrder {

		public Order Order { get; set; }
		public IEnumerable<OrderLine> OrderLine { get; set; }

		public OrderLinesForOrder() {

		}
	}
}