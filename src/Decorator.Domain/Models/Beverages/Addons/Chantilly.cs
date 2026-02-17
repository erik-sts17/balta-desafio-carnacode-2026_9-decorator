using Decorator.Domain.Abstractions;

namespace Decorator.Domain.Models.Beverages.Addons
{
    public class Chantilly(IBeverage beverage) : Beverage(beverage)
    {
        public override decimal GetCost() => _beverage.GetCost() + 0.50m;
        public override string GetDescription() => $"{_beverage.GetDescription()}, Chantilly";
    }
}
