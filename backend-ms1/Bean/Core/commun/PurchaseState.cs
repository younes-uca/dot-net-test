using DotnetGenerator.Zynarator.Audit;
namespace DotnetGenerator.Bean.Core;


    public class PurchaseState:  AuditBusinessObject
    {
        public string? Reference { get; set; }
        public string? Code { get; set; }


    }

