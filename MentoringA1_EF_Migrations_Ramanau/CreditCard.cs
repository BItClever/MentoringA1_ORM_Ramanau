using System.ComponentModel.DataAnnotations;

namespace MentoringA1_EF_Migrations_Ramanau
{
    public class CreditCard
    {
        public int Id { get; set; }
        [StringLength(16)]
        public string CardNumber { get; set; }
        [StringLength(4)]
        public string ExpirationDate { get; set; }
        [StringLength(4)]
        public string Cardholder { get; set; }
        public Customer Customer { get; set; }
    }
}
