namespace Esercitazione.Models
{
    public class Ticket
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sala { get; set; }
        public string TipoBiglietto { get; set; }
    }

    public static class Sala
    {
        public static List<Ticket> TicketNord = new List<Ticket>();
        public static List<Ticket> TicketEst = new List<Ticket>();
        public static List<Ticket> TicketSud = new List<Ticket>();

        public static void AddTicket(Ticket ticket)
        {
            switch (ticket.Sala)
            {
                case "SALA NORD": TicketNord.Add(ticket); break;
                case "SALA EST": TicketEst.Add(ticket); break;
                case "SALA SUD": TicketSud.Add(ticket); break;
            }
        }
    

    public static int getAllTickets(string Sala)
    {
            return Sala switch
            {
                "SALA NORD" => TicketNord.Count,
                "SALA EST" => TicketEst.Count,
                "SALA SUD" => TicketSud.Count,
            _ => 0,
            };
    }

        public static int getRidotti(string Sala)
        {
            return Sala switch
            {
                "SALA NORD" => TicketNord.Count (t => t.TipoBiglietto == "Ridotto"),
                "SALA EST" => TicketEst.Count(t => t.TipoBiglietto == "Ridotto"),
                "SALA SUD" => TicketSud.Count(t => t.TipoBiglietto == "Ridotto"),
                _ => 0,
            };
        }
    
    }
}
