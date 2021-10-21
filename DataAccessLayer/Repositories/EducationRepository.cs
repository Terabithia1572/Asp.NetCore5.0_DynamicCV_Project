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
    public class EducationRepository : IEducationDal
    {
        Context c = new Context();
        public void AddEducation(Education education)
        {
            c.Add(education);
            c.SaveChanges();
        }

        public void Delete(Education t)
        {
            throw new NotImplementedException();
        }

        public void DeleteEducation(Education education)
        {
            c.Remove(education);
            c.SaveChanges();
        }

        public Education GetByID(int id)
        {
            return c.Educations.Find(id);
        }

        public List<Education> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Education t)
        {
            throw new NotImplementedException();
        }

        public List<Education> ListAllEducation()
        {
            return c.Educations.ToList();
        }

        public void Update(Education t)
        {
            throw new NotImplementedException();
        }

        public void UpdateEducation(Education education)
        {
            c.Update(education);
            c.SaveChanges();
        }
    }
}
