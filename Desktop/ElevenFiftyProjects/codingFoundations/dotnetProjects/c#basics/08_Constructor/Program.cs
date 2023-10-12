using _08_Constructor;

Donuts doug = new Donuts("Creme Filled");
System.Console.WriteLine(doug);
//of_donutType is (private)
//donut._donutType will be inaccessible due to its protection level
System.Console.WriteLine(doug._donutType);
