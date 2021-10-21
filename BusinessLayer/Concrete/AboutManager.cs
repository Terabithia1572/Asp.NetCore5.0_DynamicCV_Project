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
    public class AboutManager : IAboutService
    {
        AboutRepository aboutRepository = new AboutRepository();
        public void AddAbout(About about)
        {
            aboutRepository.AddAbout(about);
        }

        public void DeleteAbout(About about)
        {
            throw new NotImplementedException();
        }

        public About GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
        {
            throw new NotImplementedException();
        }

        public void UpdateAbout(About about)
        {
            throw new NotImplementedException();
        }
    }
}
