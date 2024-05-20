using DAL.Interface;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFact
    {
        public static IRepo<Stadium, int, bool> StadiumData()
        {
            return new StadiumRepo();
        }
        public static IRepo<Schedule, int, bool> ScheduleData()
        {
            return new ScheduleRepo();
        }
        public static IRepo<User, string, bool> UserData()
        {
            return new UserRepo();
        }
        public static IRepo<Notice, int, bool> NoticeData()
        {
            return new NoticeRepo();
        }
        public static IRepo<Sponsor, int, bool> SponsorData()
        {
            return new SponsorRepo();
        }
        public static IRepo<Event, int, bool> EventData()
        {
            return new EventRepo();
        }
        public static IRepo<Revenue, int, bool> RevenueData()
        {
            return new RevenueRepo();
        }

        public static IRepo<Janitor, int, bool> JanitorData()
        {
            return new JanitorRepo();
        }
    }
}
