using DotnetGenerator.Zynarator.Audit;
namespace DotnetGenerator.Bean.Core;


    public class Purchase:  AuditBusinessObject
    {
        public string? Reference { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string? Image { get; set; }
        public decimal? Total { get; set; }
        public string? Description { get; set; }

        public Client? Client { get; set; }
        public PurchaseState? PurchaseState { get; set; }

        public List<PurchaseItem>? PurchaseItems { get; set; }
        public List<PurchaseTag>? PurchaseTags { get; set; }
    }

