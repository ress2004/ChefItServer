﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ChefItServerBL.Models
{
    class ChefItDBContext:DbContext
    {
        public User Login(string email, string pswd)
        {
            User user = this.Users
                .Include(us => us.UserContacts)
                .ThenInclude(uc => uc.ContactPhones)
                .Where(u => u.Email == email && u.UserPswd == pswd).FirstOrDefault();

            return user;
        }
    }

}
