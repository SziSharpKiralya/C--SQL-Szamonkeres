using System;
using System.Collections.Generic;
using System.Text;

namespace C__SQL_Szamonkeres
{
    internal class Szorny
    {
        private int id;
        private string nev;
        private int veszelyessegiSzint;
        private string elohely;
        private string foGyengeseg;
        private string leggyakoribbZsakmany;
        private bool veszelyesE;

        public Szorny(int id, string nev, int veszelyessegiSzint, string elohely, string foGyengeseg, string leggyakoribbZsakmany, bool veszelyesE)
        {
            this.id = id;
            this.nev = nev;
            this.veszelyessegiSzint = veszelyessegiSzint;
            this.elohely = elohely;
            this.foGyengeseg = foGyengeseg;
            this.leggyakoribbZsakmany = leggyakoribbZsakmany;
            this.veszelyesE = veszelyesE;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public int VeszelyessegiSzint { get => veszelyessegiSzint; set => veszelyessegiSzint = value; }
        public string Elohely { get => elohely; set => elohely = value; }
        public string FoGyengeseg { get => foGyengeseg; set => foGyengeseg = value; }
        public string LeggyakoribbZsakmany { get => leggyakoribbZsakmany; set => leggyakoribbZsakmany = value; }
        public bool VeszelyesE { get => veszelyesE; set => veszelyesE = value; }
    }
}
