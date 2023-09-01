
namespace PetShop;
public class Animal
{

    public string Nickname { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public int Energy { get; set; }
    public double Price { get; set; }
    public int MealQuantity { get; set; }


    public Animal(string nickname, int age, string gender, int energy, double price, int mealQuantity)
    {

        Nickname = nickname;
        Age = age;
        Gender = gender;
        Energy = energy;
        Price = price;
        MealQuantity = mealQuantity;
    }

    public Animal()
    {
    }

    public void Eat()
    {
        Energy += 15;
        MealQuantity++;
        Console.WriteLine($"{Nickname} pisiy yemek yedi ve energici artdi");


    }


    public void Sleep()
    {
        Energy = 0;
        Console.WriteLine($"{Nickname} pisik Energy-si 0-a endi.");
    }

    public void Play()
    {

        if (Energy >= 5)
        {
            Energy -= 10;
            Console.WriteLine($"{Nickname} Pisik oyun oynadi enerjisi bitdi.");
        }
        else
        {
            Console.WriteLine($"{Nickname} Enerjisi bitmek uzre oynuya bilmez");
        }

    }
    public void PriceIncrease(double amout)
    {
        Price += amout;
        Console.WriteLine($"{Nickname} qiymeti artirildi -{amout}");
    }

}
