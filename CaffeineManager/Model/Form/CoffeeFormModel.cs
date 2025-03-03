using System.ComponentModel.DataAnnotations;

namespace CaffeineManager.Model.Form;

public class CoffeeFormModel
{
    public int Id { get; init; }

    [Required(ErrorMessage = "请输入品牌！")]
    [Display(Name = "品牌")]
    public string? Brand { get; set; }

    [Required(ErrorMessage = "请输入名称！")]
    [Display(Name = "名称")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "请输入物品类型！")]
    [Display(Name = "类型")]
    public int? ItemType { get; set; }

    [Display(Name = "最小咖啡因")] public decimal MinCaffeine { get; set; }
    [Display(Name = "最大咖啡因")] public decimal MaxCaffeine { get; set; }
}