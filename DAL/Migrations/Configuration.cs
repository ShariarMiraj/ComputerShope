namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.ComputerShopeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.ComputerShopeContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            /* Random random = new Random();
              for (int i = 1; i <= 10; i++)
             {
                 context.Moderators.AddOrUpdate(new Models.Moderator
                 {
                     Id = i,
                     Ename = "Ename-" + i,
                     Password = Guid.NewGuid().ToString().Substring(0, 5),
                     Post = "sellesman",
                     Email = Guid.NewGuid().ToString().Substring(0, 5),
                     PhoneNumber = random.Next(1, 6),
                 });
             }

             for (int i = 1; i <= 20; i++)
             {
                 context.Salaris.AddOrUpdate(new Models.Salary
                 {
                     Id= i,
                     MonthName = Guid.NewGuid().ToString(),
                     Date = DateTime.Now,
                     Amount = Guid.NewGuid().ToString(),
                     ReportedBy = random.Next(1, 6),
                 });
             }

             for (int i = 1; i <= 30; i++)
             {
                 context.AttendanceReports.AddOrUpdate(new Models.AttendanceReport
                 {
                     Id = i,
                     EmployeeName = Guid.NewGuid().ToString().Substring(0,5),
                     DateTime = DateTime.Now,
                     MId = random.Next(1, 11),
                 });
             }


             for (int i = 1; i <= 3; i++)
             {
                 context.TopSearchSelleingproducts.AddOrUpdate(new Models.TopSearchSelleingproduct
                 {
                     Id = i,
                     TopProductName = Guid.NewGuid().ToString().Substring(0, 10),
                     Count = i,
                     Time = DateTime.Now,

                 });
             }

             Random random = new Random();
             for (int i = 1; i <= 10; i++)
             {
                 context.Products.AddOrUpdate(new Models.Product
                 {
                     Id = i,
                     ProductName = Guid.NewGuid().ToString().Substring(0, 10),
                     ProdcutQuantity = random.Next(100, 500),
                     ProductCategory = Guid.NewGuid().ToString().Substring(0, 10),
                     ProductPrice = random.Next(10000, 50000),

                 });
             }






              for (int i = 0; i < 50; i++) 
              {
                  context.Reviews.AddOrUpdate(new Models.Review
                  {
                      Id = i,
                      ReviewDatas = Guid.NewGuid().ToString().Substring(0, 30),
                      Date = DateTime.Now,
                      Pid = random.Next(1,9),

                  });
              }


              for (int i = 1; i <= 50; i++)
              {
                  context.FeedBacks.AddOrUpdate(new Models.FeedBack
                  {
                      Id = i,
                      Date = DateTime.Now,
                      ReviewFeedBack = Guid.NewGuid().ToString().Substring(0, 30),
                      Rid = random.Next(1, 49),
                  });
              }*/

        }
    }
}
