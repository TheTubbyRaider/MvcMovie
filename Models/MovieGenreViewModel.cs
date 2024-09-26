using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies { get; set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }
        public string SearchString { get; set; }

        // New property for year filtering
        public string SelectedYear { get; set; }
        public List<int> AvailableYears { get; set; } = new List<int>();
    }
}
