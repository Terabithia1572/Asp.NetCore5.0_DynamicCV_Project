using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IAbilityDal
    {

        List<Ability> ListAllAbility();
        void AddAbility(Ability ability);
        void DeleteAbility(Ability ability);
        void UpdateAbility(Ability ability);
        Ability GetByID(int id);
    }
}
