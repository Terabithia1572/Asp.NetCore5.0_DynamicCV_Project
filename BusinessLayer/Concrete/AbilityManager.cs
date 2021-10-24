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
    public class AbilityManager : IAbilityService
    {
        IAbilityDal _abilityDal;

        public AbilityManager(IAbilityDal abilityDal)
        {
            _abilityDal = abilityDal;
        }

        public void Add(Ability t)
        {
            _abilityDal.Insert(t);
        }

        public void Delete(Ability t)
        {
            _abilityDal.Delete(t);
        }

        public Ability GetById(int id)
        {
            return _abilityDal.GetByID(id);
        }

        public List<Ability> GetList()
        {
            return _abilityDal.GetListAll();
        }

        public void Update(Ability t)
        {
            _abilityDal.Update(t);
        }
    }
}
