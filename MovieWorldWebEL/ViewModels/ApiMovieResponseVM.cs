using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWorldWebEL.ViewModels
{
	public class ApiMovieResponseVM
	{
        public int page { get; set; }
        //public List<T> result { get; set; }
        public int totalpages { get; set; }
        public int totalresults { get; set; }
	}
}
