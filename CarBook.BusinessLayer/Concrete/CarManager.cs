using CarBook.BusinessLayer.Abstract;
using CarBook.DataAccessLayer.Abstract;
using CarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.BusinessLayer.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void TDelete(Car entity)
        {
            _carDal.Delete(entity);
        }

        public Car TGetByID(int id)
        {
            if (id != null)
            {
                return _carDal.GetByID(id);
            }
            return _carDal.GetByID(0);
        }

        public List<Car> TGetListAll()
        {

            return _carDal.GetListAll();
        }

        public void TInsert(Car entity)
        {
            if (entity.Year >= 2010 && entity.Prices.Count > 0 && entity.Km <= 50000)
            {
                _carDal.Insert(entity);
            }
        }

        public void TUpdate(Car entity)
        {
            _carDal.Update(entity);
        }
    }
}
