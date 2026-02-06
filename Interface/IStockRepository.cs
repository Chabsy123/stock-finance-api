using stock_finance_api.Dtos.Stock;
using stock_finance_api.Models;

namespace stock_finance_api.Interface
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync();
        Task<Stock?> GetByIdAsync(int id);
        Task<List<Stock>> CreateAsync(Stock stockModel);
        Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto);
        Task<Stock?> DeleteAsync(int id);

        Task<bool> StockExists(int id);

    }
}
