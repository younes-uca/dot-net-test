using DotnetGenerator.Zynarator.Audit;
namespace DotnetGenerator.Bean.Core;


    public class PurchaseItem:  AuditBusinessObject
    {
        public decimal? Price { get; set; }
        public decimal? Quantity { get; set; }

        public Product? Product { get; set; }
        public Purchase? Purchase { get; set; }

    }

