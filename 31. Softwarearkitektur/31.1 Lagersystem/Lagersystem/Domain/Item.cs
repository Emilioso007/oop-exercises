using System.ComponentModel.DataAnnotations;

namespace Domain;

public abstract class Item : IExpireable, IComparable<Item>
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Item(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public abstract bool IsExpired();

    public int CompareTo(Item? it)
    {

        if (it == null)
        {
            return -1;
        }

        double tmp = Price - it.Price;

        if (tmp < 0)
        {
            return -1;
        }
        else if (tmp > 0)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public abstract string GetItemType();
    public abstract string[] GetState();

    public string Marshal()
    {
        string type = GetItemType();
        string[] parameters = GetState();
        return type + " " + string.Join(" ", parameters);
    }

    public static Item? Unmarshal(string input)
    {
        string[] args = input.Split(" ");
        string type = args[0];

        switch (type)
        {
            case "FoodItem":
                return FoodItem.Unmarshal(args);
                break;
            case "NonFoodItem":
                return NonFoodItem.Unmarshal(args);
                break;
            default:
                return null;
        }
    }
}