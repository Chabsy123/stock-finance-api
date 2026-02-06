using System.ComponentModel.DataAnnotations;

namespace stock_finance_api.Dtos.Stock
{
    public class UpdateStockRequestDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Company Name cannot be over 10 characters")]
        public string CompanyName { get; set; } = string.Empty;

        [Required]
        [Range(1, 10000000000)]
        public decimal Purchase { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "Symbol cannot be over 10 characters")]
        public required string Symbol { get; set; } = string.Empty; // Fix: Change from decimal to string

        [Required]
        [Range(0.001, 100)]
        public decimal LastDiv { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "Industry cannot be over 10 characters")]
        public string Industry { get; set; } = string.Empty;

        [Range(1, 5000000000)]
        public long MarketCap { get; set; }
    }
}
