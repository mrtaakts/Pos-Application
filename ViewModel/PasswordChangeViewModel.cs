using System.ComponentModel.DataAnnotations;

namespace pos.ViewModel
{
    public class PasswordChangeViewModel
    {
        [Display(Name="Eski Şifreniz")]
        [Required(ErrorMessage="Eski Şifreniz Gereklidir")]
        [DataType(DataType.Password)]
        [MinLength(4,ErrorMessage="Şifreniz en az 4 karakterli olmak zorundadır")]
        public string PasswordOld { get; set; }

        [Display(Name="Yeni Şifreniz")]
        [Required(ErrorMessage="Yeni Şifreniz Gereklidir")]
        [DataType(DataType.Password)]
        [MinLength(4,ErrorMessage="Şifreniz en az 4 karakterli olmak zorundadır")]
        
        public string PasswordNew { get; set; }

        [Display(Name="Onay yeni Şifreniz")]
        [Required(ErrorMessage="Onay yeni Şifreniz Gereklidir")]
        [DataType(DataType.Password)]
        [MinLength(4,ErrorMessage="Şifreniz en az 4 karakterli olmak zorundadır")]
        [Compare("PasswordNew",ErrorMessage="Yeni şifreniz ve Onay şifreniz birbirinden farklıdır")]
        public string PasswordConfirm { get; set; }
    }
}