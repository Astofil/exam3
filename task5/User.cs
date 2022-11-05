public class User
{
    public int userId;
    public string userName;
    public string password;
    public List<User> list;
    // public User(int userId, string userName,string password)
    // {
    //     this.userId=userId;
    //     this.userName=userName;
    //     this.password=password;
    // }
    public void AddInfo(User us)
    {
        list.Add(us);
    }
    public List<User> GetUserInfo()
    {
        return list;
    }
}