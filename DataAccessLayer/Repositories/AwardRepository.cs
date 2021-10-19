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
    class AwardRepository : IAwardDal
    {
        Context c = new Context();
        public void AddAward(Award award)
        {
            c.Add(award);
            c.SaveChanges();
        }

        public void DeleteAward(Award award)
        {
            c.Remove(award);
            c.SaveChanges();
        }

        public Award GetByID(int id)
        {
            return c.Awards.Find(id);
        }

        public List<Award> ListAllAward()
        {
            return c.Awards.ToList();
        }

        public void UpdateAward(Award award)
        {
            c.Update(award);
            c.SaveChanges();
        }
    }
}
