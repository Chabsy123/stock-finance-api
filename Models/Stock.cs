using System.ComponentModel.DataAnnotations.Schema;

namespace stock_finance_api.Models
{
    public class Stock
    {
        public int Id { get; set; }

        public string MyProperty { get; set; } = string.Empty;

        public string CompanyName { get; set; } = string.Empty;
        //eighteen digits, two decimal places
        [Column(TypeName = "decimal(18,2)")]

        public decimal Purchase { get; set; }

        public decimal Dividend { get; set; }
        [Column(TypeName = "decimal(18,2)")]

        public decimal LastDiv { get; set; }

        public string Industry { get; set; } = string.Empty;

        public long MarketCap { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

    }
}
