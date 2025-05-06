using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Mango_API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }


}
