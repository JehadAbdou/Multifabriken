using DotNet;
using DotNet.godis;
using DotNet.produkt;
using DotNet.produkter;


bool isRunning = true;
Produkter produkter= new Produkter();
while (isRunning){
Console.WriteLine("Vad önskar du beställa?");
Console.WriteLine("1: Bilar.");
Console.WriteLine("2: Godis.");
Console.WriteLine("3: Rör.");
Console.WriteLine("4: Havremjölk.");
Console.WriteLine("5: Lista all produkter.");
Console.WriteLine("6: Avsluta programmet.");

int userChoice = int.Parse(Console.ReadLine());

switch (userChoice){

    case 1:
    
    Console.WriteLine("Vad är det för bil vill du producera: ");
    Console.WriteLine("önskade reg nummer: ");
    int regNummer = int.Parse(Console.ReadLine());
    Console.WriteLine("önskade färg : ");
    string färg = Console.ReadLine();
    Console.WriteLine("önskade bilmärke : ");
    string bilmärke = Console.ReadLine();
    Bilar bil=new Bilar(regNummer,färg,bilmärke);
    Produkt bilProdukt=new Produkt(bil);
    produkter.produkterList.Add(bilProdukt);
    Console.WriteLine("produkt har lagts till ");
    Console.WriteLine("tryck ett knapp för att gå tillbaka till menyn...");
    Console.ReadLine();
    break;


    case 2:
    
    Console.WriteLine("Vad är det för Godis vill du producera: ");
    Console.WriteLine("önskade antal : ");
    int antal = int.Parse(Console.ReadLine());
    Console.WriteLine("önskade smak : ");
    string smak = Console.ReadLine();
    Godis godis=new Godis(antal,smak);
    Produkt godisProdukt=new Produkt(godis);
    produkter.produkterList.Add(godisProdukt);
    Console.WriteLine("produkt har lagts till ");
    Console.WriteLine("tryck ett knapp för att gå tillbaka till menyn...");
    Console.ReadLine();
    break;


    case 3:
    
    Console.WriteLine("Vad är det för Rör vill du producera: ");
    Console.WriteLine("önskade Längd in meter : ");
    double längd = double.Parse(Console.ReadLine());
    Console.WriteLine("önskade Diameter in meter : ");
    double diameter = double.Parse(Console.ReadLine());
    Rör rör=new Rör(längd,diameter);
    Produkt rörProdukt=new Produkt(rör);
    produkter.produkterList.Add(rörProdukt);
    Console.WriteLine("produkt har lagts till ");
    Console.WriteLine("tryck ett knapp för att gå tillbaka till menyn...");
    Console.ReadLine();
    break;
    case 4:
    
    Console.WriteLine("Vad är det för Havremjölk vill du producera: ");
    Console.WriteLine("önskade Fetthalt : ");
    double fetthalt = double.Parse(Console.ReadLine());
    Console.WriteLine("önskade Litermängd in liter : ");
    double litermängd = double.Parse(Console.ReadLine());
    Havremjölk havremjölk=new Havremjölk(fetthalt,litermängd);
    Produkt havremjölkProdukt=new Produkt(havremjölk);
    produkter.produkterList.Add(havremjölkProdukt);
    Console.WriteLine("produkt har lagts till ");
    Console.WriteLine("tryck ett knapp för att gå tillbaka till menyn...");
    Console.ReadLine();
    break;

    case 5:

    foreach (Produkt userProdukt in produkter.produkterList){
        Console.WriteLine( userProdukt.produktInfo());
        
    }
    Console.WriteLine("");
    Console.WriteLine("tryck ett knapp för att gå tillbaka till menyn...");
    Console.ReadLine();
    break;

    case 6:
Console.WriteLine("Program avslutad...");
Console.ReadLine();

    isRunning = false;
    break;
        }
    
}
