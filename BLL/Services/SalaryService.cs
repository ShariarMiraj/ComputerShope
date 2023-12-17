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
    public  class SalaryService
    {
        public static List<SalaryDTO> Get()
        {
            var data = DataAccessFactory.SalaryData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Salary , SalaryDTO>();

            });
            var mapper = new Mapper (cfg);
            var mapped = mapper.Map<List<SalaryDTO>>(data);
            return mapped;

        }

        public static SalaryDTO Get(int id) 
        {
            var data = DataAccessFactory.SalaryData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Salary, SalaryDTO>();
            });

            var mapper = new Mapper (cfg);
            var mapped = mapper.Map<SalaryDTO>(data);
            return mapped;
        }
    }
}
