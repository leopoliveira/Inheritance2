using System.Text;
using System.Globalization;

namespace Inheritance2.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee): base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("---------------------");
            sb.AppendLine("\tProduct TAG: ");
            sb.AppendLine($"\tProduct: {Name}");
            sb.Append($"\tPrice: $ {Price.ToString("F2", CultureInfo.InvariantCulture)}");
            sb.AppendLine($" + Customs Fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)}");
            sb.AppendLine($"\tFinal Price: $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }
    }
}
