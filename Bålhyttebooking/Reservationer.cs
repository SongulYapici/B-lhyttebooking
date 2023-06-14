using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bålhyttebooking
{
    public class Reservationer
    {
        public int ID
        { get; set; }

        public Reservationer(int Id) 
        { 
             ID= Id;
        }

        public override string ToString()
        {
            return $"Reservationer: {ID}";
        }
    }
}
