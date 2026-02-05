using stock_finance_api.Dtos.Stock;
using stock_finance_api.Models;

namespace stock_finance_api.Interface
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync();
        Task<List<Stock>> GetByIdAsync();
        Task<List<Stock>> CreateAsync(Stock stockModel);
        Task<List<Stock>> UpdateAsync(int id, UpdateStockRequestDto stockDto);
        Task<List<Stock>> DeleteAsync(int id);

    }
}
