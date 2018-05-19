﻿using System.Data.Entity;
using Blog.Domain.Core;

namespace Blog.Infrastructure.Data
{
    public class UserDbInitializer:DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            db.Roles.Add(new Role { Id = 1, Name = "admin" });
            db.Roles.Add(new Role { Id = 2, Name = "user" });

            db.Users.Add(new User
            {
                Email = "admin@gmail.com",
                Password = "123456",
                RoleId = 1
            });

            db.Users.Add(new User
            {
                Email = "user@gmail.com",
                Password = "123456",
                RoleId = 2
            });

            base.Seed(db);
        }
    }
}