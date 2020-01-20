using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningTenta
{
    class Broker
    {
        protected List<RealEstate> RealEstates { get; set; } = new List<RealEstate>();

        public Broker()
        {

            RealEstates = new List<RealEstate>()
        {
            new RealEstate() { Id = 1, Address = "Gågatan 22", Rooms = 1, Area = 57},
            new RealEstate() { Id = 4, Address = "Strandvägen 1",  Rooms = 6, Area = 125},
            new RealEstate() { Id = 5, Address = "Humlestigen 14", Rooms = 5, Area = 125 },
            new RealEstate() { Id = 9, Address = "Ljunggatan 12 b", Rooms = 1, Area = 42 }

        };


        }
        public List<RealEstate> GetList()

        {
            return RealEstates;
        }

        public List<RealEstate> GetSuitableRealEstate(int minimumRooms, int maximumRooms)
        {
            
            List<RealEstate> suitable = new List<RealEstate>();

            foreach (RealEstate estate in RealEstates)
            {
                if (estate.Rooms >= minimumRooms && estate.Rooms <= maximumRooms)
                {
                    suitable.Add(estate);
                    
                }
                
            }
            if (suitable.Count == 0)
            {
                return null;
            }
            return suitable;
            
        }
        public bool AddRealEstate(RealEstate realEstate)
        { int newId = 0;
            int snittArea = realEstate.Area / realEstate.Rooms;

            if (snittArea < 10 || snittArea > 50)
            {
                return false;
            }

            foreach (RealEstate estate in RealEstates) // kan också använda var var
            {
                if (estate.Id >= newId)
                {
                    newId = estate.Id + 1;
                }

            }

            realEstate.Id = newId;
            RealEstates.Add(realEstate);
            return true;
         
        }

    }
}
