using Microsoft.EntityFrameworkCore;
using movieDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using movieentity1;
namespace movieBL
{
    public class ShowTimingBL
    {
        MovieContext db = null;
        public ShowTimingBL(MovieContext db)
        {
            this.db = db;
        }
        public string AddPerson(ShowTiming person)
        {
            //db = new MovieContext();
            db.showTiming.Add(person);
            db.SaveChanges();
            return "saved";
        }
        public string UpdatePerson(ShowTiming person)
        {
            // db = new MovieContext();
            db.Entry(person).State = EntityState.Modified;
            db.SaveChanges();
            return "updated";
        }
        public string DeletePerson(int personid)
        {
            // db = new MovieContext();
            ShowTiming personobj = db.showTiming.Find(personid);
            db.Entry(personobj).State = EntityState.Deleted;
            db.SaveChanges();
            return "deleted";
        }
        public List<ShowTiming> ShowAll()
        {
            // db = new MovieContext();
            List<ShowTiming> personlist = db.showTiming.ToList();
            return personlist;
        }
        //public List<ShowTiming> ShowAllBypersonType(int type)
        //{
        //    //db = new MovieContext();
        //    List<ShowTiming> personname = db.showTiming.ToList();
        //    //linq query -> select * from movie where movietype="type"
        //    var result = from showTiming in personname
        //                 where showTiming.MovieId == type
        //                 orderby showTiming.MovieId ascending
        //                 select new Theatre { MovieId = showTiming.MovieId, Id = showTiming.Id };
        //    List<Theatre> personresult = new List<Theatre>();
        //    foreach (var item in result) //linq query execution
        //    {
        //        personresult.Add(item);
        //    }
        //    return personresult;
        //}
        public ShowTiming ShowPersonById(int personid)
        {
            // db = new MovieContext();
            ShowTiming p = db.showTiming.Find(personid);
            return p;
        }
    }
}
