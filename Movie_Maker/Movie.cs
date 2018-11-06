using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Maker
{ 
    class Movie
    {
        public int Code { get; set; }
        public string Title { get; set; }
        public Artist artist { get; set; }
        public double PercentDiscount { get; set; }
        public int Amount { get; set; }

        public Movie(int Code, string Title, Artist artist, double PercentDiscount, int Amount)
        {
            this.Code = Code;
            this.Title = Title;
            this.artist = artist;
            this.PercentDiscount = PercentDiscount;
            this.Amount = Amount;
        }

        public override string ToString()
        {
            return "Code: "
                + Code
                + ", Title: "
                + Title;

        }
    }
}