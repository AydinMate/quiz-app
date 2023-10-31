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

public class UpdateUserModel
{
    public int Id { get; set; }
    public int CorrectAnswers { get; set; }



    public UpdateUserModel(int id, int correctAnswers)
    {
        Id = id;
        CorrectAnswers = correctAnswers;
    }

}