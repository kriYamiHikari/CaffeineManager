using SqlSugar;

namespace CaffeineManager.Model;

[SugarTable("caffeine_guide")]
public class CaffeineGuide
{
    [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
    public int Id { get; set; }

    public decimal? RangeStart { get; set; }
    public decimal? RangeEnd { get; set; }
    public string? Label { get; set; }
    public string? Conclusion { get; set; }
    public string? Advice { get; set; }
}