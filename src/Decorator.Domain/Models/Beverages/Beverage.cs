using Decorator.Domain.Abstractions;

namespace Decorator.Domain.Models.Beverages
{
    public class Beverage(IBeverage beverage) : IBeverage
    {
        protected readonly IBeverage _beverage = beverage;

        public virtual string GetDescription() => _beverage.GetDescription();
        public virtual decimal GetCost() => _beverage.GetCost();
    }
}