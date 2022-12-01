﻿using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
   public class DestinationManager:IDestinationService
   {
       private readonly IDestinationDal _destinationDal;

       public DestinationManager(IDestinationDal destinationDal)
       {
           _destinationDal = destinationDal;
       }

        public void Tadd(Destination t)
        {
            _destinationDal.Insert(t);
        }

        public void Delete(Destination t)
        {
            _destinationDal.Delete(t);
        }

        public Destination TGetById(int id)
        {
            return _destinationDal.GetById(id);
        }

        public List<Destination> TGetList()
        {
           return _destinationDal.GetList();
        }

        public void Update(Destination t)
        {
            _destinationDal.Update(t);
        }
    }
}
