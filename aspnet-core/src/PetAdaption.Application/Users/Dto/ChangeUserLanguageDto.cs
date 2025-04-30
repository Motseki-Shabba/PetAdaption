using System.ComponentModel.DataAnnotations;

namespace PetAdaption.Users.Dto;

public class ChangeUserLanguageDto
{
    [Required]
    public string LanguageName { get; set; }
}