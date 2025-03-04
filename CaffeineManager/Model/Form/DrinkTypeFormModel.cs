using System.ComponentModel.DataAnnotations;

namespace CaffeineManager.Model.Form;

public class DrinkTypeFormModel
{
    public int Id { get; init; }

    [Required(ErrorMessage = "类型名不能为空！")]
    [Display(Name = "饮品类型")]
    public string? Text { get; set; }
}