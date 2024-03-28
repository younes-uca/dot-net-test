using DotnetGenerator.Zynarator.Dto;

namespace DotnetGenerator.Ws.Dto;


    public class PurchaseDto : BaseDto {
        public string? Reference { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string? Image { get; set; }
        public decimal Total { get; set; }
        public string? Description { get; set; }

        public ClientDto? Client { get; set; }
        public PurchaseStateDto? PurchaseState { get; set; }

        public List<PurchaseItemDto>? PurchaseItems { get; set; }
        public List<PurchaseTagDto>? PurchaseTags { get; set; }
    }

