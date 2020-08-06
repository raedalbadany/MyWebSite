using System.ComponentModel.DataAnnotations;

namespace MyWebSite.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}