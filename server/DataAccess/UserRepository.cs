using Npgsql;

public class UserRepository
{
    public static UserModel GetValidation(string findUsername)
    {
        UserModel? user = null;
        using (var conn = DbConnection.GetDbConnection())
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM \"user-list\" WHERE username = @findUsername";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("findUsername", findUsername);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new UserModel
                            {
                                Id = reader.GetInt32(0),
                                Username = reader.GetString(1), 
                            };
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        return user!;
    }
}
