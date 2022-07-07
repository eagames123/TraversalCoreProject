using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class FeatureManager:IFeatureService
    {
        private IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Tadd(Feature t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Feature t)
        {
            throw new NotImplementedException();
        }

        public void Update(Feature t)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetList()
        {
            return _featureDal.GetList();
        }

        public Feature TGetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
