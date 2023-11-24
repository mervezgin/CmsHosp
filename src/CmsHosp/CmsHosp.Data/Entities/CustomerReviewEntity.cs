using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsHosp.Data.Entities
{
    public class CustomerReviewEntity : EntityBase
    {
        public int UserId { get; set; }
        public int DoctorId { get; set; }

        [Required, MaxLength(300)]
        public string Message { get; set; }

        [Required, Range(1, 5)]
        public byte StarCount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
