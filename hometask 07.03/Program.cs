while (true)
{
    Console.Write("Please enter Username : ");
    string username = Console.ReadLine();
    Console.Write("Password : ");
    string password = Console.ReadLine();
    user user1 = new user(username, password);
    if (user1.Password != null && user1.UserName != null)
    {
        Console.WriteLine("Successfull Access");
        break;

    }
    else
    {
        Console.WriteLine("Password must contain upper case,min 8 car.and digit. \nUsername and Password don't contain");
    }
}