using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentSchedulerUILibrary.Credentials
{
    public class AccountDetails
    {
        [Required]
        public string JwtToken { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
