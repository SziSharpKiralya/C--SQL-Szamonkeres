using ZstdSharp.Unsafe;

namespace C__SQL_Szamonkeres
{
    internal class Program
    {
        static void TesztekFuttatasa(Szornyelemzo methods)
        {
            Console.ResetColor();
            Console.Write($"Az összes szörny száma: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(methods.OsszesSzornySzama());

            Console.ResetColor();
            Console.Write($"A 10-es veszélyességű szörnyek nevei: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();

            foreach (var szornyNev in methods.VeszelyesSzornyekNevei())
            {
                Console.WriteLine($" {szornyNev}");
            }

            Console.ResetColor();
            Console.Write($"Az egyedi élőhelyek nevei: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();

            foreach (var elohelyNev in methods.EgyediElohelyek())
            {
                Console.WriteLine($" {elohelyNev}");
            }

            Console.ResetColor();
            Console.Write($"A szörnyek átlagos veszélyességi szintje: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Math.Round(methods.AtlagosVeszelyesseg(), 2));

            Console.ResetColor();
            Console.Write($"A legveszélyesebb szörnyek nevei: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();

            foreach (Szorny szorny in methods.LegveszelyesebbSzornyek())
            {
                Console.WriteLine($" {szorny.Nev} {szorny.VeszelyessegiSzint}");
            }

            Console.ResetColor();
            Console.Write($"A mocsárban élő legalább 5-ös veszélyességű szörnyek: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();

            foreach (Szorny szorny in methods.MocsariVeszelyesSzornyek())
            {
                Console.WriteLine($" {szorny.Nev} {szorny.VeszelyessegiSzint} {szorny.Elohely}");
            }

            Console.ResetColor();
            Console.Write($"Van -e olyan szörny, ami 9-es veszélyesség felett van, de gyengesége a tűz: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(methods.VanExtremTuzGyengeSzorny() ? "Igen, van" : "Nem, nincs");

            Console.ResetColor();
            Console.Write($"Különböző élőhelyek, és hozzájuk tartozó szörnyszámuk: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();

            foreach (var kiir in methods.SzornyekSzamaElohelyenkent())
            {
                Console.WriteLine($" {kiir}");
            }

            Console.ResetColor();
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
