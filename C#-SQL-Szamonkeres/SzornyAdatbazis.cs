using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace C__SQL_Szamonkeres
{
    internal class SzornyAdatbazis
    {
        private readonly string connectionString;

        public SzornyAdatbazis(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Szorny> Feltolt()
        {
            var szornyek = new List<Szorny>();
            using (MySqlConnection connectiom = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM szornyek";
                using (MySqlCommand command = new MySqlCommand(query, connectiom))
                {
                    connectiom.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("Id");
                            string nev = reader.GetString("Nev");
                            int veszelyessegiSzint = reader.GetInt32("VeszelyessegiSzint");
                            string elohely = reader.GetString("Elohely");
                            string foGyengeseg = reader.GetString("FoGyengeseg");
                            string leggyakoribbZsakmany = reader.GetString("LeggyakoribbZsakmany");
                            bool veszelyesE = reader.GetBoolean("veszelyesE");

                            Szorny szorny = new Szorny(
                                id, 
                                nev, 
                                veszelyessegiSzint, 
                                elohely, 
                                foGyengeseg, 
                                leggyakoribbZsakmany, 
                                veszelyesE
                                );
                            szornyek.Add(szorny);
                        }
                    }
                }
            }
            return szornyek;
        }
    }
}
