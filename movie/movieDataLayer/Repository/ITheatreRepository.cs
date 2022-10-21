using movieentity1;
using System;
using System.Collections.Generic;
using System.Text;

namespace movieDataLayer.Repository
{
    public interface ITheatreRepository
    {
        void AddTheatre(Theatre theatre);
        void UpdateTheatre(Theatre theatre);
        void DeleteTheatre(int theatreid);
        Theatre GetTheatreById(int theatreid);
        IEnumerable<Theatre> GetTheatres();
    }
}
