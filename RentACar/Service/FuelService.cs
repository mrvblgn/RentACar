using RentACar.Models;
using RentACar.Repository;

namespace RentACar.Service;

public class FuelService
{
    private FuelRepository fuelRepository = new FuelRepository();

    public void GetFuelById(int id)
    {
        Fuel? fuel = fuelRepository.GetFuelById(id);

        if (fuel == null)
        {
            Console.WriteLine("Girilen yakıt çeşidi mevcut değil");
        }

        Console.WriteLine(fuel);
    }

    public void GetAll()
    {
        List<Fuel> fuels = fuelRepository.GetAll();
        
        fuels.ForEach(f => Console.WriteLine(f));
    }

    public void Add(Fuel fuel)
    {
        Fuel? newFuel  = fuelRepository.Add(fuel);

        Console.WriteLine("Yeni yakıt türü eklendi");
        Console.WriteLine(newFuel);
    }

    public void Update(Fuel fuel)
    {
        Fuel? updatedFuel = fuelRepository.Update(fuel);

        if (updatedFuel == null)
        {
            Console.WriteLine("Yakıt türü bulunamadı");
        }

        Console.WriteLine(updatedFuel);
    }

    public void Remove(int id)
    {
        Fuel? deletedFuel = fuelRepository.Remove(id);

        if (deletedFuel == null)
        {
            Console.WriteLine("Yakıt türü bulunamadı");
        }

        Console.WriteLine(deletedFuel);
    }
}

























