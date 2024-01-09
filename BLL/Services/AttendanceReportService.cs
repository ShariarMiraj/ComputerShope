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
    public  class AttendanceReportService
    {
        public static List<AttendanceReportDTO> Get()
        {
            var data  = DataAccessFactory.AttendanceReportData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AttendanceReport , AttendanceReportDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<AttendanceReportDTO>>(data);
            return mapped;
        }

        public static AttendanceReportDTO Get(int id)
        {
            var data = DataAccessFactory.AttendanceReportData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AttendanceReport, AttendanceReportDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<AttendanceReportDTO>(data);
            return mapped;
        }


        public static bool Create(AttendanceReportDTO attendanceReport)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AttendanceReportDTO, AttendanceReport>();
            });

            var mapper = new Mapper(config);
            var mapped = mapper.Map<AttendanceReport>(attendanceReport);
            var res = DataAccessFactory.AttendanceReportData().Create(mapped);
            if (res) return true;
            return false;
        }


        public static bool Upadte(AttendanceReportDTO attendanceReport)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AttendanceReportDTO, AttendanceReport>();
            });

            var mapper = new Mapper(config);
            var mapped = mapper.Map<AttendanceReport>(attendanceReport);
            var res = DataAccessFactory.AttendanceReportData().Update(mapped);
            if (res) return true;
            return false;
        }


        public static bool Delete(int id)
        {
            return DataAccessFactory.AttendanceReportData().Delete(id);
        }

        
        public static List<AttendancePieChartDTO> GetAttendance()
        {
            var data = DataAccessFactory.AttendanceReportData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AttendanceReport, AttendancePieChartDTO>()
                    .ForMember(dest => dest.EmployeeName, opt => opt.MapFrom(src => src.EmployeeName))
                    .ForMember(dest => dest.DateTime, opt => opt.MapFrom(src => src.DateTime.Date))
                    .ForMember(dest => dest.Count, opt => opt.MapFrom(src => src.Count)); // Assuming each record represents one attendance

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<AttendancePieChartDTO>>(data);
            return mapped;
        }


    }
}
