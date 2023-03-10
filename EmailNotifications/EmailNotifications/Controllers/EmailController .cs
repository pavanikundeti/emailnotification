using _101SendEmailNotificationDoNetCoreWebAPI.Model;
using _101SendEmailNotificationDoNetCoreWebAPI.Services;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Policy;
using System.Threading.Tasks;
using ZedGraph;
using static System.Net.WebRequestMethods;

namespace _101SendEmailNotificationDoNetCoreWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmailController : Controller
    {

        private readonly IMailService mailService;
        public EmailController(IMailService mailService)
        {
            this.mailService = mailService;
        }

        [HttpPost("Send")]
        public async Task<IActionResult> Send([FromForm] MailRequest request)
        {
            try
            {
                await mailService.SendEmailAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }
}
