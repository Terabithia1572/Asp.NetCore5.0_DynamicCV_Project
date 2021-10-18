using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-5QBR47D;database=db_DynamicCV; integrated security=true;");
        }
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<MyHobby> MyHobbies { get; set; }
    }
}
