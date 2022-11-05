var user=new User();

user.userId=1;
user.userName="Astofil";
user.password="just be the best";

user.AddInfo(user);
foreach (var item in user.GetUserInfo())
{
    System.Console.WriteLine($"{item.userId}                  {item.userName}            {item.password}  ");
}
