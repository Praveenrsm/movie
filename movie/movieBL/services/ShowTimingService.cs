using movieDataLayer.Repository;
using movieentity1;
using System;
using System.Collections.Generic;
using System.Text;

namespace movieBL.services
{
    public class ShowTimingService
    {
        IshowTimingRepository _showtimingRepository;
        public ShowTimingService(IshowTimingRepository showtimingRepository)
        {
            this._showtimingRepository = showtimingRepository;
        }
        public void AddShowTiming(ShowTiming showtiming)
        {
            _showtimingRepository.AddShowTiming(showtiming);
        }
        public void UpdateShowTiming(ShowTiming showtiming)
        {
            _showtimingRepository.UpdateShowTiming(showtiming);
        }
        public void DeleteShowTiming(int showtimingid)
        {
            _showtimingRepository.DeleteShowTiming(showtimingid);
        }
        //get movie by id
        public void GetShowTimingById(int showtimingid)
        {
            _showtimingRepository.GetShowTimingById(showtimingid);
        }
        //get movies
        public IEnumerable<ShowTiming> GetShowTimings()
        {
            return _showtimingRepository.GetShowTimings();
        }
    }
}
