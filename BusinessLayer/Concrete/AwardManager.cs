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
    public class AwardManager : IAwardService
    {
        IAwardDal _awardDal;

        public AwardManager(IAwardDal awardDal)
        {
            _awardDal = awardDal;
        }

        public void Add(Award t)
        {
            _awardDal.Insert(t);
        }

        public void Delete(Award t)
        {
            _awardDal.Delete(t);
        }

        public Award GetById(int id)
        {
           return _awardDal.GetByID(id);
        }

        public List<Award> GetList()
        {
            return _awardDal.GetListAll();
        }

        public void Update(Award t)
        {
            _awardDal.Update(t);
        }
    }
}
