using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsHosp.Data.Entities
{
    public class DoctorPolyclinicRelationEntity : EntityBase
    {
        public int RoleId { get; set; }
        public int PolyclinicId { get; set; }
    }
}
