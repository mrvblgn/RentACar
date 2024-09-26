using RentACar.Models;

namespace RentACar.Repository;

public class TransmissionRepository : BaseRepository
{
    private List<Transmission> transmissions = new List<Transmission>();

    public TransmissionRepository()
    {
        transmissions = Transmissions();
    }
    
    public Transmission? getTransmissionById(int id)
    {
        Transmission? transmission = null;

        foreach (Transmission t in transmissions)
        {
            if (t.Id == id)
            {
                transmission = t;
            }
        }

        if (transmission is null)
        {
            return null;
        }
        
        return transmission;
    }

    public List<Transmission> getAll()
    {
        return transmissions;
    }

    public Transmission Add(Transmission created)
    {
        transmissions.Add(created);
        return created;
    }
    
    public Transmission? Update(Transmission updated)
    {
        Transmission? transmission = getTransmissionById(updated.Id);
        
        if (transmission == null)
        {
            return null;
        }
        
        int index = transmissions.FindIndex(c => c.Id == updated.Id);

        if (index != -1) 
        {
            transmissions[index] = updated; 
            return updated; 
        }

        return null;
    }
    
    public Transmission? Remove(int id)
    {
        Transmission? deletedTransmission = getTransmissionById(id);

        if (deletedTransmission is null)
        {
            return null;
        }
        transmissions.Remove(deletedTransmission);
        return deletedTransmission;
    }
    
}
















