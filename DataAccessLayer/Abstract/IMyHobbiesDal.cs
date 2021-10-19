using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IMyHobbiesDal
    {
        List<MyHobby> ListAllMyHobby();
        void AddMyHobby(MyHobby myHobby);
        void DeleteMyHobby(MyHobby myHobby);
        void UpdateMyHobby(MyHobby myHobby);
        MyHobby GetByID(int id);
    }
}
