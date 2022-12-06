using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentSchedulerUILibrary.AppointmentDTOs
{
    public class AppointmentDTO
    {
        public long AccountId { get; set; }
        public DateTime Date { get; set; }
        public int TimeSlot { get; set; }
        public bool IsApproved { get; set; }
        public long AppointmentTypeId { get; set; }
        public IEnumerable<long> EmployeeIdList { get; set; }
    }
}
