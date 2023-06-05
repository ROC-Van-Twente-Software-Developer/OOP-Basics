using OOP_Basics;

Zoo zoo = new Zoo();
try
{
    // Maak een verblijf en voeg daar 2 leeuwen aan toe
    Enclosure lionEnclosure = new Enclosure();
    lionEnclosure.AddAnimal(new Lion { Name = "Simba" });
    lionEnclosure.AddAnimal(new Lion { Name = "Nala" });
    zoo.AddEnclosure(lionEnclosure);

    // Maak een verblijf en voeg daar 2 olifanten aan toe
    Enclosure elephantEnclosure = new Enclosure();
    elephantEnclosure.AddAnimal(new Elephant { Name = "Dumbo" });
    elephantEnclosure.AddAnimal(new Elephant { Name = "Jumbo" });
    zoo.AddEnclosure(elephantEnclosure);
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());   
}

zoo.MakeAllSounds();