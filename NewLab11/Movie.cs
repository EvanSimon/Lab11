using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLab11
{  
   class Movie
   {
    private string Title { get; set; }
    private string Category { get; set; }

        public Movie(string title, string category)
        {
         this.Title = title;
         this.Category = category;
        }

        public string GetTitle()
        {
         return this.Title;
        }

        public string GetCategory()
        {
          return this.Category;
        }

        public int CompareTo(Movie other)
        {
         return Title.CompareTo(other.Title);
        }

        public void PrintMovie()
        {//probably won't use this, but wanted to try the dollar sign thing
         Console.WriteLine($"{GetTitle()} falls within the {GetCategory()} category");
        }
   }
    
}
