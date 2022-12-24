using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace markettoptanci.Entities
{
    public class Delivery
    {
        [Key]
        public int Id { get; set; }
        public string TrackNumber { get; set; }
        public string Status { get; set; }
        public string CompanyName { get; set; }
        public Order? Order { get; set; }
    }
}
