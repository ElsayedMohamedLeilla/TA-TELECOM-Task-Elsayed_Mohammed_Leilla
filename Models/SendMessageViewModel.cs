using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Elsayed_Mohammed_Leilla.Models
{
    public class SendMessageViewModel
    {
        public SendMessageViewModel()
        {
            this.MobileNumberIds = new List<int>();
        }

        [Display(Name = "Message Text")]
        [Required(ErrorMessage = "You Must Enter Message")]
        [MinLength(50, ErrorMessage = "Message Should Be 50 Char At Least")]
        public string MessageText { get; set; }

        public List<int> MobileNumberIds { get; set; }
    }
}