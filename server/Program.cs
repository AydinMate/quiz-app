
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async (ctx, next) =>
{
    ctx.Response.Headers["Access-Control-Allow-Origin"] = "http://localhost:5173";

    if (HttpMethods.IsOptions(ctx.Request.Method))
    {
        ctx.Response.Headers["Access-Control-Allow-Headers"] = "*";
        ctx.Response.Headers["Access-Control-Allow-Methods"] = "GET, POST, PUT, DELETE";

        await ctx.Response.CompleteAsync();
        return;
    }

    await next();
});




app.MapGet("/get-answers", () => AnswerRepository.GetAnswers());
app.MapGet("/get-questions", () => QuestionRepository.GetQuestions());
app.MapGet("/get-questions-with-answers", () => QuestionsWithAnswersRepository.GetQuestionsWithAnswers());
app.MapGet("/get-random-question", () => RandomQuestion.GetRandomQuestion());
app.MapGet("/get-new-random-question", () => NewRandomQuestion.GetNewRandomQuestion());
app.MapGet("/get-random-questions", () => RandomQuestions.GetRandomQuestions(5));
app.MapPost("/check-answers", (CheckModel[] checkAnswers) => CheckAnswer.CheckAnswers(checkAnswers));


app.MapGet("/correct-answer-{id}" , (int id) => QuestionRepository.GetCorrectAnswerId(id));

app.Run();
