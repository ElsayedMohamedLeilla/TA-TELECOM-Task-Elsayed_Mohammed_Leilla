using System.ComponentModel.DataAnnotations;

namespace Elsayed_Mohammed_Leilla.Models
{
    public class MobileNumber
    {
        [Key]
        public int Id { get; set; }

        public int Code { get; set; }

        [Display(Name = "Mobile Number")]
        public string Number { get; set; }

        public bool Sent { get; set; }


    }
}