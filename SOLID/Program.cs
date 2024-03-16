using SOLID.OCP;
using SOLID.SRP;

#region SRP
var j = new Journal();
j.AddEntry("I cried today.");
j.AddEntry("I ate a bug.");

PersistenceManager pm = new();
var filename = "journal.txt";
pm.SaveToFile(j, filename, true);
#endregion

#region OCP
var apple = new Product("Apple", Color.Green, Size.Small);
var tree = new Product("Tree", Color.Green, Size.Large);
var house = new Product("House", Color.Blue, Size.Huge);

var products = new[] { apple, tree, house };

var pf = new ProductFilter();
Console.WriteLine("Green products (old):");
foreach (var p in pf.FilterByColor(products, Color.Green))
{
    Console.WriteLine($" - {p.Name} is green");
}

var bf = new BetterFilter();
Console.WriteLine("Green products (new):");
foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
{
    Console.WriteLine($" - {p.Name} is green");
}

Console.WriteLine("Large products:");
foreach (var p in bf.Filter(products, new SizeSpecification(Size.Large)))
{
    Console.WriteLine($" - {p.Name} is large");
}

Console.WriteLine("Large green items:");
foreach (var p in bf.Filter(products, new AndSpecification<Product>(new ColorSpecification(Color.Green), new SizeSpecification(Size.Large))))
{
    Console.WriteLine($" - {p.Name} is green and large");
}

# region OCP - BetterFilter with operator overloading
var largeGreenSpec = new ColorSpecification(Color.Green) & new SizeSpecification(Size.Large);
Console.WriteLine("Large green items (new):");
foreach (var p in bf.Filter(products, largeGreenSpec))
{
    Console.WriteLine($" - {p.Name} is green and large");
}
#endregion

# region OCP - BetterFilter with extension methods
var largeGreenSpec2 = Color.Green.And(Size.Large);
Console.WriteLine("Large green items (new):");
foreach (var p in bf.Filter(products, largeGreenSpec2))
{
    Console.WriteLine($" - {p.Name} is green and large");
}
#endregion
#endregion
