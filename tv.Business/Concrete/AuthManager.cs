using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tv.Business.Abstract;
using tv.Business.Constants;
using tv.Core.Entity.Concrete;
using tv.Core.Utilities.Hashing;
using tv.Core.Utilities.Results;
using tv.Core.Utilities.Security.Jwt;
using tv.Entity.Dtos;

namespace tv.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;
        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper; 
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var accesstoken =_tokenHelper.CreateToken(user, _userService.GetClaims(user).Data);
            return new SuccessDataResult<AccessToken>(accesstoken,Messages.AccessTokenCreated);
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email).Data;
            if (userToCheck == null) 
            {
                return new ErrorDataResult<User>(message:Messages.CredentialError);
            }
            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password,userToCheck.PasswordHash,userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>(message: Messages.CredentialError);
            }

            return new SuccessDataResult<User>(userToCheck,Messages.LoginSuccessful);
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(userForRegisterDto.Password, out passwordHash, out passwordSalt);
            User user = new User()
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true

            };
            _userService.Add(user);
            return new SuccessDataResult<User>(user,Messages.UserRegistered);

        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email).Data != null)
            {
                return new ErrorResult(Messages.UserAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
