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
    public class ScheduleService
    {
        public static List<ScheduleDTO> Get()
        {
            var data = DataAccessFact.ScheduleData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Schedule, ScheduleDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ScheduleDTO>>(data);
            return mapped;
        }

        public static ScheduleDTO Get(int id)
        {
            var data = DataAccessFact.ScheduleData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Schedule, ScheduleDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ScheduleDTO>(data);

            return mapped;
        }

        public static bool CreateSchedule(Schedule obj)
        {
            var res = DataAccessFact.ScheduleData().Create(obj);
            return res;
        }

        public static bool DeleteSchedule(int id)
        {
            var res = DataAccessFact.ScheduleData().Delete(id);
            return res;
        }

        public static bool UpdateSchedule(Schedule obj)
        {

            var res = DataAccessFact.ScheduleData().Update(obj);
            Get(obj.Id);
            return res;
        }
    }
}
