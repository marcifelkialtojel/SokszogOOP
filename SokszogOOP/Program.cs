// See https://aka.ms/new-console-template for more information
using SokszogOOP;

Console.WriteLine("Hello, World!");

Haromszog h1 = new Haromszog();
Haromszog h2 = new Haromszog(3, 4, 5);
Teglalap t1 = new Teglalap(3, 5);
Teglalap t2 = new Teglalap(4, 2);

Console.WriteLine(h1);
Console.WriteLine(h2);
Console.WriteLine(t1);
Console.WriteLine(t2);

Console.WriteLine(h2.AOldal);
try
{
	h2.AOldal = 10;
    Console.WriteLine(h2.AOldal);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();

