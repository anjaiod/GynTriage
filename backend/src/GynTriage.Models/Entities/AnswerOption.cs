namespace GynTriage.Models.Entities;

public class AnswerOption
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public int QuestionId { get; set; }
    public Question Question { get; set; } = null!;
    public string? Advice { get; set; }
    public int SortOrder { get; set; }
    public List<Question> FollowUpQuestions { get; set; } = [];
}
