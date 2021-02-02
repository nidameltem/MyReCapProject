using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {

        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
            

                new Car{CarId=1,CarBrandId=1,CarColorId=1,CarModelYear=2012,CarDailyPrice=100,CarDescription="Audi"},
                new Car{CarId=2,CarBrandId=2,CarColorId=2,CarModelYear=2013,CarDailyPrice=100,CarDescription="BMW"},
                new Car{CarId=3,CarBrandId=2,CarColorId=3,CarModelYear=2013,CarDailyPrice=110,CarDescription="Fiat"},
                new Car{CarId=4,CarBrandId=3,CarColorId=3,CarModelYear=2018,CarDailyPrice=115,CarDescription="Ford"},
                new Car{CarId=5,CarBrandId=2,CarColorId=4,CarModelYear=2020,CarDailyPrice=115,CarDescription="Mercedes"},


            };
        }


        public void Add (Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarBrandId = car.CarBrandId;
            carToUpdate.CarColorId = car.CarColorId;
            carToUpdate.CarModelYear = car.CarModelYear;
            carToUpdate.CarDailyPrice = car.CarDailyPrice;
            carToUpdate.CarDescription = car.CarDescription;


        }



    }
}
