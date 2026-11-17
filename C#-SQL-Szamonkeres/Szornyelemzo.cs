using System;
using System.Collections;
using System.Collections.Generic;
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
                .Select(elohely => elohely.Elohely);
            return eredmenyek;
        }

        public double AtlagosVeszelyesseg()
        {
            var eredmenyek = szornyek.Select(szorny => szorny.VeszelyessegiSzint).Average();
            return eredmenyek;
        }

        public IEnumerable<Szorny> LegveszelyesebbSzornyek()
        {
            throw new NotImplementedException("Még nincs kész");
        }

        public IEnumerable<Szorny> MocsariVeszelyesSzornyek()
        {
            throw new NotImplementedException("Még nincs kész");
        }

        public bool VanExtremTuzGyengeSzorny()
        {
            throw new NotImplementedException("Még nincs kész");
        }

        public IEnumerable<string> SzornyekSzamaElohelyenkent()
        {
            throw new NotImplementedException("Még nincs kész");
        }
    }
}
