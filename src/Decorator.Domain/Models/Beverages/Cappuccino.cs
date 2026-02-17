using Decorator.Domain.Abstractions;

namespace Decorator.Domain.Models.Beverages
{
    public class Cappuccino : IBeverage
    {
        public decimal GetCost() => 4.5m;
        public string GetDescription() => "Cappuccino";
    }
}