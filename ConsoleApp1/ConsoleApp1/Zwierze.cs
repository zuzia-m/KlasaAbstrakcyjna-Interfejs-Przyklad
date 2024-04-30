namespace ConsoleApp1
{
    public abstract class Zwierze : IZwierze
    {
        public string Imie { get; set; }

        public abstract void Ruszaj();

        public virtual void DajGłos()
        {
            Console.WriteLine("Daję głos");
        }

        public void Jedz()
        {
            Console.WriteLine("Jem");
        }
    }
}
