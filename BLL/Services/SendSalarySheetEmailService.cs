using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;



namespace BLL.Services
{
    public class SendSalarySheetEmailService
    {
        public static bool SendSalEmail(int Id)
        {
            var data = DataAccessFactory.ModeratorData().Read(Id);

            if (data == null)
            {
                return false;
            }

            string email = data.Email;
            var fromAddress = new MailAddress("sumayajahankanta@gmail.com", "ComputerShope");
            var toAddress = new MailAddress(email, data.Ename);
            const string fromPassword = "lkxr lbsx eflf idlr";
            const string subject = "Salary Sheet Attached";


            Salary salarySheetGenerator = new Salary();
            byte[] salarySheetBytes = salarySheetGenerator.GenerateSalarySheet();
            string attachmentFileName = "SalarySheet.pdf";



            using (var smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(fromAddress.Address, fromPassword);

                using (var message = new MailMessage(fromAddress, toAddress))
                {
                    message.Subject = subject;
                    message.Body = "Please find the attached salary sheet.";

                    // Attach the salary sheet
                    using (var ms = new MemoryStream(salarySheetBytes))
                    {
                        message.Attachments.Add(new Attachment(ms, attachmentFileName, "application/pdf"));
                        smtp.Send(message);
                    }
                }
            }

            return true;
        }
    }
}
