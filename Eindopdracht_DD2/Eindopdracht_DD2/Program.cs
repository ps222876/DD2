// See https://aka.ms/new-console-template for more information
using Eindopdracht_DD2.Classes;
using System.Collections.Generic;


//Wedstrijden aanmaken


Binnenwedstrijd binnenwedstrijd1 = new Binnenwedstrijd();
binnenwedstrijd1.Naam = "BinnenWedstrijd1";
binnenwedstrijd1.StartDatum = DateTime.Now;
binnenwedstrijd1.WedstrijdDuur = new TimeSpan(3, 0, 0);
binnenwedstrijd1.Doorstroom = false;



Buitenwedstrijd buitenwedstrijd1 = new Buitenwedstrijd();
buitenwedstrijd1.Naam = "BuitenWedstrijd1";
buitenwedstrijd1.StartDatum = DateTime.Now;
buitenwedstrijd1.WedstrijdDuur = new TimeSpan(3, 0, 0);
buitenwedstrijd1.Doorstroom = true;



MuseumUitje museumuitje1 = new MuseumUitje();
museumuitje1.Naam = "Museumuitje1";
museumuitje1.StartDatum = DateTime.Now;
museumuitje1.BinnenEvent = true;
museumuitje1.Doorstroom = true;
museumuitje1.Toegangsprijs = 6;



BioscoopUitje biouitje1 = new BioscoopUitje();
biouitje1.Naam = "Bioscoopuitje1";
biouitje1.StartDatum = DateTime.Now;
biouitje1.Doorstroom = true;
biouitje1.BinnenEvent = true;
biouitje1.AanvangsTijdstip = new DateTime(2022, 10, 10, 16, 30, 05);
biouitje1.Duur = new TimeSpan(3, 0, 0);
biouitje1.Film = "Fast and furious";
biouitje1.Zaal = "zaal 1";
biouitje1.Stoel = "24";




// Listen aanmaken

List<Uitje> uitjes = new List<Uitje>();
uitjes.Add(museumuitje1);
uitjes.Add(biouitje1);

List<Wedstrijd> wedstrijden = new List<Wedstrijd>();
wedstrijden.Add(buitenwedstrijd1);
wedstrijden.Add(binnenwedstrijd1);

List<ICoronaCheckEvenement> coronaCheckEvenements = new List<ICoronaCheckEvenement>();



//toon wedstrijden

Console.WriteLine("Hieronder zie je alle wedstrijden");
foreach (Wedstrijd wedstrijd in wedstrijden)
{
    if (wedstrijd is ICoronaCheckEvenement)
    {
        Console.WriteLine("");
        Console.WriteLine("Naam evenement: " + wedstrijd.Naam);
        Console.WriteLine("Startdatum evenement: " + wedstrijd.StartDatum);
        Console.WriteLine("Duur evenement: " + wedstrijd.WedstrijdDuur);
        Console.WriteLine("Is er een doorstroom bij het evenement: " + wedstrijd.Doorstroom);
/*        Console.WriteLine("");
*/        Console.WriteLine("Heeft u een vasteplaats: " + ((ICoronaCheckEvenement)wedstrijd).VastePlaats());
        Console.WriteLine("Is het evenement buiten: " + ((ICoronaCheckEvenement)wedstrijd).Buiten());
        Console.WriteLine("Is er een coronacheck verplicht: " + ((ICoronaCheckEvenement)wedstrijd).CoronaCheckRequired());
    }
}
Console.WriteLine("----------------------------------------");







//toon uitjes
Console.WriteLine("Hieronder zie je alle uitjes");

foreach (Uitje uitje in uitjes)
{
    if (uitje is ICoronaCheckEvenement)
    {
        Console.WriteLine("");
        Console.WriteLine("Naam evenement: " + uitje.Naam);
        Console.WriteLine("Startdatum evenement: " + uitje.StartDatum);
        Console.WriteLine("Is er een doorstroom bij het evenement: " + uitje.Doorstroom);
        Console.WriteLine("Het museum Evenement: " + uitje.BinnenEvent);
        if (uitje is MuseumUitje)
        {
        }
/*        Console.WriteLine("De toegangsprijs van het evenement is: " + uitje.GetType(if uitje = MuseumUitje {Toegangprijs }) ;
*/
    /*    Console.WriteLine("De AanvangsTijdstip van het evenement: " + uitje.GetType(if uitje = ) ;
        Console.WriteLine("De duur van het evenemnt: " + uitje.GetType(if uitje = ) ;
        Console.WriteLine("De toegangsprijs van het evenement: " + uitje.GetType(if uitje = ) ;
        Console.WriteLine("De toegangsprijs van het evenement: " + uitje.GetType(if uitje = ) ;*/

        Console.WriteLine("");
        Console.WriteLine("Heeft u een vasteplaats: " + ((ICoronaCheckEvenement)uitje).VastePlaats());
        Console.WriteLine("Is het evenement buiten: " + ((ICoronaCheckEvenement)uitje).Buiten());
        Console.WriteLine("Is er een coronaceck verplicht: " + ((ICoronaCheckEvenement)uitje).CoronaCheckRequired());
    }
}

Console.WriteLine("----------------------------------------");

