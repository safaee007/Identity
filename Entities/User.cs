using Microsoft.AspNetCore.Identity;

namespace Identity_SampleProject.Entities
{
    public class User:IdentityUser
    {
        public string Initials { get; set; }
    }
}
