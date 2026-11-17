using ZstdSharp.Unsafe;

namespace C__SQL_Szamonkeres
{
    internal class Program
    {
        static void TesztekFuttatasa(Szornyelemzo methods)
        {

        }

        static void Main(string[] args)
        {
            SzornyAdatbazis db = new SzornyAdatbazis("server=localhost;database=fantasybestariumdb;uid=root;pwd=;");
            List<Szorny> szornyekLista = db.Feltolt();
            Szornyelemzo methods = new Szornyelemzo(szornyekLista);

            TesztekFuttatasa(methods);
        }
    }
}
