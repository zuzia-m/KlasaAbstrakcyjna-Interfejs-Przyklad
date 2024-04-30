namespace ConsoleApp1
{
    public abstract class Zwierze : IZwierze
    {
        public string Imie { get; set; }

        public void Biegnij()
        {
            Console.WriteLine("Biegnę");
        }

        public abstract void DajGłos();

        public void Jedz()
        {
            Console.WriteLine("Jem");
        }
    }
}
