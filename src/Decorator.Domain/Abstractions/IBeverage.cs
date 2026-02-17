namespace Decorator.Domain.Abstractions
{
    public interface IBeverage
    {
        decimal GetCost();
        string GetDescription();
    }
}