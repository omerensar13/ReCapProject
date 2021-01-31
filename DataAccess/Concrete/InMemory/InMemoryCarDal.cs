using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{

    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{CarId=1, BrandId=1, ColorId=1, TransmissionId= 1, DailyPrice=150, Description="Skoda Kodiaq 2.0 TSI SUV 4x4", ModelYear="2019" },
            new Car{CarId=2, BrandId=2, ColorId=1, TransmissionId= 2, DailyPrice=100, Description="Ford Tourneo Courier 1.0 EcoBoost Minivan", ModelYear="2015" },
            new Car {CarId = 3, BrandId = 3, ColorId = 3, TransmissionId = 2, DailyPrice = 200, Description = "Volkswagen Passat Variant 2.0 TDI Hatchback ", ModelYear = "2020" },
            new Car {CarId = 4, BrandId = 3, ColorId = 3, TransmissionId = 1, DailyPrice = 300, Description = "Volkswagen Passat 2.0 TDI Sedan", ModelYear = "2017" },
            new Car {CarId = 5, BrandId = 2, ColorId = 2, TransmissionId = 2, DailyPrice = 180, Description = "Ford Focus 1.6 TDCI Sedan ", ModelYear = "2018" }};
        }
        public void Add(Car car)
        {

            _cars.Add(car);

        }
        public void Delete(Car car)
        {
            Car carToDelete = _cars.First(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
           return _cars.Where(c=> c.CarId == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.First(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.TransmissionId = car.TransmissionId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            
        }
    }
}
