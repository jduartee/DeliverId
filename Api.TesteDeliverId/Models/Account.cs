using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.TesteDeliverId.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public decimal CurrentValue { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
