using movieBL;
using movieentity1;
using System;
using System.Collections.Generic;
using System.Text;

namespace movie
{
    public class TheatrePL
    {
        public void AddPerson()
        {
            TheatreBL movieOperations = new TheatreBL();
            Theatre person = new Theatre();
            Console.WriteLine("Enter personname:");
            person.Name = Console.ReadLine();
            Console.WriteLine("Enter address:");
            person.Address = Console.ReadLine();
            Console.WriteLine("Enter comments:");
            person.Comments = Console.ReadLine();
            string msg = movieOperations.AddPerson(person);
            Console.WriteLine(msg);
        }
        public void ShowAllPerson()
        {
            TheatreBL theatreOperations = new TheatreBL();
            List<Theatre> person = theatreOperations.ShowAll();
            foreach (var item in person)
            {
                Console.WriteLine("Id: " + item.Id);
                Console.WriteLine("Name:" + item.Name);
                Console.WriteLine("address:" + item.Address);
                Console.WriteLine("comments:" + item.Comments);
            }
            //List<Movie> movies = movieOperations.ShowMovieById();
        }
        public void updatePerson()
        {
            TheatreBL movieOperations = new TheatreBL();
            Theatre a = new Theatre();
            Console.WriteLine("Enter id:");
            a.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name:");
            a.Name = Console.ReadLine();
            Console.WriteLine("enter Address:");
            a.Address = Console.ReadLine();
            Console.WriteLine("enter comments:");
            a.Comments = Console.ReadLine();
            string msg = movieOperations.UpdatePerson(a);
            Console.WriteLine(msg);
        }
        public void deletePerson()
        {
            TheatreBL personoperations = new TheatreBL();
            Theatre a = new Theatre();
            Console.WriteLine("enter id:");
            a.Id = Convert.ToInt32(Console.ReadLine());
            string msg = personoperations.DeletePerson(a.Id);
            Console.WriteLine(msg);
        }
        public void showbyid()
        {
            try
            {
                TheatreBL personOperations = new TheatreBL();
                Console.WriteLine("Enter id:");
                int Id = Convert.ToInt32(Console.ReadLine());
               Theatre ab =personOperations.ShowPersonById(Id);
                Console.WriteLine("Id: " + ab.Id);
                Console.WriteLine("Name:" + ab.Name);
                Console.WriteLine("Description" + ab.Address);
                Console.WriteLine("Type:" + ab.Comments);
            }
            catch
            {
                Console.WriteLine("this id is not available in the database");
            }
        }
        public void showpersonbytype()
        {
            TheatreBL personOperations = new TheatreBL();
            Console.WriteLine("enter type:");
            string a = Console.ReadLine();
            List<Theatre> person = personOperations.ShowAllBypersonType(a);
            foreach (var ab in person)
            {
                Console.WriteLine("movie id:" + ab.Id);
                Console.WriteLine("movie name:" + ab.Name);
            }
        }
    }
}
