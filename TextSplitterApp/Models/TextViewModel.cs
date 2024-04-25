using System.ComponentModel.DataAnnotations;

namespace TextSplitterApp.Models
{
    public class TextViewModel
    {
        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "The field Text must be a string with a minimum length of {2} and maximum length of {1}.")]
        public string Text { get; set; } = null!;

        public string SplitText { get; set; } = string.Empty;
    }
}
