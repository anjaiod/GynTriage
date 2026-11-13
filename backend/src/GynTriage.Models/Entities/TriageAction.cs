namespace GynTriage.Models.Entities;

public class TriageAction
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public List<Category> Categories { get; set; } = [];

}

