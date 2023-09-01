namespace PetShop;

public class PetSHop
{

    public Animal[] Cats { get; set; }
    public Animal[] Dogs { get; set; }
    public Animal[] Birds { get; set; }
    public Animal[] Fishes { get; set; }

    public PetSHop()
    {

        Cats = new Animal[0];
        Dogs = new Animal[0];
        Birds = new Animal[0];
        Fishes = new Animal[0];
    }

    public void RemoveByNickname(string nickname)
    {
        Cats = RemoveAnimalByNickname(Cats, nickname);
        Dogs = RemoveAnimalByNickname(Dogs, nickname);
        Birds = RemoveAnimalByNickname(Birds, nickname);
        Fishes = RemoveAnimalByNickname(Fishes, nickname);
        Console.WriteLine($"{nickname} adli heyvan silindi.");
    }

    


    private Animal[] RemoveAnimalByNickname(Animal[] animals, string nickname)
    {
        int index = -1;
        for (int i = 0; i < animals.Length; i++)
        {
            if (animals[i].Nickname == nickname)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            Animal[] newAnimals = new Animal[animals.Length - 1];
            for (int i = 0, j = 0; i < animals.Length; i++)
            {
                if (i != index)
                {
                    newAnimals[j] = animals[i];
                    j++;
                }
            }
            return newAnimals;
        }
        return animals;
    }

   
}

  



