using Decorator.Domain.Abstractions;

namespace Decorator.Domain.Models.Beverages.Addons
{
    public class Milk(IBeverage beverage) : Beverage(beverage)
    {
        public override decimal GetCost() => _beverage.GetCost() + 0.80m;

        public override string GetDescription() => $"{_beverage.GetDescription()}, Milk";
    }
}
