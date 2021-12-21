using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Acc
    {
        public int Id { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password Required")]
        public string Password { get; set; }
        [Display(Name = "Role")]
        [Required(ErrorMessage = "Role Required")]
        public string Roles { get; set; }
        public string Status { get; set; }
    }
}
