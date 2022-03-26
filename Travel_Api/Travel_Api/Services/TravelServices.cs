using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travel_Api.IServices;
using Travel_Api.Models;

namespace Travel_Api.Services
{
    public class TravelServices:ITravelServices
    {
        TRAVELContext dbcontext;
        public TravelServices(TRAVELContext db)
        {
            dbcontext = db;
        }
        public Travel AddTravel(Travel trvl)
        {
            dbcontext.Travel.Add(trvl);
            dbcontext.SaveChanges();
            return trvl;
        }

        public Travel DeleteTravel(int id)
        {
            var trvl = dbcontext.Travel.Find(id);
            dbcontext.Travel.Remove(trvl);
            dbcontext.SaveChanges();
            return trvl;
        }


        public Travel EditTravel(Travel trvl)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Travel> GetTravel()
        {
            return dbcontext.Travel.ToList();
        }

        public Travel UpdateTravel(Travel travel)
        {
            dbcontext.Entry(travel).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbcontext.SaveChanges();
            return travel;
        }
    }
}

