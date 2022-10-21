using System;

namespace movie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MoviePL moviePL = new MoviePL();
            //moviePL.showmoviebytype();
             //moviePL.AddMovie();
            //moviePL.ShowAllMovies();
            //moviePL.updatemovie();
            //moviePL.deletemovie();
            //moviePL.showbyid();



            //TheatrePL theatrePL = new TheatrePL();
            //theatrePL.AddPerson();
            //theatrePL.updatePerson();
            //theatrePL.deletePerson();
            //theatrePL.showbyid();
            //theatrePL.showpersonbytype();
            //theatrePL.ShowAllPerson();


            b ab=new b();
            ab.aa();

        }
       
    }
    public class a
    {
        public virtual void aa()
        {
            Console.WriteLine("parent");
        }
    }
    public class b : a
    {
        public new void aa()
        {
            Console.WriteLine("child");
        }
    }
}
