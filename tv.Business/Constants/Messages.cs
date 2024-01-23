using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tv.Core.Entity.Concrete;

namespace tv.Business.Constants
{
    public static class Messages
    {
        public static string AddSuccessful = "Add operation successful";
        public static string UpdateSuccessful = "Update operation successful";
        public static string DeleteSuccessful = "Delete operation successful";
        public static string AddError = "Error occured while adding";
        public static string UpdateError = "Error occured while updating";
        public static string DeleteError = "Error occured while deleting";

        public static string UserNotFound = "User not found";
        public static string CredentialError = "Email or password incorrect";
        public static string LoginSuccessful = "Login successful";
        public static string UserAlreadyExists = "User already exists";
        public static string UserRegistered = "Register successful";
        public static string AccessTokenCreated = "Access token created";
    }
}
