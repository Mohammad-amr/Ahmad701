public class Exam
{
    public int ExamId { get; set; }
    public string Name { get; set; }
    public ICollection<Question> Questions { get; set; }
}

public class Question
{
    public int QuestionId { get; set; }
    public string Text { get; set; }
    public ICollection<Answer> Answers { get; set; }
    public Exam Exam { get; set; }
}

public class Answer
{
    public int AnswerId { get; set; }
    public string Text { get; set; }
    public bool IsCorrect { get; set; }
    public Question Question { get; set; }
}
