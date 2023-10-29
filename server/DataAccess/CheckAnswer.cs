
public class CheckAnswer
{
    public static List<CheckedModel> CheckAnswers(CheckModel[] CheckAnswers)
    {
        List<CheckedModel> checkedAnswers = new List<CheckedModel>();


            foreach (CheckModel CheckAnswer in CheckAnswers)
            {   
                int questionId = CheckAnswer.QuestionId;
                string? chosenAnswerId = CheckAnswer.AnswerId;

                string? correctAnswerId = QuestionRepository.GetCorrectAnswerId(questionId);

                bool isCorrect = chosenAnswerId == correctAnswerId;
                checkedAnswers.Add(new CheckedModel(question: CheckAnswer.Question, isCorrect: isCorrect));
            }

        return checkedAnswers;

    }

}