using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class RevenueService
    {

        public static List<RevenueDTO> Get()
        {
            var data = DataAccessFact.RevenueData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Revenue, RevenueDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<RevenueDTO>>(data);
            return mapped;
        }

        public static RevenueDTO Get(int id)
        {
            var data = DataAccessFact.RevenueData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Revenue, RevenueDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<RevenueDTO>(data);

            return mapped;
        }

        public static bool CreateRevenue(Revenue obj)
        {
            var res = DataAccessFact.RevenueData().Create(obj);
            return res;
        }

        public static bool DeleteRevenue(int id)
        {
            var res = DataAccessFact.RevenueData().Delete(id);
            return res;
        }

        public static bool UpdateRevenue(Revenue obj)
        {

            var res = DataAccessFact.RevenueData().Update(obj);
            Get(obj.RevId);
            return res;
        }


    }
}
