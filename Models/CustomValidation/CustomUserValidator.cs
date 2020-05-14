using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using POS.Models;

namespace pos.Models.CustomValidation
{
    public class CustomUserValidator : IUserValidator<User>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<User> manager, User user)
        {

            List<IdentityError> errors = new List<IdentityError>();


            string[] Digits= new string[] {"0","1","2","3","4","5","6","7","8","9"};
            
            foreach(var item in Digits)
            {
                if(user.UserName[0].ToString()==item)
                {
                    errors.Add(new IdentityError(){
                        Code="UserNameContainsFirstLetterDigitContains",
                        Description = "Kullanıcı adının ilk karakteri sayısal karakter içeremez"
                    });
                }
            }
        
            if (errors.Count != 0)
            {
                return Task.FromResult(IdentityResult.Failed(errors.ToArray()));
            }

            else
            {
                return Task.FromResult(IdentityResult.Success);
                
            }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
    }
}