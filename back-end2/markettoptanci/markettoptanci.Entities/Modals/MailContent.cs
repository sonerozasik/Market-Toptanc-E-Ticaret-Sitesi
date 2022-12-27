using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.Entities.Modals
{
    [NotMapped]
    public class MailContent
    {
        public string recipientEmail { get; set; }
        public string recipientFullName { get; set; }
        public string content { get; set; }
    }
}
