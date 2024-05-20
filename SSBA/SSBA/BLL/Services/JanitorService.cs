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
    public class JanitorService
    {
        public static List<JanitorDTO> Get()
        {
            var data = DataAccessFact.JanitorData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Janitor, JanitorDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<JanitorDTO>>(data);
            return mapped;
        }

        public static JanitorDTO Get(int id)
        {
            var data = DataAccessFact.JanitorData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Janitor, JanitorDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<JanitorDTO>(data);

            return mapped;
        }

        public static bool CreateStadium(Janitor obj)
        {
            var res = DataAccessFact.JanitorData().Create(obj);
            return res;
        }

        public static bool DeleteStadium(int id)
        {
            var res = DataAccessFact.JanitorData().Delete(id);
            return res;
        }

        public static bool UpdateStadium(Janitor obj)
        {

            var res = DataAccessFact.JanitorData().Update(obj);
            Get(obj.JId);
            return res;
        }
    }
}
