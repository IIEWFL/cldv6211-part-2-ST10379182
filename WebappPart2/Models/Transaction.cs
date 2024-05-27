// Models/Transaction.cs
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebappPart2.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }

        [ForeignKey("UserAccountAdd")]
        public int UserId { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal TransactionAmount { get; set; }

        public RegisterViewModel UserAccountAdd { get; set; }
    }
}