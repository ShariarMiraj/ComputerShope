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


        public static bool Create(SalaryDTO salary)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<SalaryDTO , Salary>();
            });

            var mapper = new Mapper (config);
            var mapped = mapper.Map<Salary>(salary);
            var res = DataAccessFactory.SalaryData().Create(mapped);
            if (res) return true;
            return false;
        }

        public static bool Update(SalaryDTO salary)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<SalaryDTO, Salary>();
            });
            var mapper = new Mapper (config);
            var mapped = mapper.Map<Salary>(salary);
            var res = DataAccessFactory.SalaryData().Update(mapped);
            if (res) return true;
            return false;

        }


        public static bool Delete(int id)
        {
            return DataAccessFactory.SalaryData().Delete(id);
        }




         public static List<PieChartItemDTO> GetPieChartData()
        {
            var pieChartData = DataAccessFactory.SalaryData().ReadForPieChart();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<KeyValuePair<string, decimal>, PieChartItemDTO>()
                    .ForMember(dest => dest.Label, opt => opt.MapFrom(src => src.Key))
                    .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value));
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<PieChartItemDTO>>(pieChartData);
            return mapped;
        }

        /*public static List<PieChartItemDTO> GetPieChartData()
        {
            var pieChartData = DataAccessFactory.SalaryData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<KeyValuePair<string, decimal>, PieChartItemDTO>()
                    .ForMember(dest => dest.Label, opt => opt.MapFrom(src => src.Key))
                    .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value));
            });

            var mapper = new Mapper(cfg);

            // Make sure pieChartData is a collection of KeyValuePair<string, decimal>
            if (pieChartData is IEnumerable<KeyValuePair<string, decimal>> keyValuePairs)
            {
                var mapped = mapper.Map<List<PieChartItemDTO>>(keyValuePairs);
                return mapped;
            }
            else
            {
                // Handle the case where pieChartData is not the expected type.
                // You might log an error or throw an exception.
                return null; // or throw new InvalidOperationException("Unexpected type");
            }
        }


        public static List<PieChartItemDTO> GetPieChartData()
        {
            var pieChartData = DataAccessFactory.SalaryData().ReadForPieChart();

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<KeyValuePair<string, decimal>, PieChartItemDTO>()
                    .ForMember(dest => dest.Label, opt => opt.MapFrom(src => src.Key))
                    .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value));
            });

            var mapper = new Mapper(cfg);

            // Ensure pieChartData is a collection of KeyValuePair<string, decimal>
            if (pieChartData is IEnumerable<KeyValuePair<string, decimal>> keyValuePairs)
            {
                var mapped = mapper.Map<List<PieChartItemDTO>>(keyValuePairs);
                return mapped;
            }
            else
            {
                // Handle the case where pieChartData is not the expected type.
                // You might log an error or throw an exception.
                return new List<PieChartItemDTO>(); // or throw new InvalidOperationException("Unexpected type");
            }
        }*/


    }
}
