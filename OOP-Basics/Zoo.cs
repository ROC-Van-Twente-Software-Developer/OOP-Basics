using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics
{
    // Dierentuin, een dierentuin bevat verblijven.
    // De verblijven bevatten weer dieren.
    public class Zoo
    {
        public List<Enclosure> Enclosures { get; set; }

        public Zoo()
        {
            Enclosures = new List<Enclosure>();
        }

        public void AddEnclosure(Enclosure enclosure)
        {
            Enclosures.Add(enclosure);
        }

        public void AddAnimalToEnclosure(IAnimal animal, int enclosureIndex)
        {
            Enclosures[enclosureIndex].AddAnimal(animal);
        }

        public void MakeAllSounds()
        {
            foreach (Enclosure enclosure in Enclosures)
            {
                enclosure.MakeAllSounds();
            }
        }
    }
}
