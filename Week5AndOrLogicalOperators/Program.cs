string username, password;
Console.WriteLine("Enter username:");
username = Console.ReadLine();
Console.WriteLine("Enter password:");
password = Console.ReadLine();
if (username!= "admin" || password!= "admin1234")
{
    Console.WriteLine("Invalid user credentials");
}
else
{
    Console.WriteLine("Welcome!");
}
//if (username == "admin" && password == "admin1234")
//{
//    Console.WriteLine("Welcome");
//}
//else
//{
//    Console.WriteLine("Invalid user credentials");
//}
