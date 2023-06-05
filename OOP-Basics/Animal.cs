/**
 * Abstract class erft van de IAnimal interface. De reden is dat een abstract class een gedeeltelijke 
 * implementatie van de interface kan bieden. die door alle afgeleide klassen gebruikt kan worden. 
 * Dit helpt om code duplicatie te verminderen en je code beter onderhoudbaar te maken.
 * 
 * Abstract classes kunnen niet geinstantieerd worden en kunnen alleen gebruikt worden als base classes
 * voor andere classes. 
 */

namespace OOP_Basics
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public abstract void MakeSound();
    }
}
