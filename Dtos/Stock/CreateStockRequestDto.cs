using System.ComponentModel.DataAnnotations.Schema;

namespace stock_finance_api.Dtos.Stock
{
    public class CreateStockRequestDto
    {
        public string CompanyName { get; set; } = string.Empty;

        public decimal Purchase { get; set; }

        public decimal Dividend { get; set; }

        public decimal LastDiv { get; set; }

        public string Industry { get; set; } = string.Empty;

        public long MarketCap { get; set; }
    }
}
