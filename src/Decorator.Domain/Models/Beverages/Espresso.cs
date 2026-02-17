using Decorator.Domain.Abstractions;

namespace Decorator.Domain.Models.Beverages
{
    public class Espresso : IBeverage
    {
        public virtual decimal GetCost() => 3.50m;
        public virtual string GetDescription() => "Espresso";
    }
}