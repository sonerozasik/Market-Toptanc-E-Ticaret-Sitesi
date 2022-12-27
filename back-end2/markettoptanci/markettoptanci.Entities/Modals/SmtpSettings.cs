using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.Entities.Modals
{
    [NotMapped]
    public class SmtpSettings
    {
        public string Server { get; set; }

        public int Port { get; set; }

        public string SenderName { get; set; }

        public string SenderEmail { get; set; }

        public string Password { get; set; }

    }
}
