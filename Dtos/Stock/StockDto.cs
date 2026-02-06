using stock_finance_api.Dtos.Comment;
using stock_finance_api.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace stock_finance_api.Dtos.Stock
{
    public class stockDto
    {
        public int Id { get; set; }

        public string CompanyName { get; set; } = string.Empty;
        //eighteen digits, two decimal places

        public decimal Purchase { get; set; }

        public decimal Dividend { get; set; }
        public decimal LastDiv { get; set; }

        public string Industry { get; set; } = string.Empty;

        public long MarketCap { get; set; }

        public List<CommentDto>? Comments { get; set; }

    }
}
