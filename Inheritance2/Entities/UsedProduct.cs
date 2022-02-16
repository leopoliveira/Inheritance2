using System;
using System.Text;
using System.Globalization;

namespace Inheritance2.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufacturedDate) : base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("---------------------");
            sb.AppendLine("\tProduct TAG: ");
            sb.AppendLine($"\tProduct: (used) {Name}");
            sb.AppendLine($"\tPrice: $ {Price.ToString("F2", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }
    }
}
