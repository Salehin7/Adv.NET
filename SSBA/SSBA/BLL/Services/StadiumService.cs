using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StadiumService
    {
        public static List<StadiumDTO> Get()
        {
            var data = DataAccessFact.StadiumData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Stadium, StadiumDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<StadiumDTO>>(data);
            return mapped;
        }

        public static StadiumDTO Get(int id)
        {
            var data = DataAccessFact.StadiumData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Stadium, StadiumDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<StadiumDTO>(data);

            return mapped;
        }

        public static bool CreateStadium(Stadium obj)
        {
            var res = DataAccessFact.StadiumData().Create(obj);
            return res;
        }

        public static bool DeleteStadium(int id)
        {
            var res = DataAccessFact.StadiumData().Delete(id);
            return res;
        }

        public static bool UpdateStadium(Stadium obj)
        {

            var res = DataAccessFact.StadiumData().Update(obj);
            Get(obj.StadiumId);
            return res;
        }

    }
}
