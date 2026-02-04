using System.Linq;
using Microsoft.AspNetCore.Mvc;
using stock_finance_api.Data;
using stock_finance_api.Dtos.Stock;
using stock_finance_api.Mappers;

namespace stock_finance_api.Controllers
{
    [Route("stock-finance-api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        // make it immutable 
        private readonly ApplicationDbContext _context;
        public StockController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var stocks = _context.Stock.ToList()
                .Select(s => s.ToStockDto());
            // select in C# is "map" in JS

            return Ok(stocks);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var stock = _context.Stock.Find(id);

            if (stock == null)
            {
                return NotFound();
            }

            return Ok(stock.ToStockDto());
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateStockRequestDto stockDto)
        {
            var stockModel = stockDto.ToStockFromCreateDTO();
            _context.Stock.Add(stockModel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = stockModel.Id }, stockModel.ToStockDto());
        }
    }
}
