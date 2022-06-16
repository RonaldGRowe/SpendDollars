using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SpendDollars.Models
{
    public class MoneySpent
    {
       
        public int ID { get; set; }

        [AllowNull]
        public int EatOut { get; set; }

        [AllowNull]
        public int Vacation { get; set; }

        [AllowNull]
        public int Entertainment { get; set; }

        [AllowNull]
        public int Education { get; set; }

        [AllowNull]
        public int Shopping { get; set; }

        [AllowNull]
        public int Party { get; set; }

        [AllowNull]
        public int Donate { get; set; }

        [AllowNull]
        public int Spa { get; set; }

        [AllowNull]
        public int Hobby { get; set; }

        [AllowNull]
        public int Personal { get; set; }

        
    }
}
