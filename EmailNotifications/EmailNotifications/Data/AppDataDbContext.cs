using _101SendEmailNotificationDoNetCoreWebAPI.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace _101SendEmailNotificationDoNetCoreWebAPI.Data
{
    public class AppDataDbContext:DbContext
    {
        public AppDataDbContext(DbContextOptions options) : base(options)
        {

        }
        //public DbSet<EmailTemplates> EmailTemplates { get; set; }
        public DbSet<MailRequest> MailRequests { get; set; }
        public object MailRequest { get; internal set; }
    }
}
