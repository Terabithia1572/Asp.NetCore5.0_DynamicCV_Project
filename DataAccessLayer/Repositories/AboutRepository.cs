﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    class AboutRepository : IAboutDal
    {
        Context c = new Context();
        public void AddAbout(About about)
        {
            c.Add(about);
            c.SaveChanges();
        }

        public void DeleteAbout(About about)
        {
            c.Remove(about);
            c.SaveChanges();
        }

        public About GetByID(int id)
        {
           return c.Abouts.Find(id);
        }

        public List<About> ListAllAbout()
        {
            return c.Abouts.ToList();
        }

        public void UpdateAbout(About about)
        {
            c.Update(about);
            c.SaveChanges();
        }
    }
}