using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

       public static IAuth<bool> AuthData()
        {
            return new ModeratorRepo();
        }

        public static IRepo<Token, string, Token> TokenData()
        {
            return new TokenRepo();
        }

        public static IChange ChangePassData()
        {
            return new ModeratorRepo();
        }

        public static IRepo<TopSearchSelleingproduct, string, TopSearchSelleingproduct> TopSearchSelleingproductdata()
        {
            return new TopSearchSelleingproductRepo();
        }

        public static IRepo<Product, int , bool> ProductData() 
        {
            return new ProductRepo();
        }


        public static IRepo<Review, int, bool> ReviewData()
        {
            return new ReviewRepo();
        }

        public static IRepo<FeedBack, int , bool> FeedBackData() 
        {
            return new FeedBackRepo();
        }
    }
}
