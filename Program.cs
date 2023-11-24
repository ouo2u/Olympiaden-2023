

Console.WriteLine("ordet ?");
string ordet= Console.ReadLine();



Console.WriteLine("Antal upprepningar ?");
int upprepningar=int.Parse(Console.ReadLine());



Console.WriteLine($"Svar: {String.Concat(Enumerable.Repeat(ordet, upprepningar))}");

