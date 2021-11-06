using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IEducationService
    {
        void Add(Education education);
        void Delete(Education education);
        void Update(Education education);
        List<Education> GetList();
        Education GetById(int id);
    }
}
