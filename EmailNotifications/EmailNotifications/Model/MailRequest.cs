using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace _101SendEmailNotificationDoNetCoreWebAPI.Model
{
    public class MailRequest
    {

        
        public string? ToEmail { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
       public List<IFormFile>? Attachments { get; set; }
    }
}