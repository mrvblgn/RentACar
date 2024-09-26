using RentACar.Repository;
using RentACar.Models;

namespace RentACar.Service;

public class ColorService
{
    private ColorRepository colorRepository = new ColorRepository();

    public void GetColorById(int id)
    {
        Color? color = colorRepository.GetColorById(id);

        if (color == null)
        {
            Console.WriteLine("Aradığınız renk bulunamadı");
        }

        Console.WriteLine(color);
    }

    public void GetAll()
    {
        List<Color> colors = colorRepository.GetAll();
        
        colors.ForEach(c => Console.WriteLine(c));
    }

    public void Add(Color color)
    {
        Color? c = colorRepository.Add(color);

        Console.WriteLine("Yeni renk eklendi");
        Console.WriteLine(c);
    }

    public void Update(Color color)
    {
        Color? c = colorRepository.Update(color);

        if (c == null)
        {
            Console.WriteLine("Renk bulunamadı");
        }

        Console.WriteLine(c);
    }

    public void Remove(int id)
    {
        Color? deletedColor = colorRepository.Remove(id);

        if (deletedColor == null)
        {
            Console.WriteLine("Renk bulunamadı");
        }
        
        Console.WriteLine("Renk silindi");
        Console.WriteLine(deletedColor);
    }
}




















