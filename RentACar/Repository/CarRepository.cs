using RentACar.Models;
using RentACar.Models.Dtos;

namespace RentACar.Repository;

public class CarRepository: BaseRepository
{
    private List<Car> cars;
    private List<Color> colors;
    private List<Fuel> fuels;
    private List<Transmission> transmissions;

    public CarRepository()
    {
        cars = Cars();
        colors = Colors();
        fuels = Fuels();
        transmissions = Transmissions();
    }
    
    public Car? GetById(int id)
    {
        Car? car = null;

        foreach (Car c in cars)
        {
            if (c.Id == id)
            {
                car = c;
            }
        }

        if (car is null)
        {
            return null;
        }

        return car;
    }

    public List<Car> GetAll()
    {
        return cars;
    }

    public Car Add(Car created)
    {
        cars.Add(created);
        return created;
    }

    public Car? Update(Car updated)
    {
        Car? car = GetById(updated.Id);
        
        if (car == null)
        {
            return null;
        }
        
        int index = cars.FindIndex(c => c.Id == updated.Id);

        if (index != -1) 
        {
            cars[index] = updated; 
            return updated; 
        }

        return null;
    }
    
    public Car? Remove(int id)
    {
        Car? deletedCar = GetById(id);

        if (deletedCar is null)
        {
            return null;
        }
        cars.Remove(deletedCar);
        return deletedCar;
    }

    public List<CarDetailDto> GetAllDetails()
    {
        var result =
            from car in cars
            join color in colors
                on car.ColorId equals color.Id
            join fuel in fuels
                on car.FuelId equals fuel.Id
            join transmission in transmissions
                on car.TransmissionId equals transmission.Id
            select new CarDetailDto(
                Id: car.Id,
                FuelName: fuel.Name,
                TransmissionName: transmission.Name,
                ColorName: color.Name,
                CarState: car.CarState,
                KiloMeter: car.KiloMeter,
                ModelYear: car.ModelYear,
                Plate: car.Plate,
                BrandName: car.BrandName,
                ModelName: car.ModelName,
                DailyPrice: car.DailyPrice
            );
        return result.ToList();
    }

    public List<CarDetailDto> GetAllDetailsByFuelId(int fuelId)
    {
        var result =
            from car in cars
            where car.FuelId == fuelId
            join color in colors on car.ColorId equals color.Id
            join fuel in fuels on car.FuelId equals fuel.Id
            join transmission in transmissions on car.TransmissionId equals transmission.Id
            select new CarDetailDto(
                Id: car.Id,
                FuelName: fuel.Name,
                TransmissionName: transmission.Name,
                ColorName: color.Name,
                CarState: car.CarState,
                KiloMeter: car.KiloMeter,
                ModelYear: car.ModelYear,
                Plate: car.Plate,
                BrandName: car.BrandName,
                ModelName: car.ModelName,
                DailyPrice: car.DailyPrice
            );
        return result.ToList();
    }

    public List<CarDetailDto> GetAllDetailsByColorId(int colorId)
    {
        var result =
            from car in cars
            where car.ColorId == colorId
            join color in colors on car.ColorId equals color.Id
            join fuel in fuels on car.FuelId equals fuel.Id
            join transmission in transmissions on car.TransmissionId equals transmission.Id
            select new CarDetailDto(
                Id: car.Id,
                FuelName: fuel.Name,
                TransmissionName: transmission.Name,
                ColorName: color.Name,
                CarState: car.CarState,
                KiloMeter: car.KiloMeter,
                ModelYear: car.ModelYear,
                Plate: car.Plate,
                BrandName: car.BrandName,
                ModelName: car.ModelName,
                DailyPrice: car.DailyPrice
            );
        return result.ToList();
    }

