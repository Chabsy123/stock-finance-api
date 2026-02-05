using Microsoft.EntityFrameworkCore;
using stock_finance_api.Data;
using stock_finance_api.Dtos.Stock;
using stock_finance_api.Interface;
using stock_finance_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Repository
{
    public class StockRepository : IStockRepository
    {
        private readonly ApplicationDbContext _context;
        public StockRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<List<Stock>> GetAllAsync()
        {
            return _context.Stock.ToListAsync();
        }

        public Task<List<Stock>> GetByIdAsync()
        {
            // Placeholder implementation. You should update this to accept an id and return the matching stock(s).
            return _context.Stock.ToListAsync();
        }

        public Task<List<Stock>> CreateAsync(Stock stockModel)
        {
            _context.Stock.Add(stockModel);
            return SaveAndReturnAllAsync();
        }

        public Task<List<Stock>> UpdateAsync(int id, UpdateStockRequestDto stockDto)
        {
            var stock = _context.Stock.Find(id);
            if (stock != null)
            {
                // Update properties here as needed, e.g. stock.Name = stockDto.Name;
                // This is a placeholder. You should map all properties from stockDto to stock.
                _context.Stock.Update(stock);
            }
            return SaveAndReturnAllAsync();
        }

        public Task<List<Stock>> DeleteAsync(int id)
        {
            var stock = _context.Stock.Find(id);
            if (stock != null)
            {
                _context.Stock.Remove(stock);
            }
            return SaveAndReturnAllAsync();
        }

        private async Task<List<Stock>> SaveAndReturnAllAsync()
        {
            await _context.SaveChangesAsync();
            return await _context.Stock.ToListAsync();
        }
    }
}