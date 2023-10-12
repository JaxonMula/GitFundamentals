using _08_Properties;

Donut donut = new Donut();

//write only
donut.Filling = "Ice Cream";

//read only
System.Console.WriteLine(donut.Filling);

donut.Topping = "Sprinkles";
donut.IsSpecial = false;
donut.price = 1.98m;

System.Console.WriteLine(donut.Topping);
System.Console.WriteLine(donut.IsSpecial);
System.Console.WriteLine(donut.price);

Donut mydonutA = new Donut();
Donut mydonutB = new Donut("Strawberry", "Strawberry Filling", "N/A",true, 30.00m);
mydonutB.proprice = 30.00;
System.Console.WriteLine(mydonutA.GetDonutType)();
System.Console.WriteLine(mydonutB.GetDonutType)();
System.Console.WriteLine(mydonutA.price);
System.Console.WriteLine(mydonutB.price);
mydonutB.IsSpecial = true;
//every object comes with some methods:
//GetsType(), typeof(), ToString()

System.Console.WriteLine(mydonutA.ToString());