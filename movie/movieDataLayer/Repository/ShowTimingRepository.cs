using Microsoft.EntityFrameworkCore;
using movieentity1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace movieDataLayer.Repository
{
    public class ShowTimingRepository:IshowTimingRepository
    {
        MovieContext _movieDbcontext;
        public ShowTimingRepository(MovieContext context)
        {
            this._movieDbcontext = context;
        }
        public void AddShowTiming(ShowTiming showtiming)
        {
            _movieDbcontext.showTiming.Add(showtiming);
            _movieDbcontext.SaveChanges();
        }
        public void DeleteShowTiming(int showtimingid)
        {
            var showtiming = _movieDbcontext.showTiming.Find(showtimingid);
            _movieDbcontext.showTiming.Remove(showtiming);
            _movieDbcontext.SaveChanges();
        }
        public IEnumerable<ShowTiming> GetShowTimings()
        {
            return _movieDbcontext.showTiming.ToList();
        }
        public ShowTiming GetShowTimingById(int showtimingid)
        {
            return _movieDbcontext.showTiming.Find(showtimingid);
        }
        public void UpdateShowTiming(ShowTiming showtiming)
        {
            _movieDbcontext.Entry(showtiming).State = EntityState.Modified;
            _movieDbcontext.SaveChanges();
        }
    }
}
