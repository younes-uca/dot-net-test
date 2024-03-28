using DotnetGenerator.Zynarator.Audit;
namespace DotnetGenerator.Bean.Core;


    public class Client:  AuditBusinessObject
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }

        public ClientCategory? ClientCategory { get; set; }

    }

