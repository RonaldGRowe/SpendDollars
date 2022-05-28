using System.ComponentModel.DataAnnotations;

namespace SpendDollars.Models
{
    public class MoneySpent
    {
        public int ID { get; set; }
        [DataType(DataType.Currency)]
        public decimal EatOut { get; set; }
        [DataType(DataType.Currency)]
        public decimal Vacation { get; set; }
        [DataType(DataType.Currency)]
        public decimal Entertainment { get; set; }
        [DataType(DataType.Currency)]
        public decimal Education { get; set; }
        [DataType(DataType.Currency)]
        public decimal Shopping { get; set; }
        [DataType(DataType.Currency)]
        public decimal Party { get; set; }
        [DataType(DataType.Currency)]
        public decimal Donate { get; set; }
        [DataType(DataType.Currency)]
        public decimal Spa { get; set; }
        [DataType(DataType.Currency)]
        public decimal Hobby { get; set; }
        [DataType(DataType.Currency)]
        public decimal Personal { get; set; }
        public decimal Bonus { get; set; }    
    }
}
