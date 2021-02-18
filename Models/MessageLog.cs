using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elsayed_Mohammed_Leilla.Models
{
    public class MessageLog
    {
        [Key]
        public int Id { get; set; }

        public DateTime ActionDate { get; set; }


        [ForeignKey(nameof(Message))]
        public int MessageId { get; set; }

        [ForeignKey(nameof(MobileNumber))]
        public int MobileNumberId { get; set; }

        public virtual MobileNumber MobileNumber { get; set; }


        public virtual Message Message { get; set; }


    }
}