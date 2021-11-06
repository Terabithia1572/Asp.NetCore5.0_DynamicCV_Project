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

        public void Add(Experience experience)
        {
            _experienceDal.Insert(experience);
        }

        public void Delete(Experience experience)
        {
            _experienceDal.Delete(experience);
        }

        public Experience GetById(int id)
        {
            return _experienceDal.GetByID(id);
        }

        public List<Experience> GetList()
        {
            return _experienceDal.GetListAll();
        }

        public void Update(Experience experience)
        {
            _experienceDal.Update(experience);
        }
    }
}
