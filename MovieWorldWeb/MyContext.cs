using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieWorldWebEL.IdentityModels;

namespace MovieWorldWeb
{
    public class MyContext :IdentityDbContext<AppUser>
    {
        public MyContext(DbContextOptions<MyContext> options)
      : base(options)
        {

        }
    }
}
