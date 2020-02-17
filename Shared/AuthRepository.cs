
using BelfastWF_bkend.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Threading.Tasks;

namespace BelfastWF_bkend.Shared
{
    public class AuthRepository : IDisposable
    {
        private Data.AppContext _ctx;

        private UserManager<IdentityUser> _userManager;

        public AuthRepository()
        {
            _ctx = new Data.AppContext();
            _userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(_ctx));
        }

        /**
         * Register a user in the app
         * @param userModel The information of the user
         */
        public async Task<IdentityResult> RegisterUser(UserModel userModel)
        {
            IdentityUser user = new IdentityUser
            {
                UserName = userModel.email
            };

            var result = await _userManager.CreateAsync(user, userModel.password);

            return result;
        }

        /**
         * Find a user in the user manager
         * @param userName. The email of the user
         * @param password. The password of the user
         */
        public async Task<IdentityUser> FindUser(string userName, string password)
        {
            IdentityUser user = await _userManager.FindAsync(userName, password);

            return user;
        }

        /**
         * Disposes the class
         */
        public void Dispose()
        {
            _ctx.Dispose();
            _userManager.Dispose();

        }
    }
}