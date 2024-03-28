using DotnetGenerator.Zynarator.Audit;
namespace DotnetGenerator.Bean.Core;


    public class PurchaseTag:  AuditBusinessObject
    {

        public Purchase? Purchase { get; set; }
        public Tag? Tag { get; set; }

    }

