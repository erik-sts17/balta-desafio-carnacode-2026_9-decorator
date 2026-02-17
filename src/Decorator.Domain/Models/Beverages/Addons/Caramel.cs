using Decorator.Domain.Abstractions;

namespace Decorator.Domain.Models.Beverages.Addons
{
    public class Caramel(IBeverage beverage) : Beverage(beverage)
    {
        public override decimal GetCost() => _beverage.GetCost() + 0.95m;
        public override string GetDescription() => $"{_beverage.GetDescription()}, Caramel";
    }
}