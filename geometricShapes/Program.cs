
using geometricShapes;
/*
//calling a static method
var fullname = Person.Fullname("Zach", "Tumbusch");
Console.WriteLine(fullname);

Console.WriteLine($"2 plus 3 equals {MathLib.Add(2, 3)}");
Console.WriteLine($"2 - 3 equals {MathLib.Subtract(2, 3)}");
Console.WriteLine($"2 x 3 equals {MathLib.Multiply(2, 3)}");
Console.WriteLine($"2 / 3 equals {MathLib.Divide(2, 0)}");
*/
/*
var startingNum = 0;
var endNum = 0;
Console.WriteLine("Enter a range of integers to find the cubes of all the numbers.");
Console.Write("enter the first number: ");
startingNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
endNum = Convert.ToInt32(Console.ReadLine());

//Console.Write($"{MathLib.CubedRange(startingNum, endNum)}");
int idx = startingNum - 1;
Console.WriteLine();
foreach (var item in MathLib.CubedRange(startingNum, endNum))
{
    idx++;
    Console.WriteLine($"{idx}  {item}");    
}
Console.WriteLine();
Console.WriteLine($"here are the cubes of all the numbers from {startingNum} to {endNum}");
Console.WriteLine();
*/

Quad q1 = new Quad(3, 4, 5, 6);

Rect r1 = new Rect(5, 3);

Square s1 = new Square(5);


Console.WriteLine($"Perimeter square    {s1.Perimeter()}");
Console.WriteLine($"Area square         {s1.Area()}");
Console.WriteLine($"Perimeter rectangle {r1.Perimeter()}");
Console.WriteLine($"Area rectangle      {r1.Area()}");
Console.WriteLine($"Perimeter quad      {q1.Perimeter()}");