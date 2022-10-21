using movieentity1;
using System;
using System.Collections.Generic;
using System.Text;

namespace movieDataLayer.Repository
{
    public interface IshowTimingRepository
    {
        void AddShowTiming(ShowTiming showtiming);
        void UpdateShowTiming(ShowTiming showtiming);
        void DeleteShowTiming(int showtimingid);
        ShowTiming GetShowTimingById(int showtimingid);
        IEnumerable<ShowTiming> GetShowTimings();
    }
}
