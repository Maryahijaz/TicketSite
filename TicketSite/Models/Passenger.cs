using System.ComponentModel.DataAnnotations;

namespace TicketSite.Models
{
    public class Passenger
    {    
            [Key]

            public int PassengerId { get; set; }

          
            [Display(Name = "İsim")]
            [Required(ErrorMessage = "Kullanıcı adı alanı zorunludur.")]
            public string PassengerName { get; set; } // yolcu kapisetesi

            [Display(Name = "Soyisim")]
            [Required(ErrorMessage = "Kullanıcı soyadı alanı zorunludur.")]
            public string PassengerSurname { get; set; }

            [Display(Name = "Doğum tarihi")]
            [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
            [Required(ErrorMessage = "Lütfen geçerli bir tarih seçiniz.")]
            public DateTime Birthday { get; set; }

            [Display(Name = "Cinsiyet")]
            [Required(ErrorMessage = "Lütfen cinsiyet seçiniz")]
            public string passengerGender { get; set; }


            [Display(Name = "TC numarası")]
            [StringLength(11, ErrorMessage = "Lütfen geçerli bir numara giriniz ")]
            [Required(ErrorMessage = " Kimlik numarası alanı zorunludur.")]
            public string TCNumber { get; set; }


            [Display(Name = "Mail adresi")]
            [EmailAddress(ErrorMessage = "Lütfen geçerli bir mail giriniz")]
            [Required(ErrorMessage = "Mail adresi alanı zorunludur.")]
            public string UserMail { get; set; }

            [Display(Name = "telefon no")]
            [Phone(ErrorMessage = "Lütfen geçerli bir telefon numarası giriniz")]
            [Required(ErrorMessage = "Telefon numarası alanı zorunludur.")]
            public string UserPhone { get; set; }

            [Display(Name = "Bilet türü")]
            [Required(ErrorMessage = "Lütfen uçuş sınıfı seçiniz")]
            public string TicketType { get; set; }
        
    }
}

