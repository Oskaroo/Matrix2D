// See https://aka.ms/new-console-template for more information

using Matrix2DLib;

var m = new Matrix2D(1, 2, 3, 4);
var p = new Matrix2D(5, 6, 7, 8);

Console.WriteLine(m.Equals(p));
Console.WriteLine(m == p);
Console.WriteLine(m + p);
Console.WriteLine(m-p);
Console.WriteLine(m*p);