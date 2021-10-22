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
    public class MyHobbyManager : IMyHobbyService
    {
        IMyHobbiesDal _myHobbiesDal;

        public MyHobbyManager(IMyHobbiesDal myHobbiesDal)
        {
            _myHobbiesDal = myHobbiesDal;
        }

        public void Add(MyHobby t)
        {
            _myHobbiesDal.Insert(t);
        }

        public void Delete(MyHobby t)
        {
            _myHobbiesDal.Delete(t);
        }

        public MyHobby GetById(int id)
        {
            return _myHobbiesDal.GetByID(id);
        }

        public List<MyHobby> GetList()
        {
            return _myHobbiesDal.GetListAll();
        }

        public void Update(MyHobby t)
        {
            _myHobbiesDal.Update(t);
        }
    }
}
