double NumberA = new Random().Next(1,10);
Console.WriteLine(NumberA);
double NumberB = new Random().Next(1,10);
Console.WriteLine(NumberB);
Console.WriteLine(NumberA + NumberB);
Console.WriteLine(NumberA / NumberB);

Console.WriteLine("Введите имя: ");

string username = Console.ReadLine();

if(username.ToLower() == "никита")
{
    Console.WriteLine("Ура, это же Никита");
}
else
{
    Console.WriteLine("Жаль, что это не Никита");
}
