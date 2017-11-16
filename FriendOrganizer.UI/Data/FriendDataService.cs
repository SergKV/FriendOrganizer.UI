using FriendOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            //TODO: Load data from SQL dataBase
            yield return new Friend() { FirstName = "Thomas", LastName = "Mueller" };
            yield return new Friend() { FirstName = "Andreas", LastName = "Polzer" };
            yield return new Friend() { FirstName = "Michael", LastName = "Krammer" };
            yield return new Friend() { FirstName = "Draxl", LastName = "Vojtech" };
        }
    }
}

