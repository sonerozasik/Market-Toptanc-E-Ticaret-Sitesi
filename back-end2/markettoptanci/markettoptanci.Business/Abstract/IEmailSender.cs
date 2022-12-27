using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.Business.Abstract
{
    public interface IEmailSender
    {
        Task<string> SendEmailAsync(string recipiantEmail,string recipientFullName,string Link);

    }
}
