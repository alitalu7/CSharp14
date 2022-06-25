
Console.WriteLine("Bir metin giriniz...");
string cumle = Console.ReadLine();
bool deg = cumle.Contains("a");

if (deg)
{
    string cumle2 = cumle.Replace("a", "z");
    Console.WriteLine(cumle2);
}
else
{
    string cumle3 = cumle.ToUpper();
    Console.WriteLine(cumle3);
}

