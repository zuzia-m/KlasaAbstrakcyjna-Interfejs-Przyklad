using ConsoleApp1;

var pies = new Pies();
var kot = new Kot();
var ryba = new Ryba();


Console.WriteLine("p - pies, k - kot, r - ryba");
var input = Console.ReadLine();

if (input == "p")
{
    BiegnijDajGlosJedz(pies);
}
else if (input == "k")
{
    BiegnijDajGlosJedz(kot);
}
else if (input == "r")
{
    BiegnijDajGlosJedz(ryba);
}


void BiegnijDajGlosJedz(IZwierze zwierze)
{
    zwierze.Ruszaj();
    zwierze.DajGłos();
    zwierze.Jedz();
}