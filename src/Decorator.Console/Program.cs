using Decorator.Domain.Models.Beverages.Addons;
using Decorator.Domain.Models.Beverages;

Console.WriteLine("=== Sistema de Pedidos - Cafeteria ===\n");

var coffeeExpresso = new Espresso();
Console.WriteLine($"{coffeeExpresso.GetDescription()}: R$ {coffeeExpresso.GetCost():N2}");

var coffeeExpressoWithMilk = new Milk(coffeeExpresso);
Console.WriteLine($"{coffeeExpressoWithMilk.GetDescription()}: R$ {coffeeExpressoWithMilk.GetCost():N2}");

var coffeeExpressoWithMilkAndChocolate = new Chocolate(coffeeExpressoWithMilk);
Console.WriteLine($"{coffeeExpressoWithMilkAndChocolate.GetDescription()}: R$ {coffeeExpressoWithMilkAndChocolate.GetCost():N2}");

var cafeCompleto = new Caramel(new Chantilly(coffeeExpressoWithMilkAndChocolate));
Console.WriteLine($"{cafeCompleto.GetDescription()}: R$ {cafeCompleto.GetCost():N2}");