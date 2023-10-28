var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use((ctx, next) =>
{
    ctx.Response.Headers["Access-Control-Allow-Origin"] = "*";

    return next();
});

app.MapGet("/get-answers", () => AnswerRepository.GetAnswers());
app.MapGet("/get-questions", () => QuestionRepository.GetQuestions());
app.MapGet("/get-questions-with-answers", () => QuestionsWithAnswersRepository.GetQuestionsWithAnswers());
app.MapGet("/get-random-question", () => RandomQuestion.GetRandomQuestion());
app.MapGet("/get-new-random-question", () => NewRandomQuestion.GetNewRandomQuestion());
app.MapGet("/get-random-questions", () => RandomQuestions.GetRandomQuestions(5));


app.Run();

