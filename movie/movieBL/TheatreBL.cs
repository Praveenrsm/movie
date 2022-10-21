using Microsoft.EntityFrameworkCore;
using movieDataLayer;
using movieentity1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace movieBL
{
    public class TheatreBL
    {
        MovieContext db = null;
        public TheatreBL(MovieContext db)
        {
            this.db = db;
        }
        public string AddPerson(Theatre person)
        {
            //db = new MovieContext();
            db.theatre.Add(person);
            db.SaveChanges();
            return "saved";
        }
        public string UpdatePerson(Theatre person)
        {
           // db = new MovieContext();
            db.Entry(person).State = EntityState.Modified;
            db.SaveChanges();
            return "updated";
        }
        public string DeletePerson(int personid)
        {
           // db = new MovieContext();
            Theatre personobj = db.theatre.Find(personid);
            db.Entry(personobj).State = EntityState.Deleted;
            db.SaveChanges();
            return "deleted";
        }
        public List<Theatre> ShowAll()
        {
           // db = new MovieContext();
            List<Theatre> personlist = db.theatre.ToList();
            return personlist;
        }
        public List<Theatre> ShowAllBypersonType(string type)
        {
            //db = new MovieContext();
            List<Theatre> personname = db.theatre.ToList();
            //linq query -> select * from movie where movietype="type"
            var result = from theatre in personname
                         where theatre.Name == type
                         orderby theatre.Name ascending
                         select new Theatre { Name = theatre.Name, Id = theatre.Id };
            List<Theatre> personresult = new List<Theatre>();
            foreach (var item in result) //linq query execution
            {
                personresult.Add(item);
            }
            return personresult;
        }
        public Theatre ShowPersonById(int personid)
        {
           // db = new MovieContext();
            Theatre p = db.theatre.Find(personid);
            return p;
        }
    }
}
