using PetShop;
using System.ComponentModel.DataAnnotations;

class Petshop
{
    static void Main()
    {
        int secim = 1; // Başlangıçta menüdeki ilk seçeneği seçiyoruz
        bool devamEt = true;
        while (devamEt)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine(secim == 1 ? "> " : "  " + "1. Cat");
            Console.WriteLine(secim == 2 ? "> " : "  " + "2. Dog");
            Console.WriteLine(secim == 3 ? "> " : "  " + "3. Bird");
            Console.WriteLine(secim == 4 ? "> " : "  " + "4. Fish");
            Console.WriteLine(secim == 5 ? "> " : "  " + "5. Exit");
 

            // Kullanıcının tuş girişini oku
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            // Seçimleri değiştirmek için tuşları kontrol et
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    if (secim > 1)
                        secim--;
                    break;
                case ConsoleKey.DownArrow:
                    if (secim < 5)
                        secim++;
                    break;
                case ConsoleKey.Enter:
                    devamEt = SecimiIsle(secim);
                    break;
            }
        }
    }



    static bool SecimiIsle(int secim)
    {
        switch (secim)
        {
            //Console.WriteLine("Eat: ");

           
            case 1:
                Console.Clear();

                Console.WriteLine(@"1.Eat:
                                    2.Sleep:
                                    3.Play: 
                                     ");
;
                string choice_cat = Console.ReadLine();
                Animal cat = new Animal("Mestan",2,"Male",11,200.50,2);
                if(choice_cat == "1")
                {
                    cat.Eat();
                }
                else if(choice_cat == "2")
                {
                    cat.Sleep();
                }
                else if(choice_cat == "3")
                {
                    cat.Play();
                }
                Console.ReadKey();
                return true; 
            case 2:
                Console.Clear();

                Console.WriteLine(@"1.Eat:
                                    2.Sleep:
                                    3.Play: 
                                     ");
                ;
                string choice_dog = Console.ReadLine();
                Animal dog = new Animal("Qara", 3, "Famale", 0, 500.0, 1);
                if (choice_dog == "1")
                {
                    dog.Eat();
                }
                else if (choice_dog == "2")
                {
                    dog.Sleep();
                }
                else if (choice_dog == "3")
                {
                    dog.Play();
                }

                Console.ReadKey();
                return true; 
            case 3:
                Console.Clear();

                Console.WriteLine(@"1.Eat:
                                    2.Sleep:
                                    3.Play: 
                                     ");
                ;
                string choice_bird = Console.ReadLine();
                Animal bird = new Animal("Passa", 1, "Male", 15, 200.0, 2);
                if (choice_bird == "1")
                {
                    bird.Eat();
                }
                else if (choice_bird == "2")
                {
                    bird.Sleep();
                }
                else if (choice_bird == "3")
                {
                    bird.Play();
                }

                Console.ReadKey();
                return true; 
            case 4:
                Console.Clear();

                Console.WriteLine(@"1.Eat:
                                    2.Sleep:
                                    3.Play: 
                                     ");
                ;
                string choice_fish = Console.ReadLine();
                Animal fish = new Animal("Bifi", 4, "Famale", 9, 580.0, 2);
                if (choice_fish == "1")
                {
                    fish.Eat();
                }
                else if (choice_fish == "2")
                {
                    fish.Sleep();
                }
                else if (choice_fish == "3")
                {
                    fish.Play();
                }


                Console.ReadKey();
                return true; 
            case 5:
                Console.Clear();
                Console.WriteLine("EXIT..");
                return false; 
            default:
                return true;
        }
    }
}

