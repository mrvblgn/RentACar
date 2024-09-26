using RentACar.Repository;
using RentACar.Models;
using RentACar.Models.Dtos;

namespace RentACar.Service;

public class CarService
{
    private CarRepository carRepository = new CarRepository();

    public void GetById(int id)
    {
        Car? car = carRepository.GetById(id);

        if (car == null)
        {
            Console.WriteLine("Aradığınız araç bulunamadı.");
            return;
        }

        Console.WriteLine(car);
    }

    public void GetAll()
    {
        List<Car> cars = carRepository.GetAll();

        foreach (Car car in cars)
        {
            Console.WriteLine(car);
        }
    }

    public void Add(Car car)
    {
        CarIdBusinessRules(car.Id);
        
        Car created = carRepository.Add(car);
        Console.WriteLine("Yeni araç eklendi");
        Console.WriteLine(created);
    }
    
    private void CarIdBusinessRules(int id)
    {
        Car? getByIdBook =  carRepository.GetById(id);
        if (getByIdBook != null)
        {
            Console.WriteLine($"Girmiş olduğunuz aracın id alanı benzersiz olmalı: {id}");
            return;
        }
    }

    public void Update(Car car)
    {
        Car? updated = carRepository.Update(car);

        if (updated == null)
        {
            Console.WriteLine("Araç bulunamadı");
        }

        Console.WriteLine(updated);
    }

    public void Remove(int id)
    {
        Car? deletedCar = carRepository.Remove(id);

        if (deletedCar == null)
        {
            Console.WriteLine("Araç bulunamadı");
        }

        Console.WriteLine(deletedCar);
    }

    public void GetAllDetails()
    {
        List<CarDetailDto> cars = carRepository.GetAllDetails();

        foreach (CarDetailDto car in cars)
        {
            Console.WriteLine(car);
        }
    }

    public void GetAllDetailsByFuelId(int fuelId)
    {
        List<CarDetailDto> details = carRepository.GetAllDetailsByFuelId(fuelId);
        
        details.ForEach(car => Console.WriteLine(car));
    }

    public void GetAllDetailsByColorId(int colorId)
    {
        List<CarDetailDto> details = carRepository.GetAllDetailsByColorId(colorId);
        
        details.ForEach(car => Console.WriteLine(car));
    }

    public void GetAllDetailsByPriceRange(double min, double max)
    {
        List<CarDetailDto> details = carRepository.GetAllDetailsByPriceRange(min, max);
        
        details.ForEach(car => Console.WriteLine(car));
    }

    public void GetAllDetailsByBrandNameContains(string brandName)
    {
        List<CarDetailDto> cars = carRepository.GetAllDetailsByBrandNameContains(brandName);

        if (cars == null)
        {
            Console.WriteLine("Aradığınız araç bulunamadı");
            return;
        }
        
        cars.ForEach(car => Console.WriteLine(car));
    }

    public void GetAllDetailsByModelNameContains(string modelName)
    {
        List<CarDetailDto> cars = carRepository.GetAllDetailsByModelNameContains(modelName);

        if (cars == null)
        {
            Console.WriteLine("Aradığınız araç bulunamadı");
            return;
        }
        
        cars.ForEach(car => Console.WriteLine(car));
    }

    public void GetDetailById(int id)
    {
        CarDetailDto carDetail = carRepository.GetDetailById(id);

        Console.WriteLine(carDetail);
    }

    public void GetAllDetailsByKilometerRange(int min, int max)
    {
        List<CarDetailDto> cars = carRepository.GetAllDetailsByKilometerRange(min, max);

        if (cars == null)
        {
            Console.WriteLine("Araç bulunamadı");
        }
        
        cars.ForEach(car => Console.WriteLine(car));
    }
}

























