using System.ComponentModel.DataAnnotations;

public class Student
{
    [Required(ErrorMessage = "Ad boş bırakılamaz")]
    public string Ad { get; set; }

    [Range(1, 100, ErrorMessage = "Yaş 1 ile 100 arasında olmalı")]
    public int Yas { get; set; }

    [Required(ErrorMessage = "Email boş olamaz")]
    [EmailAddress(ErrorMessage = "Geçerli email gir")]
    public string Email { get; set; }
}