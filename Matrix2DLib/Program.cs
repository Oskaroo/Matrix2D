// See https://aka.ms/new-console-template for more information

using Matrix2DLib;

var m = new Matrix2D(1, 2, 3, 4);
var p = new Matrix2D(5, 6, 7, 8);

Console.WriteLine(m.Equals(p));
Console.WriteLine(m == p);
Console.WriteLine("Dodawanie");
Console.WriteLine(m + p);
Console.WriteLine("Odejmowanie");
Console.WriteLine(m-p);
Console.WriteLine("Mnożenie macierzy");
Console.WriteLine(m*p);
Console.WriteLine("Mnożenie przez liczbę całowiką(lewostronne)");
Console.WriteLine(2*p);
Console.WriteLine("Mnożenie przez liczbę całowiką(prawostronne)");
Console.WriteLine(p*2);
Console.WriteLine("test dla drugiej macierzy");
Console.WriteLine(m*2);
Console.WriteLine("zmiana znaku macierz m");
Console.WriteLine(-m);
Console.WriteLine("transpozycja macierzy m");
Console.WriteLine(Matrix2D.Transpose(m));
Console.WriteLine("Determinant(m)");
Console.WriteLine(Matrix2D.Determinant(m));
Console.WriteLine("Det()");
Console.WriteLine(m.Det());