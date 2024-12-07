using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class Movie
    {
        public int MovieId {  get; set; }
        public string Title { get; set; }
        public string Lang {  get; set; }
        public string Actor {  get; set; }
        public string Director {  get; set; }
        public int ReleaseYear {  get; set; }
    }
}