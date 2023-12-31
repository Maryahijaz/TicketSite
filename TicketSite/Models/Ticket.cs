using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TicketSite.Models
{
    public class Ticket
    {

        [Key]
        public int TicketId { get; set; }

        [ForeignKey("FlightId")]
        public Flight Flight { get; set; }
        public string FlightNumber { get; set; } // ucus numarası
        public string FlightDeparture { get; set; }
        public string FlightDestination { get; set; }

        [ForeignKey("PassengerId")]
        public Passenger Passenger { get; set; }
        public string PassengerName { get; set; }
        public string PassengerSurname { get; set; }
        public string TicketType { get; set; }
    }
}
