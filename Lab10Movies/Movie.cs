using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Movies
{
    public class Movie
    {
        public Movie(string name, string category)
        {
            _name = name;
            _category = category;
        }
        private string _name;

        public string title
        {
            get { return _name; }
        }

        private string _category;

        public string genre
        {
            get { return _category; }
        }
    }
}
