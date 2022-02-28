using ValueAndReferenceTypes;

var refType = new ReferenceType();
int a = 23, b = 55;
Console.WriteLine($"a: {a}  b: {b}");
refType.SwapByValue(a, b);
Console.WriteLine($"a: {a}  b: {b}");
Console.ReadKey();

