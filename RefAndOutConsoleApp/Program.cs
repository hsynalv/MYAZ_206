using ValueAndReferenceTypes;

//28 Şubat
void refAndValueType()
{
    var refType = new ReferenceType();
    int a = 23, b = 55;
    Console.WriteLine($"a: {a}  b: {b}");
    refType.SwapByRef(ref a, ref b);
    Console.WriteLine($"a: {a}  b: {b}");

    Console.WriteLine(new String('-', 50));

    refType.CheckOutKeyworkdByValue(b);
    Console.WriteLine(b);

    refType.CheckOutKeyworkdByRef(out b);
    Console.WriteLine(b);

    Console.ReadKey();
}


var byteArr = new int[] { 1, 2, 3, 4 };

byteArr.SetValue(10,0);
Console.WriteLine(byteArr.GetValue(2));

foreach (var item in byteArr)
{
    Console.WriteLine(item);
}




