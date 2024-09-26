using RentACar.Models;

namespace RentACar.Repository;

public class FuelRepository : BaseRepository
{
    private List<Fuel> fuels = new List<Fuel>();

    public FuelRepository()
    {
        fuels = Fuels();
    }

    public Fuel? GetFuelById(int id)
    {
        Fuel? fuel = null;

        foreach (Fuel f in fuels)
        {
            if (f.Id == id)
            {
                fuel = f;
            }
        }

        if (fuel is null)
        {
            return null;
        }

        return fuel;
    }

    public List<Fuel> GetAll()
    {
        return fuels;
    }

    public Fuel Add(Fuel created)
    {
        fuels.Add(created);
        return created;
    }
    
    public Fuel? Update(Fuel updated)
    {
        Fuel? fuel = GetFuelById(updated.Id);
        
        if (fuel == null)
        {
            return null;
        }
        
        int index = fuels.FindIndex(c => c.Id == updated.Id);

        if (index != -1) 
        {
            fuels[index] = updated; 
            return updated; 
        }

        return null;
    }
    
    public Fuel? Remove(int id)
    {
        Fuel? deletedFuel = GetFuelById(id);

        if (deletedFuel is null)
        {
            return null;
        }
        fuels.Remove(deletedFuel);
        return deletedFuel;
    }
}







