using CmsHosp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsHosp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=cms_hospital;Trusted_Connection=true;TrustServerCertificate=True");
        }

        public DbSet<AccountTableEntity> AccountTables { get; set; }
        public DbSet<AppointmentTableEntity> AppointmentTables { get; set; }
        public DbSet<BlogCommentEntity> BlogComments { get; set; }
        public DbSet<BlogPostEntity> BlogPosts { get; set; }
        public DbSet<CustomerReviewEntity> CustomerReviews { get; set; }
        public DbSet<DoctorPolyclinicRelationEntity> DoctorPolyclinicRelations { get; set; }
        public DbSet<PolyclinicEntity> Polyclinics { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<VisitTableEntity> VisitTables { get; set; }
    }
}
