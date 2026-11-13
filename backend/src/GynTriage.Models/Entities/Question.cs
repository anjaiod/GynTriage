using GynTriage.Models.Enums;

namespace GynTriage.Models.Entities;

public class Question
{
    public int Id { get; set; }
    public QuestionType Type { get; set; }
    public int SortOrder { get; set; }
    public string Text { get; set; } = string.Empty;
    public string? HelpText { get; set; }
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }
    public int? ParentAnswerOptionId { get; set; }
    public AnswerOption? ParentAnswerOption { get; set; }
    public bool IsGlobal { get; set; }
    public List<AnswerOption> AnswerOptions { get; set; } = [];
}
