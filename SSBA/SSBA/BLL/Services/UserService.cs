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
    public class UserService
    {
        public static List<UserDTO> Get()
        {
            var data = DataAccessFact.UserData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<UserDTO>>(data);
            return mapped;
        }

        public static UserDTO Get(string id)
        {
            var data = DataAccessFact.UserData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<UserDTO>(data);

            return mapped;
        }

        public static bool CreateUser(User obj)
        {
            var res = DataAccessFact.UserData().Create(obj);
            return res;
        }

        public static bool DeleteUser(string id)
        {
            var res = DataAccessFact.UserData().Delete(id);
            return res;
        }

        public static bool UpdateUser(User obj)
        {
            var res = DataAccessFact.UserData().Update(obj);
            Get(obj.UId);
            return res;
        }
    }
}
