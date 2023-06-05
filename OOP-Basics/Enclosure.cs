namespace OOP_Basics
{
    // Verblijf, een verblijf kan dieren bevatten
    // In dit voorbeeld kunnen dit alle soorten dieren zijn!
    public class Enclosure
    {
        public List<IAnimal> Animals { get; set; }

        public Enclosure()
        {
            Animals = new List<IAnimal>();
        }

        public void AddAnimal(IAnimal animal)
        {
            // Controleer of animal van het zelfde type is als er al een dier in de lijst staat. 
            // Een olifant en leeuw in hetzelfde verblijf is geen goed idee. 

            if (Animals.Count > 0)
            {
                if (animal.GetType() != Animals[0].GetType())
                {
                    throw new Exception("Er mogen geen 2 verschillende dieren in 1 verblijf zitten.");
                }
            }

            Animals.Add(animal);
        }

        public void MakeAllSounds()
        {
            foreach (IAnimal animal in Animals)
            {
                animal.MakeSound();
            }
        }
    }
}
