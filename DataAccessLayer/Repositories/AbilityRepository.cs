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
    public class AbilityRepository : IAbilityDal
    {
        Context c = new Context();
        public void AddAbility(Ability ability)
        {
            c.Add(ability);
            c.SaveChanges();
        }

        public void DeleteAbility(Ability ability)
        {
            c.Remove(ability);
            c.SaveChanges();
        }

        public Ability GetByID(int id)
        {
            return c.Abilities.Find(id);
        }

        public List<Ability> ListAllAbility()
        {
            return c.Abilities.ToList();
        }

        public void UpdateAbility(Ability ability)
        {
            c.Update(ability);
            c.SaveChanges();
        }
    }
}
