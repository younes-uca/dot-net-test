using DotnetGenerator.Zynarator.Dto;

namespace DotnetGenerator.Ws.Dto;


    public class ClientDto : BaseDto {
        public string? FullName { get; set; }
        public string? Email { get; set; }

        public ClientCategoryDto? ClientCategory { get; set; }

    }

