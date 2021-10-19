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
    public class MyHobbyRepository : IMyHobbiesDal
    {
        Context c = new Context();
        public void AddMyHobby(MyHobby myHobby)
        {
            c.Add(myHobby);
            c.SaveChanges();
        }

        public void DeleteMyHobby(MyHobby myHobby)
        {
            c.Remove(myHobby);
            c.SaveChanges();
        }

        public MyHobby GetByID(int id)
        {
            return c.MyHobbies.Find(id);
        }

        public List<MyHobby> ListAllMyHobby()
        {
            return c.MyHobbies.ToList();
        }

        public void UpdateMyHobby(MyHobby myHobby)
        {
            c.Update(myHobby);
            c.SaveChanges();
        }
    }
}
