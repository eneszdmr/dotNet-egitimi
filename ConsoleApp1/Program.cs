// See https://aka.ms/new-console-template for more information

double exam1, exam2, exam3, result;

Console.WriteLine("lütfen 1. sınav notunuzu giriniz: ");
exam1=double.Parse(Console.ReadLine());

Console.WriteLine("Lütfen 2. sınav notunuzu giriniz: ");
exam2 = double.Parse(Console.ReadLine());

Console.WriteLine("Lütfen 3. sınav notunuzu giriniz: ");
exam3 = double.Parse(Console.ReadLine());

result = (exam1 + exam2 + exam3) / 3;

Console.WriteLine();
Console.WriteLine("sonucunuz : " + result);

Console.Read();