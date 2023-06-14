using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWorldWebEL.ViewModels
{
    public class ApiMovieVM
    {
        private const string imgUrl = "https://image.tmdb.org/t/p/w342";

		public Boolean Adult { get; set; }
        public String Backdrop_path { get; set; }
        public List<int> Genre_ids { get; set; }
        public int Id { get; set; }
        private string _posterPath;
        public String Poster_path
        {
            get
            {
                return _posterPath;
            }
            set
            {
                _posterPath = $"{imgUrl}{value}";
            }
        
        }
        public String Title { get; set; }
        public String Overview { get; set; }
        public String Original_title { get; set; }
        public String Original_language { get; set; }
        public String Release_date { get; set; }
        public Double Vote_average { get; set; }

    }
}



