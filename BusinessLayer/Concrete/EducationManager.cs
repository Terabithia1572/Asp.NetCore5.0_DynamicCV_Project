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
    public class EducationManager : IEducationService
    {
        IEducationDal _educationDal;

        public EducationManager(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }

        public void Add(Education education)
        {
            _educationDal.Insert(education);
        }

        public void Delete(Education education)
        {
            _educationDal.Delete(education);
        }

        public Education GetById(int id)
        {
            return _educationDal.GetByID(id);
        }

        public List<Education> GetList()
        {
            return _educationDal.GetListAll();
        }

        public void Update(Education education)
        {
            _educationDal.Update(education);
        }
    }
}
