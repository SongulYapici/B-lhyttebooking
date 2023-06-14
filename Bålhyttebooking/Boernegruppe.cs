using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bålhyttebooking
{
    public class Boernegruppe
    { //Instansfelter
        public string GruppeID
        //Properties
        { get; set; }

        //Instansfelter
        public string GruppeNavn
        //Properties
        { get; set; }

        //Instansfelter
        public string Aldersgruppe
        //Properties
        { get; set; }

        //Instansfelter
        public int AntalDeltager
        //Properties
        { get; set; }

        //konstruktører
        public Boernegruppe(string id, string navn, string aldersgruppe, int antalDeltager)

        {
            GruppeID = id;
            GruppeNavn = navn;
            Aldersgruppe = aldersgruppe;
            AntalDeltager = antalDeltager;

        }

        //ToString Metode
        public override string ToString()
        {
            return $" GruppeID: {GruppeID}, Navn: {GruppeNavn}, Aldersgruppe {Aldersgruppe} Antaldeltager: {AntalDeltager}";
        }
    }
}

