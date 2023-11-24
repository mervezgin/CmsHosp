using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsHosp.Data.Entities
{
    public class AccountTableEntity : EntityBase
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime CreationDate { get; set; }

        public string Notes { get; set; }
    }
}
