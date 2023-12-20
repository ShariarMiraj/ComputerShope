﻿using AutoMapper;
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
    public  class ProductService
    {
        public static List<ProductDTO> Get()
        {
            var data = DataAccessFactory.ProductData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<ProductDTO>>(data);
            return mapped;
        }

        public static ProductDTO Get(string course)
        {
            var data = DataAccessFactory.ProductData().Read(course);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<ProductDTO>(data);
            return mapped;
        }

        public static bool Create(ProductDTO course)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductDTO, Product>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Product>(course);
            var res = DataAccessFactory.ProductData().Create(mapped);
            if (res != null) return true;
            return false;
        }


        public static bool Update(ProductDTO course)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductDTO, Product>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Product>(course);
            var res = DataAccessFactory.ProductData().Update(mapped);
            if (res != null) return true;
            return false;
        }


        public static bool Delete(string id)
        {
            return DataAccessFactory.ProductData().Delete(id);
        }

       

    }
}
