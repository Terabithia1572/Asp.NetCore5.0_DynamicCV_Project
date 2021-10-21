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

        public void Delete(MyHobby t)
        {
            throw new NotImplementedException();
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

        public List<MyHobby> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(MyHobby t)
        {
            throw new NotImplementedException();
        }

        public List<MyHobby> ListAllMyHobby()
        {
            return c.MyHobbies.ToList();
        }

        public void Update(MyHobby t)
        {
            throw new NotImplementedException();
        }

        public void UpdateMyHobby(MyHobby myHobby)
        {
            c.Update(myHobby);
            c.SaveChanges();
        }
    }
}
