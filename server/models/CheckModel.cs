public class CheckModel
{
    public string Question { get; set; }

    public string? AnswerId { get; set; }
    public int QuestionId { get; set; }



    public CheckModel(string question, string answerId, int questionId)
    {
        Question = question;
        AnswerId = answerId;

        QuestionId = questionId;
    }

}