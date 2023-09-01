
using PetShop;

PetSHop petshop = new();
Animal cat = new ("Mestan", 3, "Famale", 11,100.0,9);



cat.Eat();
cat.Eat();
cat.Eat();
cat.Eat();

cat.Play();


cat.PriceIncrease(200.0);

petshop.RemoveByNickname("Mestan");

