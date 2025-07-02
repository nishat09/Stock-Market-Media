using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.stock;
using api.models;

namespace api.Mappers
{
    public static class StockMapper
    {
        public static StockDto ToStockDto(this Stocks StocksModel)
        {
            return new StockDto
            {

                Id = StocksModel.Id,
                Symbol = StocksModel.Symbol,
                CompanyName = StocksModel.CompanyName,
                Purchase = StocksModel.Purchase,
            };
        }

        public static Stocks ToStockFromCreateDto(this CreateStockRequestDto StockDto)
        {
            return new Stocks
            {
                Symbol = StockDto.Symbol,
                CompanyName = StockDto.CompanyName,
                Purchase = StockDto.Purchase,
                LastDiv = StockDto.Purchase,
                Industry = StockDto.Industry,
                MarketCap = StockDto.MarketCap

            };
        }

    }
}