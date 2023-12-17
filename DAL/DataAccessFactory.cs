﻿using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class DataAccessFactory
    {
        public static IRepo<Moderator , int ,bool > ModeratorData()
        {
            return new ModeratorRepo();
        }

        public static IRepo<Salary , int ,bool> SalaryData() 
        {
            return new SalaryRepo();
        }

        public static IRepo<AttendanceReport, int, bool> AttendanceReportData()
        {
            return new AttendanceReportRepo();
        }
    }
}