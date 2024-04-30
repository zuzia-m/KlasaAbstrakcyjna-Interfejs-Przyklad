using ConsoleApp1;

var pies = new Pies();
var kot = new Kot();


Console.WriteLine("p - pies, k - kot");
var input = Console.ReadLine();

if (input == "p")
{
    //pies.Biegnij();
    //pies.DajGłos();
    //pies.Jedz();
    BiegnijDajGlosJedz(pies);
}
else if (input == "k")
{
    //kot.Biegnij();
    //kot.DajGłos();
    //kot.Jedz();
    BiegnijDajGlosJedz(kot);
}


void BiegnijDajGlosJedz(IZwierze zwierze)
{
    zwierze.Biegnij();
    zwierze.DajGłos();
    zwierze.Jedz();
}