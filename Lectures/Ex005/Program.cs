Console.Write("Ведите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "danis")
{
    Console.WriteLine("Салам, Danis");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}
