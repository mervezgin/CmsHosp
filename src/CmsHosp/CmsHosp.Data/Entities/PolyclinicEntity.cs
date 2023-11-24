using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsHosp.Data.Entities
{
    public class PolyclinicEntity : EntityBase
    {
        public int RoleId { get; set; }
        public int DoctorPolyclinicRelationId { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }
    }
}
