using RentACar.Models;

namespace RentACar.Repository;

public class ColorRepository : BaseRepository
{
    private List<Color> colors = new List<Color>();

    public ColorRepository()
    {
        colors = Colors();
    }

    public Color? GetColorById(int id)
    {
        Color? color = null;

        foreach (Color c in colors)
        {
            if (c.Id == id)
            {
                color = c;
            }
        }

        if (color is null)
        {
            return null;
        }

        return color;
    }

    public List<Color> GetAll()
    {
        return colors;
    }

    public Color Add(Color created)
    {
        colors.Add(created);
        return created;
    }
    
    public Color? Update(Color updated)
    {
        Color? color = GetColorById(updated.Id);
        
        if (color == null)
        {
            return null;
        }
        
        int index = colors.FindIndex(c => c.Id == updated.Id);

        if (index != -1) 
        {
            colors[index] = updated; 
            return updated; 
        }

        return null;
    }
    
    public Color? Remove(int id)
    {
        Color? deletedColor = GetColorById(id);

        if (deletedColor is null)
        {
            return null;
        }
        colors.Remove(deletedColor);
        return deletedColor;
    }
}












