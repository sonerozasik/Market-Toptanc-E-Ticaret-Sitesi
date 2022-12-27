using markettoptanci.Business.Abstract;
using markettoptanci.Business.Concrete;
using markettoptanci.Entities;
using markettoptanci.Entities.Modals;
using Microsoft.AspNetCore.Mvc;

namespace markettoptanci.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailSenderController : ControllerBase
    {
        private IEmailSender _emailService;
        public EmailSenderController(IEmailSender emailSender)
        {
            _emailService = emailSender;
        }


        [HttpPost,Route("SendEmail")]
        
        public async Task<IActionResult> SendEmailAsync([FromBody] MailContent mailContent)
        {
            try
            {
                string messageStatus = await _emailService.SendEmailAsync(mailContent.recipientEmail, mailContent.recipientFullName, mailContent.content);
                return Ok(messageStatus);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }

        
    }
}

