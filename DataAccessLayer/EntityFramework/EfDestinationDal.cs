﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccessLayer.EntityFramework
{
    public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
    {
        public Destination GetDestinationWithGuide(int id)
        {
            using (var c = new Context())
            {
                return c.Destinations.Where(x => x.DestinationID == id).Include(x => x.Guide).FirstOrDefault();
            }
        }
    }
}
