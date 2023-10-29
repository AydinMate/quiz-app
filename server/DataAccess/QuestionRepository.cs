
using Npgsql;

public class QuestionRepository
{
    public static List<QuestionModel> GetQuestions()
    {
        List<QuestionModel> questions = new List<QuestionModel>();
        using (var conn = DbConnection.GetDbConnection())
        {
            try
            {
                conn.Open();
                string query = "SELECT id AS Id, question AS Question, correct_answer_id AS CorrectAnswerId FROM \"new-questions\"";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            questions.Add(new QuestionModel(reader.GetInt16(0), reader.GetString(1), reader.GetString(2)));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        return questions;
    }

    public static string GetCorrectAnswerId(int questionId)
    {
        string? correctAnswerId = "No answer found";

        using (var conn = DbConnection.GetDbConnection())
        {
            try
            {
                conn.Open();
                string query = "SELECT correct_answer_id FROM \"new-questions\" WHERE id = @questionId";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@questionId", questionId);

                    object? result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        correctAnswerId = result.ToString();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        if (correctAnswerId != null)
        {
            return correctAnswerId;
        }
        else
        {
            return "No answer found";
        }
    }

}
