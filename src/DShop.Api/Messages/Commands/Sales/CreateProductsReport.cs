using System;
using DShop.Common.Messages;
using Newtonsoft.Json;

namespace DShop.Api.Messages.Commands.Sales
{
    [MessageNamespace("sales")]
    public class CreateProductsReport : ICommand
    {
        public Guid Id { get; }
        public int MaxRank { get; }
        
        [JsonConstructor]
        public CreateProductsReport(Guid id, int maxRank)
        {
            Id = id;
            MaxRank = maxRank;
        }
    }
}