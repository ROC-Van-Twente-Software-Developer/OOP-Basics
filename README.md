# OOP-Basics
We hebben een interface IAnimal gedefinieerd die elk dier in onze dierentuin moet implementeren. Deze interface specificeert dat elk dier een Name moet hebben, en een methode MakeSound() moet kunnen aanroepen.

De Animal klasse is een abstracte klasse die de IAnimal interface implementeert. Een abstracte klasse is een soort blauwdruk voor andere klassen. Het stelt dat elk 'Animal' een naam heeft, maar het laat de implementatie van de MakeSound() methode open, aangezien verschillende dieren verschillende geluiden maken.

Lion en Elephant zijn specifieke dierklassen die erven van de abstracte Animal klasse. Ze geven hun eigen unieke implementatie van de MakeSound() methode, wat inhoudt dat ze het specifieke geluid dat ze maken naar de console schrijven.

De Enclosure klasse stelt een verblijf in de dierentuin voor. Het heeft een lijst van dieren (Animals) die het bevat. Je kunt een dier toevoegen aan het verblijf met de AddAnimal() methode, en je kunt alle dieren in het verblijf hun geluid laten maken met de MakeAllSounds() methode.

De Zoo klasse is een verzameling van deze verblijven (Enclosures). Je kunt een verblijf toevoegen aan de dierentuin met de AddEnclosure() methode, een dier aan een specifiek verblijf toevoegen met de AddAnimalToEnclosure() methode, en alle dieren in de dierentuin hun geluid laten maken met de MakeAllSounds() methode.

Ten slotte, in de Main() methode van de Program klasse, creëren we een nieuwe dierentuin, maken we verblijven voor leeuwen en olifanten, voegen we leeuwen en olifanten toe aan hun respectievelijke verblijven, voegen we de verblijven toe aan de dierentuin, en laten we ten slotte alle dieren in de dierentuin hun geluid maken.
