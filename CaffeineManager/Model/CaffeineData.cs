using SqlSugar;

namespace CaffeineManager.Model;

[SugarTable("caffeine_data")]
public class CaffeineData
{
    [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
    public int Id { get; set; }

    public string? Brand { get; set; }
    public string? Name { get; set; }

    public int Type { get; set; }

    [Navigate(NavigateType.OneToOne, nameof(Type))]
    public ItemType? ItemType { get; set; }
    public decimal? MinCaffeine { get; set; }
    public decimal? MaxCaffeine { get; set; }
}