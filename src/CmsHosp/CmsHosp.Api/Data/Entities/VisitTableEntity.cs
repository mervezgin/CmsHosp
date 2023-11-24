using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsHosp.Data.Entities
{
    public class VisitTableEntity : EntityBase
    {
        public int AppointmentId { get; set; }
        public int RoleId { get; set; }
        public int UserId { get; set; }
        public string Reasons { get; set; } = string.Empty;
        public string Diagnosis { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
    }
}
