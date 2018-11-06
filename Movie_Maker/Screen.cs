using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Movie_Maker
{
    class Screen
    {
        public static void ShowScreen()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("--------Movie Maker-------");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1 - Show All Artists Saved");
            Console.WriteLine("2 - Show datas of Movies"  );
            Console.WriteLine("3 - Register a new Artist" );
            Console.WriteLine("4 - Register a new Movie"  );
            Console.WriteLine("5 - Exit"                  );
            Console.Write    ("Your Choice: "             );
        }

        public static void RegisterMovie()
        {
            Console.Write("Insert how many Movies to register: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Insert the Name of " + i + "º Movie: ");
                string Title = Console.ReadLine();
                Console.Write("Code of Movie: ");
                int Code = int.Parse(Console.ReadLine());
                Console.WriteLine("Artist Datas: ");
                Console.Write("Code: ");
                int ArtistCode = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string Name = Console.ReadLine();
                Console.Write("Cache: $");
                double Cache = double.Parse(Console.ReadLine());
                Console.Write("Amount Of Movies: ");
                int AmountOfMovies = int.Parse(Console.ReadLine());
                Console.Write("Artist Discount: ");
                double PercentDiscount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Artist artist = new Artist(ArtistCode, Name, Cache, AmountOfMovies, PercentDiscount);
                Console.Write("How many sequels will the movie have? ");
                int Amount = int.Parse(Console.ReadLine());
                Movie M = new Movie(Code, Title, artist, PercentDiscount, Amount);
                Program.movies.Add(M);
            }
        }

        public static void RegisterArtist()
        {
            Console.Write("Insert how many Artists to Register: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Insert the Code of " + i + "º Artist: ");
                int Code = int.Parse(Console.ReadLine());
                Console.Write("Insert the Name of Artist: ");
                string Name = Console.ReadLine();
                Console.Write("Insert the Cache of Artist: $");
                double Cache = double.Parse(Console.ReadLine());
                Console.Write("Insert The Amount of Movies: ");
                int AmountOfMovies = int.Parse(Console.ReadLine());
                Console.Write("Insert the Discount of Artist: ");
                double Discount = double.Parse(Console.ReadLine());
                Artist A = new Artist(Code, Name, Cache, AmountOfMovies, Discount);
                Program.artists.Add(A);
            }
        }

        public static void DataMovie()
        {
            Console.WriteLine("Movie's datas: ");
            for (int i = 0; i < Program.movies.Count; i++)
            {
                Console.WriteLine(Program.movies[i]);
            }
        }

        public static void ArtistSaved()
        {
            Console.WriteLine("Artists Saved: ");
            for (int i = 0; i < Program.artists.Count; i++)
            {
                Console.WriteLine(Program.artists[i]);
            }
        }
    }
}
