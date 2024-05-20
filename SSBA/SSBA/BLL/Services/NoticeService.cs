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
    public class NoticeService
    {
        public static List<NoticeDTO> Get()
        {
            var data = DataAccessFact.NoticeData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Notice, NoticeDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<NoticeDTO>>(data);
            return mapped;
        }

        public static NoticeDTO Get(int id)
        {
            var data = DataAccessFact.NoticeData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Notice, NoticeDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<NoticeDTO>(data);

            return mapped;
        }

        public static bool CreateNotice(Notice obj)
        {
            var res = DataAccessFact.NoticeData().Create(obj);
            return res;
        }

        public static bool DeleteNotice(int id)
        {
            var res = DataAccessFact.NoticeData().Delete(id);
            return res;
        }

        public static bool UpdateNotice(Notice obj)
        {
            var res = DataAccessFact.NoticeData().Update(obj);
            Get(obj.NId);
            return res;
        }
    }
}
