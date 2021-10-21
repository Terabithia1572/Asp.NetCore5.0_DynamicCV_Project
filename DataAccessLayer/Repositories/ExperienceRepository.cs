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

        public void Delete(Experience t)
        {
            throw new NotImplementedException();
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

        public List<Experience> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Experience t)
        {
            throw new NotImplementedException();
        }

        public List<Experience> ListAllExperience()
        {
            return c.Experiences.ToList();
        }

        public void Update(Experience t)
        {
            throw new NotImplementedException();
        }

        public void UpdateExperience(Experience experience)
        {
            c.Update(experience);
            c.SaveChanges();
        }
    }
}
