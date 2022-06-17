using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SpendDollars.Models
{
    public class MoneySpent
    {
       
        public int ID { get; set; }
        [Range(0,100)]
        [AllowNull]
        public int EatOut { get; set; }
        [Range(0, 100)]
        [AllowNull]
        public int Vacation { get; set; }
        [Range(0, 100)]
        [AllowNull]
        public int Entertainment { get; set; }
        [Range(0, 100)]
        [AllowNull]
        public int Education { get; set; }
        [Range(0, 100)]
        [AllowNull]
        public int Shopping { get; set; }
        [Range(0, 100)]
        [AllowNull]
        public int Party { get; set; }
        [Range(0, 100)]
        [AllowNull]
        public int Donate { get; set; }
        [Range(0, 100)]
        [AllowNull]
        public int Spa { get; set; }
        [Range(0, 100)]
        [AllowNull]
        public int Hobby { get; set; }
        [Range(0, 100)]
        [AllowNull]
        public int Personal { get; set; }

        
    }
}
