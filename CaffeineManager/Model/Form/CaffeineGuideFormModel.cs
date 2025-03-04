using System.ComponentModel.DataAnnotations;

namespace CaffeineManager.Model.Form;

public class CaffeineGuideFormModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "请输入起始评估范围")]
    [Display(Name = "起始评估范围")]
    public decimal RangeStart { get; set; }

    [Required(ErrorMessage = "请输入结束评估范围")]
    [Display(Name = "结束评估范围")]
    public decimal RangeEnd { get; set; }

    [Required(ErrorMessage = "请输入评估标签")]
    [Display(Name = "评估标签")]
    public string? Label { get; set; }

    [Required(ErrorMessage = "请输入评估结论")]
    [Display(Name = "评估结论")]
    public string? Conclusion { get; set; }

    [Required(ErrorMessage = "请输入评估建议")]
    [Display(Name = "评估建议")]
    public string? Advice { get; set; }
}