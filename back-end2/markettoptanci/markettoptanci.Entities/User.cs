using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace markettoptanci.Entities
{
    // pasword hash null olduğu için hata veriyo video dakikası 27.38
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

        //todo byte[]
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }

        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
    }
}