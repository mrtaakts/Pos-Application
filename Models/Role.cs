using Microsoft.AspNetCore.Identity;

namespace pos.Models {
    public class Role : IdentityRole {
        public string Roletype { get; set; }
    }
}