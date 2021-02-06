using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            { 
                _carDal.Add(car);
                Console.WriteLine("Id'si " + car.CarId + " olan araç sisteme eklendi");
            }
            
            else
            {
                Console.WriteLine("Hatalı giriş : Aracın günlük ücreti ve/veya araç adı hatalı");
            }

        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Id'si " + car.CarId + " olan araç sistemden silindi");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Id'si " + car.CarId + " olan araç güncellendi");
        }

        public List<Car> GetByColorId(int id)
        {
            return _carDal.GetAll(c=>c.ColorId==id);
        }

        public List<Car> GetByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id); 
        }

        public List<Car> GetByTransmissionId(int id)
        {
            return _carDal.GetAll(c => c.TransmissionId == id);
        }
    }
}
