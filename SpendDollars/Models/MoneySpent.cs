using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SpendDollars.Models
{
    public class MoneySpent
    {
       
        public int ID { get; set; }

        [DataType(DataType.Currency)]
        [Range(0, 100)]
        [AllowNull]
        public decimal EatOut { get; set; }

        [DataType(DataType.Currency)]
        [Range(0, 100)]
        [AllowNull]
        public decimal Vacation { get; set; }

        [DataType(DataType.Currency)]
        [Range(0, 100)]
        [AllowNull]
        public decimal Entertainment { get; set; }

        [DataType(DataType.Currency)]
        [Range(0, 100)]
        [AllowNull]
        public decimal Education { get; set; }

        [DataType(DataType.Currency)]
        [Range(0, 100)]
        [AllowNull]
        public decimal Shopping { get; set; }

        [DataType(DataType.Currency)]
        [Range(0, 100)]
        [AllowNull]
        public decimal Party { get; set; }

        [DataType(DataType.Currency)]
        [Range(0, 100)]
        [AllowNull]
        public decimal Donate { get; set; }

        [DataType(DataType.Currency)]
        [Range(0, 100)]
        [AllowNull]
        public decimal Spa { get; set; }

        [DataType(DataType.Currency)]
        [Range(0, 100)]
        [AllowNull]
        public decimal Hobby { get; set; }

        [DataType(DataType.Currency)]
        [Range(0, 100)]
        [AllowNull]
        public decimal Personal { get; set; }

        
    }
}
