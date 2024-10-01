using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Facebook.ServiceLayer;
using Facebook.DomainModels;
using Facebook.ViewModels;

namespace Facebook.Controllers
{
    public class UsersController : ApiController
    {

        public string Post(RegistrationViewModel vm)
        {
            UsersService s;
            s = new UsersService();

             
            User dm = new DomainModels.User();
            dm.FirstName = vm.FirstName;
            dm.LastName = vm.LastName;
            dm.Email = vm.RegisterEmail;
            dm.Password = vm.RegisterPassword;
            dm.Mobile = vm.Mobile;
            dm.Gender = vm.Gender;
            dm.DateOfBirth = vm.DateOfBirth;
            dm.DateOfRegistration = DateTime.Now;

            s.InsertUser(dm);

            return "Successfully Registered";
        }

        public string GetLogin(string EmailToCheck, string PasswordToCheck)
        {
            UsersService s = new UsersService();

            //List<User> result = s.GetUsersByEmailAndPassword(EmailToCheck, PasswordToCheck);

            string msg;
            //if (result.Count == 1)
            {
                msg = "Valid login";
            }
            //else
            {
                //msg = "Invalid login, please try again";
            }

            return msg;
        }

    }
}
