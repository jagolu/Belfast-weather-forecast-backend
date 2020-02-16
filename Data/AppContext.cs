using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace BelfastWF_bkend.Data
{
    public class AppContext : IdentityDbContext<IdentityUser>
    {
        public AppContext() : base("IdentityBelfastDB")
        {
        }

    }
}