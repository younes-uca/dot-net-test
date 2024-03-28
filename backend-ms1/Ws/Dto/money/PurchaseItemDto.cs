using DotnetGenerator.Zynarator.Dto;

namespace DotnetGenerator.Ws.Dto;


    public class PurchaseItemDto : BaseDto {
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public ProductDto? Product { get; set; }
        public PurchaseDto? Purchase { get; set; }

    }

