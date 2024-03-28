using DotnetGenerator.Zynarator.Dto;

namespace DotnetGenerator.Ws.Dto;


    public class PurchaseTagDto : BaseDto {

        public PurchaseDto? Purchase { get; set; }
        public TagDto? Tag { get; set; }

    }

