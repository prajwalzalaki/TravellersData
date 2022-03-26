using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travel_Api.Models;

namespace Travel_Api.IServices
{
    public interface ITravelServices
    {
        IEnumerable<Travel> GetTravel();
        Travel DeleteTravel(int id);
        Travel EditTravel(Travel trvl);
        Travel AddTravel(Travel trvl);
    }
}
