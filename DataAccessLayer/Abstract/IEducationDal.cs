using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IEducationDal
    {
        List<Education> ListAllEducation();
        void AddEducation(Education education);
        void DeleteEducation(Education education);
        void UpdateEducation(Education education);
        Education GetByID(int id);
    }
}
