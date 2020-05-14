using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using POS.Models;


namespace pos.Models.CustomValidation
{
    public class CustomPasswordValidator : IPasswordValidator<User>
    {
        public Task <IdentityResult> ValidateAsync (UserManager <User> manager, User user, string password )
        {
            List <IdentityError> errors =new List<IdentityError>();

            if(password.ToLower().Contains(user.UserName.ToLower()))
            {
                if(!user.Email.Contains(user.UserName))
                {

              
                errors.Add(new IdentityError()
                {
                    Code="PasswordContainsUserName", Description = "şifre alanı kullanıcı adı içeremez"
                   
                });
                
                }
                
            }


            if(password.ToLower().Contains("1234"))
            {
                
                 errors.Add(new IdentityError()
                {
                    Code="PasswordContains1234", Description = "şifre alanı ardışık sayı içeremez"
                });
                
            }

             if(password.ToLower().Contains(user.Email.ToLower()))
            {
                
                 errors.Add(new IdentityError()
                {
                    Code="PasswordContainsEmail", Description = "şifre alanı email adresinizi içeremez"
                });
                
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