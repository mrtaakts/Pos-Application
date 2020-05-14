using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using POS.Models;

namespace pos.ViewModel {
    public class UserViewModel {

        [Required (ErrorMessage = "Kullanıcı ismi gereklidir")]
        [Display (Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        [Display (Name = "Tel No:")]
        [DataType (DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required (ErrorMessage = "Email  gereklidir")]
        [Display (Name = "Kullanıcı Email")]
        [EmailAddress (ErrorMessage = "Emailinizi Doğru formatta giriniz")]
        public string Email { get; set; }

        [Required (ErrorMessage = "Şifreniz gereklidir")]
        [Display (Name = "Şifre")]
        [DataType (DataType.Password)]
        public string Password { get; set; }


    }
}