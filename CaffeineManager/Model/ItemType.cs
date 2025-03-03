using SqlSugar;

namespace CaffeineManager.Model;

[SugarTable("item_type")]
public class ItemType
{
    [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
    public int Id { get; set; }

    public string? Text { get; set; }
}