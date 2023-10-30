using Npgsql;

public class RandomQuestions
{
    public static List<QuestionModel> GetRandomQuestions(int numberOfQuestions)
    {
        List<QuestionModel> randomQuestions = new List<QuestionModel>();
        using (var conn = DbConnection.GetDbConnection())
        {
            try
            {
                conn.Open();

                string questionQuery = "SELECT id AS Id, question AS Question, correct_answer_id AS CorrectAnswerId FROM \"new-questions\" ORDER BY random() LIMIT @NumberOfQuestions";

                using (var cmd = new NpgsqlCommand(questionQuery, conn))
                {
                    cmd.Parameters.AddWithValue("NumberOfQuestions", numberOfQuestions);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var question = new QuestionModel(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                            randomQuestions.Add(question);
                        }
                    }
                }

                string answerQuery = "SELECT id AS Id, question_id AS QuestionId, answer AS Answer FROM \"new-answers\" WHERE question_id = @QuestionId";
                using (var cmd = new NpgsqlCommand(answerQuery, conn))
                {
                    foreach (var question in randomQuestions)
                    {
                        cmd.Parameters.AddWithValue("QuestionId", question.Id!);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                question.Answers ??= new List<AnswerModel>();
                                question.Answers.Add(new AnswerModel(reader.GetString(0), reader.GetInt32(1), reader.GetString(2)));
                            }
                        }

                        cmd.Parameters.Clear();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        return randomQuestions;
    }
}
