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
    public class SponsorService
    {
        public static List<SponsorDTO> Get()
        {
            var data = DataAccessFact.SponsorData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Sponsor, SponsorDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<SponsorDTO>>(data);
            return mapped;
        }

        public static SponsorDTO Get(int id)
        {
            var data = DataAccessFact.SponsorData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Sponsor, SponsorDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<SponsorDTO>(data);

            return mapped;
        }

        public static bool CreateSponsor(Sponsor obj)
        {
            var res = DataAccessFact.SponsorData().Create(obj);
            return res;
        }

        public static bool DeleteSponsor(int id)
        {
            var res = DataAccessFact.SponsorData().Delete(id);
            return res;
        }

        public static bool UpdateSponsor(Sponsor obj)
        {

            var res = DataAccessFact.SponsorData().Update(obj);
            Get(obj.SponsorId);
            return res;
        }
    }
}

