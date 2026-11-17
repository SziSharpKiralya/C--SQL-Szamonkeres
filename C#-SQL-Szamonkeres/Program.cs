namespace C__SQL_Szamonkeres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SzornyAdatbazis db = new SzornyAdatbazis("server=localhost;database=fantasybestariumdb;uid=root;pwd=;");
            List<Szorny> szornyekLista = db.Feltolt();

            foreach (Szorny szorny in szornyekLista)
            {
                Console.WriteLine($"{szorny.Id} {szorny.Nev}");
            }
        }
    }
}
