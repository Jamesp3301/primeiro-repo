using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager
{
    internal class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
    public Movie(int id, string title, string director, int year, string genre) 
    {
            Id = id;
            Title = title;
            Director = director;
            Year = year;
            Genre = genre;
    }


}
