using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketSite.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public int TotalAmount { get; set; }
        public int CardId { get; set; }


        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:/MM/yyyy}")]
        [Required(ErrorMessage = "Lütfen geçerli bir tarih seçiniz.")]
        public DateTime CardDate { get; set; }
        public int CVV { get; set; }
        [ForeignKey("PassengerId")]
        public Passenger Passenger { get; set; }
        public string TicketType { get; set; }
    }
}
