using Övning_1_Generics;


LghCollection lägenheter = new LghCollection();

//Add items to list
lägenheter.Add(new Lägenhet(1, 1001, 2));
lägenheter.Add(new Lägenhet(2, 1002, 1));
lägenheter.Add(new Lägenhet(3, 1003, 3));
lägenheter.Add(new Lägenhet(4, 1004, 5));
lägenheter.Add(new Lägenhet(5, 1005, 4));

//Try add item that is already in list
lägenheter.Add(new Lägenhet(5, 1005, 4));
Console.WriteLine("\n---------------------------------------\n");

//Compare to see if item is in list
Lägenhet containsLgh = new Lägenhet(1, 1001, 2);
Console.WriteLine(lägenheter.Contains(containsLgh));
Console.WriteLine("\n---------------------------------------\n");

//Display all items in the list
Display(lägenheter);

static void Display(LghCollection lägenheter)
{
    foreach (Lägenhet item in lägenheter)
    {
        Console.WriteLine("{0}", item.ID.ToString());
        Console.WriteLine("{0}", item.LghNummer.ToString());
        Console.WriteLine("{0}", item.AntalPersoner.ToString());
        Console.WriteLine();
    }
}