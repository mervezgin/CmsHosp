using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsHosp.Data.Entities
{
    public class AppointmentTableEntity : EntityBase
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public int PolyclinicId { get; set; }
        public DateTime VisitDate { get; set; }
        public DateTime VisitTime { get; set; }
    }
}
