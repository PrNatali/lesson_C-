Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Матвей")
{
    Console.WriteLine("Ура, это же Матвей!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
