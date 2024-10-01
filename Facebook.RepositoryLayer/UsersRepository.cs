using System;
using System.Collections.Generic;
using System.Linq;
using Facebook.DomainModels;

namespace Facebook.RepositoryLayer
{
    public class UsersRepository
    {

        public void InsertUser(User u)
        {
            facebookdatabaseEntities db;
            db = new facebookdatabaseEntities();
            db.insertuser(u.FirstName, u.LastName, u.Email, u.Mobile, u.Password, u.DateOfBirth, u.Gender, u.DateOfRegistration);
        }

        public List<User> GetUsersByEmail(string EmailToCheck)
        {
            facebookdatabaseEntities db;
            db = new facebookdatabaseEntities();

            var result = (from u in db.Users where u.Email == EmailToCheck select u).ToList(); //select * from users where Email=EmailToCheck

            return result;
        }

        public List<User> GetUsersByEmailAndPassword(string EmailToCheck, string PasswordToCheck)
        {
            facebookdatabaseEntities db;
            db = new facebookdatabaseEntities();

            var result = (from u in db.Users where u.Email == EmailToCheck && u.Password == PasswordToCheck select u).ToList(); //select * from users where Email=EmailToCheck and Password=PasswordToCheck

            return result;
        }

    }
}
