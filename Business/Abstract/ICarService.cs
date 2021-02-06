﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetByColorId(int id);
        List<Car> GetByBrandId(int id);
        List<Car> GetByTransmissionId(int id);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
    
    }
}
