using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWorldWebEL.ViewModels
{
	public class ApiMovieVM
	{
		public Boolean Adult { get; set; }
		public String Backdrop_path { get; set; }
		public List<int> Genre_ids { get; set; }
		public int Id { get; set; }

		public String Poster_path { get; set; }
		public String Title { get; set; }
	}
}

		//    val original_language: String,
		//val original_title: String,
		//val overview: String,
		//val popularity: Double,
		//val release_date: String,
		//val vote_average: Double,
		//val vote_count: Int


