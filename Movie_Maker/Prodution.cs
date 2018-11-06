using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Movie_Maker
{
    class Prodution
    {
        public int Code { get; set; }
        public double Cache { get; set; }
        public double PercentDiscount { get; set; }
        public int Amount { get; set; }
        public DateTime ReleaseDate { get; set; }
        public static List<Prodution> prodution = new List<Prodution>();

        public Prodution(int Code, int Day, int Mounth, int Year, double Cache, double PercentDiscount, int Amount)
        {
            this.Code = Code;
            this.Cache = Cache;
            this.PercentDiscount = PercentDiscount;
            this.Amount = Amount;
            ReleaseDate = new DateTime(Year, Mounth, Day);
            prodution = new List<Prodution>();
        }

        public double SubTotal()
        {
            double Discount = Cache * PercentDiscount / 100.0;
            return (Cache * Discount) * Amount;
        }

        //Incompleto
        public double FullValor()
        {
            double sum = 0.0;
            for (int i = 0; i<prodution.Count; i++)
            {
                sum = sum + prodution[i].SubTotal();
            }
            return sum;
        }
    }
}
