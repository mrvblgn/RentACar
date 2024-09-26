using RentACar.Models;
using RentACar.Repository;

namespace RentACar.Service;

public class TransmissionService
{
    private TransmissionRepository transmissionRepository = new TransmissionRepository();

    public void GetTransmissionById(int id)
    {
        Transmission? transmission = transmissionRepository.getTransmissionById(id);

        if (transmission == null)
        {
            Console.WriteLine("Vites türü bulunamadı");
        }

        Console.WriteLine(transmission);
    }

    public void GetAll()
    {
        List<Transmission> transmissions = transmissionRepository.getAll();
        transmissions.ForEach(transmission => Console.WriteLine(transmission));
    }

    public void Update(Transmission transmission)
    {
        Transmission? updatedTransmission = transmissionRepository.Update(transmission);

        if (updatedTransmission == null)
        {
            Console.WriteLine("Vites türü bulunamadı");
        }

        Console.WriteLine(updatedTransmission);
    }

    public void Remove(int id)
    {
        Transmission? deletedTransmission = transmissionRepository.getTransmissionById(id);

        if (deletedTransmission == null)
        {
            Console.WriteLine("Vites türü bulunamadı");
        }

        Console.WriteLine("Vites türü silindi");
        Console.WriteLine(deletedTransmission);
    }
}























