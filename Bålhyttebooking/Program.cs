namespace Bålhyttebooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opgave 1");

            Boernegruppe boernegruppe = new Boernegruppe("S1", "Eleverne fra Borgerskolen", "8 til 17", 30);
            Console.WriteLine($"Boernegruppens ID:{boernegruppe.GruppeID}");
            Console.WriteLine($"Boernegruppens Navn: {boernegruppe.GruppeNavn}");
            Console.WriteLine($"Boernegruppens Aldersgruppe: {boernegruppe.Aldersgruppe}");
            Console.WriteLine($"Boernegruppens Antaldeltager {boernegruppe.AntalDeltager}");

            Console.WriteLine("Opgave 2");

            Reservation reservation = new Reservation(100, DateTime.Now, boernegruppe);
            Console.WriteLine($"Reservation ID: {reservation.ID}");
            Console.WriteLine($"Reservation Tidspunkt: {reservation.Tidspunkt}");
            Console.WriteLine($"Reservation BoerneGruppe: {reservation.Boernegruppe}");

            Console.WriteLine("Opgave 3");

            Reservationer reservationer = new Reservationer(3);
            Console.WriteLine($"Reservationer ID: {reservationer.ID}");
        }
    }
}