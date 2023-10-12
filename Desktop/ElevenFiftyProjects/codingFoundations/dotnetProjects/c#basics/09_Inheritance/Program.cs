using _09_Inheritance;

//Animal animal = new Animal();
//!Cannot create an instance of the abstract type or interface animal
//!Animal animal - new Animal();

Cat cat = new Cat();


System.Console.WriteLine(cat.IsMammal);
System.Console.WriteLine(cat.DietType);

TabbyCat tabbyCat = new TabbyCat();
tabbyCat.MakeSound();
tabbyCat.Move();

Hydra mrHydra = new Hydra();
System.Console.WriteLine(mrHydra.HeadCount);