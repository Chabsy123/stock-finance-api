using stock_finance_api.Dtos.Stock;
using stock_finance_api.Models;

namespace stock_finance_api.Mappers
{
    public static class StockMappers
    {
        public static stockDto ToStockDto(this Stock stockModel)
        {
            return new stockDto
            {
//reshapes the data
                Id = stockModel.Id,
                CompanyName = stockModel.CompanyName,
                Purchase = stockModel.Purchase,
                Symbol = stockModel.Symbol,
                LastDiv = stockModel.LastDiv,
                Industry = stockModel.Industry,
                MarketCap = stockModel.MarketCap,
                Comments = stockModel.Comments.Select(c => c.ToCommentDto()).ToList()
            };
        }

        public static Stock ToStockFromCreateDTO(this CreateStockRequestDto stockDto)
        {
            return new Stock
            {
                CompanyName = stockDto.CompanyName,
                Purchase = stockDto.Purchase,
                Symbol = stockDto.Symbol,
                LastDiv = stockDto.LastDiv,
                Industry = stockDto.Industry,
                MarketCap = stockDto.MarketCap
             };
        }
    }
}
