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
    public  class FeedBackService
    {
       public static List<FeedBackDTO> Get()
        {
            var data = DataAccessFactory.FeedBackData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FeedBack, FeedBackDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<FeedBackDTO>>(data);
            return mapped;
        }

        public static FeedBackDTO Get(int id)
        {
            var data = DataAccessFactory.FeedBackData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FeedBack, FeedBackDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<FeedBackDTO>(data);
            return mapped;
        }

        public static bool Create(FeedBackDTO cart)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FeedBackDTO, FeedBack>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<FeedBack>(cart);
            var res = DataAccessFactory.FeedBackData().Create(mapped);

            if (res) return true;
            return false;
        }

        public static bool Update(FeedBackDTO cart)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FeedBackDTO, FeedBack>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<FeedBack>(cart);
            var res = DataAccessFactory.FeedBackData().Update(mapped);

            if (res) return true;
            return false;
        }

        public static bool Delete(int Rid)
        {
            return DataAccessFactory.FeedBackData().Delete(Rid);
        }


        public static ReviewFeedBackDTO ReviewFeedBAck(int id)
        {
            var data = DataAccessFactory.ReviewData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Review, ReviewFeedBackDTO>();
                c.CreateMap<FeedBack, FeedBackDTO>();
                
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ReviewFeedBackDTO>(data);
            return mapped;

        }

    }
}