    public List<CarDetailDto> GetAllDetailsByPriceRange(double min, double max)
    {
        var result =
            from car in cars
            where car.DailyPrice >= min && car.DailyPrice <= max
            join color in colors on car.ColorId equals color.Id
            join fuel in fuels on car.FuelId equals fuel.Id
            join transmission in transmissions on car.TransmissionId equals transmission.Id
            select new CarDetailDto(
                Id: car.Id,
                FuelName: fuel.Name,
                TransmissionName: transmission.Name,
                ColorName: color.Name,
                CarState: car.CarState,
                KiloMeter: car.KiloMeter,
                ModelYear: car.ModelYear,
                Plate: car.Plate,
                BrandName: car.BrandName,
                ModelName: car.ModelName,
                DailyPrice: car.DailyPrice
            );
        return result.ToList();
    }

    public List<CarDetailDto> GetAllDetailsByBrandNameContains(string brandName)
    {
        var result =
            from car in cars
            where car.BrandName.Contains(brandName)
            join color in colors on car.ColorId equals color.Id
            join fuel in fuels on car.FuelId equals fuel.Id
            join transmission in transmissions on car.TransmissionId equals transmission.Id
            select new CarDetailDto(
                Id: car.Id,
                FuelName: fuel.Name,
                TransmissionName: transmission.Name,
                ColorName: color.Name,
                CarState: car.CarState,
                KiloMeter: car.KiloMeter,
                ModelYear: car.ModelYear,
                Plate: car.Plate,
                BrandName: car.BrandName,
                ModelName: car.ModelName,
                DailyPrice: car.DailyPrice
            );
        return result.ToList();
    }

    public List<CarDetailDto> GetAllDetailsByModelNameContains(string modelName)
    {
        var result =
            from car in cars
            where car.ModelName.Contains(modelName)
            join color in colors on car.ColorId equals color.Id
            join fuel in fuels on car.FuelId equals fuel.Id
            join transmission in transmissions on car.TransmissionId equals transmission.Id
            select new CarDetailDto(
                Id: car.Id,
                FuelName: fuel.Name,
                TransmissionName: transmission.Name,
                ColorName: color.Name,
                CarState: car.CarState,
                KiloMeter: car.KiloMeter,
                ModelYear: car.ModelYear,
                Plate: car.Plate,
                BrandName: car.BrandName,
                ModelName: car.ModelName,
                DailyPrice: car.DailyPrice
            );
        return result.ToList();
    }

    public CarDetailDto? GetDetailById(int id)
    {
        var result =
            from car in cars
            join color in colors
                on car.ColorId equals color.Id
            join fuel in fuels
                on car.FuelId equals fuel.Id
            join transmission in transmissions
                on car.TransmissionId equals transmission.Id
            where car.Id == id
            select new CarDetailDto(
                Id: car.Id,
                FuelName: fuel.Name,
                TransmissionName: transmission.Name,
                ColorName: color.Name,
                CarState: car.CarState,
                KiloMeter: car.KiloMeter,
                ModelYear: car.ModelYear,
                Plate: car.Plate,
                BrandName: car.BrandName,
                ModelName: car.ModelName,
                DailyPrice: car.DailyPrice
            );
        return result.FirstOrDefault();
    }

    public List<CarDetailDto> GetAllDetailsByKilometerRange(int min, int max)
    {
        var result =
            from car in cars
            where car.KiloMeter >= min && car.KiloMeter <= max
            join color in colors on car.ColorId equals color.Id
            join fuel in fuels on car.FuelId equals fuel.Id
            join transmission in transmissions on car.TransmissionId equals transmission.Id
            select new CarDetailDto(
                Id: car.Id,
                FuelName: fuel.Name,
                TransmissionName: transmission.Name,
                ColorName: color.Name,
                CarState: car.CarState,
                KiloMeter: car.KiloMeter,
                ModelYear: car.ModelYear,
                Plate: car.Plate,
                BrandName: car.BrandName,
                ModelName: car.ModelName,
                DailyPrice: car.DailyPrice
            );
        return result.ToList();
    }
}





























