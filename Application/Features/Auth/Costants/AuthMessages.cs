using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Auth.Costants
{
    public class AuthMessages
    {
        public const string EmailAuthenticatorDontExists= "Email authenticator don't exists";
        public const string OtpAuthenticatorDontExists = "Otp authenticator don't exists";
        public const string AlreadyVerifiedOtpAuthenticatorExists = "Already verified otp authenticator is exists";
        public const string EmailActivationAuthenticatorDontExists= "Email Activation don't exists";
        public const string UserDontExists= "User don't exists";
        public const string UserHaveAlreadyAuthenticator= "User have elready a uthenticator.";
        public const string RefreshDontExists= "Refresh Don't exists";
        public const string InvalidRefreshToken = "Invalid refresh token";
        public const string UserMailAlreadyExists = "User mail already exists";
        public const string PasswordDontMatch = "Password don't match";
       
        

    }
}
