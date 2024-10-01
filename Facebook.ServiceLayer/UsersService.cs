using System;
using Facebook.DomainModels;
using Facebook.RepositoryLayer;
using System.Collections.Generic;

namespace Facebook.ServiceLayer
{
    public class UsersService
    {
        public void InsertUser(User u)
        {
            UsersRepository r;
            r = new UsersRepository();
            if (u.FirstName != "" && u.LastName != "" && u.Password != "" && u.Password.Length >=6 && u.Email != "" && u.Email.EndsWith(".com") && GetUsersByEmail(u.Email).Count == 0)
                r.InsertUser(u);
        }

        public List<User> GetUsersByEmail(string EmailToCheck)
        {
            UsersRepository r;
            r = new UsersRepository();

            return r.GetUsersByEmail(EmailToCheck);
        }

        public List<User> GetUsersByEmailAndPassword(string EmailToCheck, string PasswordToCheck)
        {
            UsersRepository r;
            r = new UsersRepository();

            return r.GetUsersByEmailAndPassword(EmailToCheck, PasswordToCheck);
        }




    }

}
