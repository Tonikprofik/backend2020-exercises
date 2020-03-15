    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie
    {
        // fields
        private double price;

        // properties
        public string Title { get; set; } // auto-implemented property
        public string ImageFileName { get; set; }
        public string Director { get; set; }
        
        public double Price
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price is not accepted");
                }
                else
                {
                    price = value;
                }
            }
            get { return price; }
        }


        // constructors
        public Movie(string title, double price)
        {
            Title = title;
            this.price = price;
        }

        public Movie(string title, double price, string imageFileName, string director)
        {
            Title = title;
            this.price = price;
            ImageFileName = imageFileName;
            Director = director;
        }
    }
}