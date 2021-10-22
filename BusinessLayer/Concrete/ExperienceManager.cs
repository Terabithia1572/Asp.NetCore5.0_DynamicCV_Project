using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void Add(Experience t)
        {
            _experienceDal.Insert(t);
        }

        public void Delete(Experience t)
        {
            _experienceDal.Delete(t);
        }

        public Experience GetById(int id)
        {
            return _experienceDal.GetByID(id);
        }

        public List<Experience> GetList()
        {
            return _experienceDal.GetListAll();
        }

        public void Update(Experience t)
        {
            _experienceDal.Update(t);
        }
    }
}
