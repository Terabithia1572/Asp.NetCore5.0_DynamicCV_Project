using BusinessLayer.Abstract;
using DataAccessLayer.Repositories;
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
        AbilityRepository abilityRepository = new AbilityRepository();
        public void AbilityAdd(Ability ability)
        {
            abilityRepository.AddAbility(ability);
            
        }

        public void AbilityDelete(Ability ability)
        {
            throw new NotImplementedException();
        }

        public void AbilityUpdate(Ability ability)
        {
            throw new NotImplementedException();
        }

        public Ability GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Ability> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
