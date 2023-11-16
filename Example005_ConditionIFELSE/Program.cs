Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Uraa, eto je Masha");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}