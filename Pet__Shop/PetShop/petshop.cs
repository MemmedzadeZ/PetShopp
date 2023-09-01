namespace PetShop;

public class Petshop
{

    public Animal[] Cats { get; set; }
    public Animal[] Dogs { get; set; }
    public Animal[] Birds { get; set; }
    public Animal[] Fishes { get; set; }

    public Petshop()
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

    public void AddCat(Animal cat)
    {
        int currentLength = Cats.Length;
        Animal[] newCats = new Animal[currentLength + 1];
        for (int i = 0; i < currentLength; i++)
        {
            newCats[i] = Cats[i];
        }
        newCats[currentLength] = cat;
        Cats = newCats;
        Console.WriteLine($"{cat.Nickname} əlavə edildi.");
    }
    public void AddDog(Animal dog)
    {
        int currentLength = Cats.Length;
        Animal[] newDogs = new Animal[currentLength + 1];
        for (int i = 0; i < currentLength; i++)
        {
            newDogs[i] = Dogs[i];
        }
        newDogs[currentLength] = dog;
        Dogs = newDogs;
        Console.WriteLine($"{dog.Nickname} əlavə edildi.");
    }

    public void AddBird(Animal bird)
    {
        int currentLength = Birds.Length;
        Animal[] newBirds = new Animal[currentLength + 1];
        for (int i = 0; i < currentLength; i++)
        {
            newBirds[i] = Birds[i];
        }
        newBirds[currentLength] = bird;
        Birds = newBirds;
        Console.WriteLine($"{bird.Nickname} əlavə edildi.");
    }

    public void AddFish(Animal fish)
    {
        int currentLength = Fishes.Length;
        Animal[] newFishes = new Animal[currentLength + 1];
        for (int i = 0; i < currentLength; i++)
        {
            newFishes[i] = Fishes[i];
        }
        newFishes[currentLength] = fish;
        Fishes = newFishes;
        Console.WriteLine($"{fish.Nickname} əlavə edildi.");
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




