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
        public String Overview { get; set; }
        public String Original_title { get; set; }
        public String Original_language { get; set; }
        public String Release_date { get; set; }
        public Double Vote_average { get; set; }

    }
}



