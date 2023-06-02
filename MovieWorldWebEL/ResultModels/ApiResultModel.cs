using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWorldWebEL.ResultModels
{
	public class ApiResultModel<T>
	{
		public bool Success { get; set; }
		public int Page { get; set; }
		public T Results { get; set; }
	}
}
