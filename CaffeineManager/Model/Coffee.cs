using SqlSugar;

namespace CaffeineManager.Model;

[SugarTable("coffee")]
public class Coffee
{
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
    public int Id { get; set; }

    [SugarColumn(ColumnName = "brand")] public string? Brand { get; set; } = null!;
    [SugarColumn(ColumnName = "name")] public string? Name { get; set; } = null!;

    [SugarColumn(ColumnName = "min_caffeine")]
    public decimal? MinCaffeine { get; set; }

    [SugarColumn(ColumnName = "max_caffeine")]
    public decimal? MaxCaffeine { get; set; }
}