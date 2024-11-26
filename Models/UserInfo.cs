using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{

    public class UserInfo
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Lütfen Ad Soyad giriniz.")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Lütfen telefon giriniz.")]
        public string? Phone { get; set; }
        [Required(ErrorMessage ="Lütfen email giriniz.")]
        [EmailAddress(ErrorMessage ="Hatalı Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage ="Lütfen katılım durumunuzu giriniz.")]
        public bool WillAttend { get; set; }
        
    }
}