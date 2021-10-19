using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ExperienceRepository : IExperienceDal
    {
        Context c = new Context();
        public void AddExperience(Experience experience)
        {
            c.Add(experience);
            c.SaveChanges();
        }

        public void DeleteExperience(Experience experience)
        {
            c.Remove(experience);
            c.SaveChanges();
        }

        public Experience GetByID(int id)
        {
          return c.Experiences.Find(id);

        }

        public List<Experience> ListAllExperience()
        {
            return c.Experiences.ToList();
        }

        public void UpdateExperience(Experience experience)
        {
            c.Update(experience);
            c.SaveChanges();
        }
    }
}
