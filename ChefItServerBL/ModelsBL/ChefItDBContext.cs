using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ChefItServerBL.Models
{
   public  partial class  ChefItDBContext:DbContext
    {
        public User Login(string email, string pswd)
        {
            User user = this.Users
                .Where(u => u.Email == email && u.Pswd == pswd).FirstOrDefault();

            return user;
        }
    }

}
