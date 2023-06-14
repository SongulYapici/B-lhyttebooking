using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bålhyttebooking
{ 
        public class Reservation
        {
            //Instansfelter
            public int ID
            //Properties
            { get; set; }

            //Instansfelter
            public DateTime Tidspunkt
            //Properties
            { get; set; }

            //Instansfelter
            public Boernegruppe Boernegruppe
            //Properties
            { get; set; }

            //konstruktører
            public Reservation(int id, DateTime tidspunkt, Boernegruppe boernegruppe)
            {
                ID = id;
                Tidspunkt = tidspunkt;
                Boernegruppe = boernegruppe;

            }

            //ToString Metode
            public override string ToString()
            {
                return $"ReservationsId: {ID}, Dato: {Tidspunkt}, Børnegruppe: {Boernegruppe}";
            }


        }
    
}
