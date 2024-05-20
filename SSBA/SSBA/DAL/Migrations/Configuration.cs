using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Models.SSBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        /*protected override void Seed(DAL.Models.SSBContext context)
        {
            if (!context.Stadiums.Any())
            {
                string[] stadiumNames = { "Stadium A", "Stadium B", "Stadium C", "Stadium D", "Stadium E" };
                string[] locations = { "City X", "City Y", "City Z", "City W", "City V" };
                int[] capacities = { 10000, 15000, 20000, 25000, 30000 };

                for (int i = 0; i < stadiumNames.Length; i++)
                {
                    context.Stadiums.AddOrUpdate(s => s.StadiumName, new Models.Stadium
                    {
                        StadiumName = stadiumNames[i],
                        Location = locations[i],
                        Capacity = capacities[i]
                    });
                }
            }

            if (!context.Schedules.Any())
            {
                string[] types = { "Football", "Basketball", "Concert", "Cricket", "Rugby" };
                string[] locations = { "Location 1", "Location 2", "Location 3", "Location 4", "Location 5" };
                string[] times = { "10:00 AM", "2:00 PM", "6:00 PM", "8:00 PM", "12:00 PM" };

                for (int i = 0; i < types.Length; i++)
                {
                    context.Schedules.AddOrUpdate(s => s.Type, new Models.Schedule
                    {
                        Type = types[i],
                        Location = locations[i],
                        Time = times[i]
                    });
                }
            }

            if (!context.Sponsors.Any())
            {
                string[] sponsorNames = { "Sponsor 1", "Sponsor 2", "Sponsor 3", "Sponsor 4", "Sponsor 5" };
                string[] sponsorTerms = { "Terms 1", "Terms 2", "Terms 3", "Terms 4", "Terms 5" };
                int[] sponsorRevenues = { 1000, 2000, 3000, 4000, 5000 };

                for (int i = 0; i < sponsorNames.Length; i++)
                {
                    context.Sponsors.AddOrUpdate(s => s.SponsorName, new Models.Sponsor
                    {
                        SponsorName = sponsorNames[i],
                        SponsorTerms = sponsorTerms[i],
                        SponsorRev = sponsorRevenues[i]
                    });
                }
            }

            if (!context.Events.Any())
            {
                string[] eventNames = { "Event 1", "Event 2", "Event 3", "Event 4", "Event 5" };
                string[] eventTypes = { "Concert", "Expo", "Festival", "Concert", "Expo" };
                int[] eventTickets = { 100, 200, 300, 400, 500 };
                int[] eventRevenues = { 10000, 20000, 30000, 40000, 50000 };
                int[] eventTimes = { 1, 2, 3, 4, 5 };

                for (int i = 0; i < eventNames.Length; i++)
                {
                    context.Events.AddOrUpdate(e => e.EventName, new Models.Event
                    {
                        EventName = eventNames[i],
                        EventType = eventTypes[i],
                        EventTicket = eventTickets[i],
                        EventRev = eventRevenues[i],
                        EventTime = eventTimes[i]
                    });
                }
            }

            if (!context.Notices.Any())
            {
                string[] noticeTitles = { "Notice 1", "Notice 2", "Notice 3", "Notice 4", "Notice 5" };
                string[] noticeDescriptions = { "Description 1", "Description 2", "Description 3", "Description 4", "Description 5" };

                for (int i = 0; i < noticeTitles.Length; i++)
                {
                    context.Notices.AddOrUpdate(n => n.NTitle, new Models.Notice
                    {
                        NTitle = noticeTitles[i],
                        NDescription = noticeDescriptions[i]
                    });
                }
            }

            if (!context.Users.Any())
            {
                int customerId = 1;
                int managerId = 1001;
                int janitorId = 2001;

                for (int i = 1; i <= 5; i++)
                {
                    string userId = $"21-44543-{customerId++}";
                    context.Users.AddOrUpdate(u => u.UId, new Models.User
                    {
                        UId = userId,
                        Name = $"Customer {i}",
                        Password = $"CustomerPassword{i}",
                        UType = "Customer"
                    });
                }

                for (int i = 1; i <= 3; i++)
                {
                    string userId = $"21-44543-{managerId++}";
                    context.Users.AddOrUpdate(u => u.UId, new Models.User
                    {
                        UId = userId,
                        Name = $"Manager {i}",
                        Password = $"ManagerPassword{i}",
                        UType = "Manager"
                    });
                }

                for (int i = 1; i <= 2; i++)
                {
                    string userId = $"21-44543-{janitorId++}";
                    context.Users.AddOrUpdate(u => u.UId, new Models.User
                    {
                        UId = userId,
                        Name = $"Janitor {i}",
                        Password = $"JanitorPassword{i}",
                        UType = "Janitor"
                    });
                }
                if (context.Revenues.Any())
                {
                    var events = context.Events.ToList();
                    var sponsors = context.Sponsors.ToList();

                    foreach (var evnt in events)
                    {
                        foreach (var sponsor in sponsors)
                        {
                            context.Revenues.AddOrUpdate(r => new { r.EventId, r.SponsorId }, new Models.Revenue
                            {
                                EventId = evnt.EventId,
                                SponsorId = sponsor.SponsorId,
                                EventRev = evnt.EventRev,
                                SponsorRev = sponsor.SponsorRev
                            });
                        }
                    }

                    context.SaveChanges();
                }
            }
        }*/
    }
}