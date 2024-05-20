using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services 
{
    public class EventService
    {
        public static List<EventDTO> Get()
        {
            var data = DataAccessFact.EventData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Event, EventDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<EventDTO>>(data);
            return mapped;
        }

        public static EventDTO Get(int id)
        {
            var data = DataAccessFact.EventData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Event, EventDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<EventDTO>(data);

            return mapped;
        }

        public static bool CreateEvent(Event obj)
        {
            var res = DataAccessFact.EventData().Create(obj);
            return res;
        }

        public static bool DeleteEvent(int id)
        {
            var res = DataAccessFact.EventData().Delete(id);
            return res;
        }

        public static bool UpdateEvent(Event obj)
        {
            var res = DataAccessFact.EventData().Update(obj);
            Get(obj.EventId);
            return res;
        }
    }
}
