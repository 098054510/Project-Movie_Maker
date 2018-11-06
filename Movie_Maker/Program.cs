using System;
using System.Collections.Generic;

namespace Movie_Maker
{
    class Program
    {
        public static List<Movie>  movies =  new List<Movie>();
        public static List<Artist> artists = new List<Artist>();

        static void Main(string[] args)
        {

            int option = 0;

            while (option != 5)
            {
                Console.Clear();
                Screen.ShowScreen();

                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Internal Error " + e.Message);
                    option = 0;
                }

                if (option == 4)
                {
                    Screen.RegisterMovie();
                    Console.WriteLine("Movie Registered.");

                    try
                    {
                        option = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Internal Error " + e.Message);
                        option = 0;
                    }
                }

                else if (option == 3)
                {
                    Screen.RegisterArtist();
                    Console.WriteLine("Artist Registered.");

                    try
                    {
                        option = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Internal Error " + e.Message);
                        option = 0;
                    }
                }

                else if (option == 2)
                {
                    Screen.DataMovie();
                    Console.WriteLine("Press 'ENTER' to continue.");

                    try
                    {
                        option = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Internal Error " + e.Message);
                        option = 0;
                    }
                }
                else if (option == 1)
                {
                    Screen.ArtistSaved();
                    Console.WriteLine("Press 'ENTER' to continue.");
                    try
                    {
                        option = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Internal Error " + e.Message);
                        option = 0;
                    }
                }
                else if (option == 5)
                {
                    Console.WriteLine("Have a good day.");
                }
            }
            Console.ReadLine();
        }
    }
}