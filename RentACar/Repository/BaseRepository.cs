using RentACar.Models;

namespace RentACar.Repository;

public class BaseRepository
{
    List<Car> cars = new List<Car>()
    {
        new Car(1,1,1,1, "İkinci el", 50000, 2020, "16 AGG 123", "Volvo", "S 40", 700000),
        new Car(2, 3, 3, 1, "İkinci el", 100000, 2010, "34 DA 7878", "Hyundai", "i20", 600000),
        new Car(3, 1, 1, 1, "Sıfır", 0, 2024, "61 TS 1967", "Audi", "A8", 2000000),
        new Car(4, 2, 2, 2, "İkinci el", 50000, 2016, "16 CRZ 455", "Honda", "Civic", 900000),
        new Car(5, 5, 3, 2, "İkinci el", 120000, 2018, "06 AB 1234", "BMW", "320i", 750000),
        new Car(6, 2, 2, 3, "İkinci el", 80000, 2015, "34 FG 5678", "Mercedes", "C200", 850000),
        new Car(7, 1, 1, 1, "Sıfır", 0, 2023, "35 BC 1234", "Toyota", "Corolla", 500000),
        new Car(8, 3, 3, 2, "İkinci el", 140000, 2012, "16 DF 7890", "Volkswagen", "Golf", 600000),
        new Car(9, 2, 2, 2, "Sıfır", 0, 2024, "07 GH 4321", "Tesla", "Model 3", 1500000),
        new Car(10, 6, 1, 1, "İkinci el", 90000, 2019, "26 EF 5678", "Ford", "Focus", 550000)
        
    };

    List<Color> colors = new List<Color>()
    {
        new Color(1, "Titanyum gri"),
        new Color(2, "Kırmızı"),
        new Color(3, "Bej"),
        new Color(4, "Siyah"),
        new Color(5, "Beyaz"),
        new Color(6, "Mavi")
    };

    List<Fuel> fuels = new List<Fuel>()
    {
        new Fuel(1,"Hybrid"),
        new Fuel(2, "Benzin"),
        new Fuel(3, "Dizel")
    };

    List<Transmission> transmissions = new List<Transmission>()
    {
        new Transmission(1, "Otomatik"),
        new Transmission(2, "Manuel")
    };

    public List<Car> Cars()
    {
        return cars;
    }

    public List<Color> Colors()
    {
        return colors;
    }

    public List<Fuel> Fuels()
    {
        return fuels;
    }

    public List<Transmission> Transmissions()
    {
        return transmissions;
    }
}













