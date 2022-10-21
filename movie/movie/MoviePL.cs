using System;
using System.Collections.Generic;
using System.Text;
using static movieentity1.MovieEL;
using movieBL;
using movieentity1;
using Microsoft.EntityFrameworkCore;
namespace movie
{
    public class MoviePL
    {

        public void AddMovie()
        {
            MovieBL movieOperations = new MovieBL();
            MovieEL movie = new MovieEL();
            Console.WriteLine("Enter MovieName:");
            movie.Name = Console.ReadLine();
            Console.WriteLine("Enter MovieDesc:");
            movie.MovieDesc = Console.ReadLine();
            Console.WriteLine("Enter MovieType:");
            movie.MovieType = Console.ReadLine();
            string msg = movieOperations.AddMovies(movie);
            Console.WriteLine(msg);
        }
        public void ShowAllmovie()
        {
            MovieBL movieOperations = new MovieBL();
            List<MovieEL> movies = movieOperations.ShowAll();
            foreach (var item in movies)
            {
                Console.WriteLine("Id: " + item.Id);
                Console.WriteLine("Name:" + item.Name);
                Console.WriteLine("Description:" + item.MovieDesc);
                Console.WriteLine("Type:" + item.MovieType);
            }
            //List<Movie> movies = movieOperations.ShowMovieById();
        }
        public void updatemovie()
        {
            MovieBL movieOperations = new MovieBL();
            MovieEL a = new MovieEL();
            Console.WriteLine("Enter id:");
            a.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name:");
            a.Name = Console.ReadLine();
            Console.WriteLine("enter description:");
            a.MovieDesc = Console.ReadLine();
            Console.WriteLine("enter movie type:");
            a.MovieType = Console.ReadLine();
            string msg = movieOperations.UpdateMovies(a);
            Console.WriteLine(msg);
        }
        public void deletemovie()
        {
            MovieBL movieoperations = new MovieBL();
            MovieEL a = new MovieEL();
            Console.WriteLine("enter id:");
            a.Id = Convert.ToInt32(Console.ReadLine());
            string msg = movieoperations.DeleteMovies(a.Id);
            Console.WriteLine(msg);
        }
        public void showbyid()
        {
            try
            {
                MovieBL movieOperations = new MovieBL();
                Console.WriteLine("Enter id:");
                int Id = Convert.ToInt32(Console.ReadLine());
                MovieEL ab = movieOperations.ShowMovieById(Id);
                Console.WriteLine("Id: " + ab.Id);
                Console.WriteLine("Name:" + ab.Name);
                Console.WriteLine("Description" + ab.MovieDesc);
                Console.WriteLine("Type:" + ab.MovieType);
            }
            catch
            {
                Console.WriteLine("this id is not available");
            }
        }
        public void showmoviebytype()
        {
            MovieBL movieOperations = new MovieBL();
            Console.WriteLine("enter type:");
            string a = Console.ReadLine();
            List<MovieEL> movies = movieOperations.ShowAllByMovieType(a);
            foreach (var ab in movies)
            {
                Console.WriteLine("movie id:" + ab.Id);
                Console.WriteLine("movie name:" + ab.Name);
            }
        }

    }
}
