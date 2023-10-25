
using Npgsql;

public class NewRandomQuestion
{
    public static QuestionModel GetNewRandomQuestion()
    {
        QuestionModel randomQuestion = new QuestionModel();
        using (var conn = DbConnection.GetDbConnection())
        {
            try
            {
                conn.Open();
                string questionQuery = "SELECT id AS Id, question AS Question, correct_answer_id AS CorrectAnswerId FROM \"new-questions\" ORDER BY random() LIMIT 1";

                using (var cmd = new NpgsqlCommand(questionQuery, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            randomQuestion = new QuestionModel(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                        }
                    }
                }

                string questionsQuery = "SELECT id AS Id, question_id AS QuestionId, answer AS Answer FROM \"new-answers\" WHERE question_id = @QuestionId";
                using (var cmd = new NpgsqlCommand(questionsQuery, conn))
                {
                    // Replace @QuestionId with the actual value
                    cmd.CommandText = cmd.CommandText.Replace("@QuestionId", randomQuestion.Id.ToString());

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            randomQuestion.Answers ??= new List<AnswerModel>();
                            randomQuestion.Answers.Add(new AnswerModel(reader.GetString(0), reader.GetInt32(1), reader.GetString(2)));
                        
                        }
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        return randomQuestion;
    }
}


