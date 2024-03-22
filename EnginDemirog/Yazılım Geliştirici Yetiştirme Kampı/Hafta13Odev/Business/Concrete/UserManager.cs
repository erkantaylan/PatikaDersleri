using System.Collections.Generic;
using Business.Abstract;
using Core.DataAccess.Entities.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal userDal;

        public UserManager(IUserDal userDal)
        {
            this.userDal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return userDal.GetClaims(user);
        }

        //[SecuredOperation("car.add,admin")]
        public void Add(User user)
        {
            userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return userDal.Get(u => u.Email == email);
        }
    }
}