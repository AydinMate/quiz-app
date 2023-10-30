public class UserModel
{
    public int Id { get; set; }
    public string? Username { get; set; }

    public UserModel()
    { }

    public UserModel(int id, string username)
    {
        Id = id;
        Username = username;
    }

}

public class UsernameModel
{
    public string Username { get; set; }

 

    public UsernameModel(string username)
    {
        Username = username;
    }

}