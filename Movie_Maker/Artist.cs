using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Movie_Maker
{
    class Artist
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Cache { get; set; }
        public int AmountOfMovies { get; set; }
        public double ADiscount { get; set; }

        public Artist(int Code, string Name, double Cache, int AmountOfMovies, double ADiscount)
        {
            this.Code = Code;
            this.Name = Name;
            this.Cache = Cache;
            this.AmountOfMovies = AmountOfMovies;
            this.ADiscount = ADiscount;
        }

        public double SubTotal()
        {
            double Discount = Cache * ADiscount / 100.0;
            return (Cache * Discount) * AmountOfMovies;
        }

        public override string ToString()
        {
            return "Code: "
                + Code
                + ", Name: "
                + Name
                + ", Cache: $"
                + Cache.ToString("F2", CultureInfo.InvariantCulture)
                + ", Amount Of Movies: "
                + AmountOfMovies
                + ", Discount: " + ADiscount.ToString("F2", CultureInfo.InvariantCulture) + "%"
                + ", Total Price: "
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}