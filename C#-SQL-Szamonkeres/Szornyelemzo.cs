using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace C__SQL_Szamonkeres
{
    internal class Szornyelemzo
    {
        private List<Szorny> szornyek;

        public Szornyelemzo(List<Szorny> szornyek)
        {
            this.szornyek = szornyek;
        }

        public int OsszesSzornySzama()
        {
            var eredmenyek = szornyek.Count();
            return eredmenyek;
        }

        public IEnumerable<string> VeszelyesSzornyekNevei()
        {
            var eredmenyek = szornyek
                .Where(szorny => szorny.VeszelyessegiSzint == 10)
                .Select(szorny => szorny.Nev);
            return eredmenyek;
        }

        public IEnumerable<string> EgyediElohelyek()
        {
            var eredmenyek = szornyek
                .GroupBy(szorny => szorny.Elohely)
                .Select(elohely => elohely.First())
                .Select(elohely => elohely.Elohely)
                .OrderBy(elohely => elohely);
            return eredmenyek;
        }

        public double AtlagosVeszelyesseg()
        {
            var eredmenyek = szornyek.Select(szorny => szorny.VeszelyessegiSzint).Average();
            return eredmenyek;
        }

        public IEnumerable<Szorny> LegveszelyesebbSzornyek()
        {
            var segito = szornyek
                .OrderByDescending(szorny => szorny.VeszelyessegiSzint)
                .Select(szorny => szorny.VeszelyessegiSzint)
                .FirstOrDefault();
            var eredmenyek = szornyek
                .Where(szorny => szorny.VeszelyessegiSzint == segito);
            return eredmenyek;
        }

        public IEnumerable<Szorny> MocsariVeszelyesSzornyek()
        {
            var eredmenyek = szornyek
                .OrderByDescending(szorny => szorny.VeszelyessegiSzint)
                .Where(szorny => szorny.VeszelyessegiSzint >= 5)
                .Where(szorny => szorny.Elohely == "Fekete Mocsár");
            return eredmenyek;
        }

        public bool VanExtremTuzGyengeSzorny()
        {
            var eredmenyek = szornyek
                .Where(szorny => szorny.VeszelyessegiSzint > 9)
                .Any(szorny => szorny.FoGyengeseg == "Tűz" ? true : false);
            return eredmenyek;
        }

        public Dictionary<string, int> SzornyekSzamaElohelyenkent()
        {
            var eredmenyek = szornyek
                .GroupBy(szorny => szorny.Elohely)
                .ToDictionary(
                    group => group.Key,
                    group => group.Count()
                );
            return eredmenyek;
        }
    }
}
