using System.ComponentModel.DataAnnotations;

namespace Elsayed_Mohammed_Leilla.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Message Text")]
        [Required(ErrorMessage = "You Must Enter Message")]
        [MinLength(50, ErrorMessage = "Message Should Be 50 Char At Least")]
        public string MessageText { get; set; }
    }
}