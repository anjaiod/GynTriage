namespace GynTriage.Models.Entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int SortOrder { get; set; }

    public List<Question> Questions { get; set; } = [];
    public List<TriageAction> TriageActions { get; set; } = [];
}