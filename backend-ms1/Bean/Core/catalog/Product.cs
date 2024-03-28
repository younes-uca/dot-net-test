using DotnetGenerator.Zynarator.Audit;
namespace DotnetGenerator.Bean.Core;


    public class Product:  AuditBusinessObject
    {
        public string? Code { get; set; }
        public string? Reference { get; set; }


    }

